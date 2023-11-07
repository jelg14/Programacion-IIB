using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pre_examen
{
    public partial class Form1 : Form
    {
        private ProductosEntities products;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /* TODO: esta línea de código carga datos en la tabla 'productosDataSet.Categorias' Puede moverla o quitarla según sea necesario.
            this.categoriasTableAdapter.Fill(this.productosDataSet.Categorias);*/
            this.products = new ProductosEntities();
            this.products.Database.CreateIfNotExists();
            this.products.Categorias.Load();
            this.categoriasBindingSource.DataSource = products.Categorias.Local.ToBindingList();
        }

        private void btnGuardarCat_Click(object sender, EventArgs e)
        {
            products = new ProductosEntities();
            Categoria categoria = new Categoria
            {
                NombreCategoria = txtNombreCat.Text
            };
            products.Categorias.Add(categoria);;
            if (products.SaveChanges() > 0)
            {
                this.products.Categorias.Load();
                this.categoriasBindingSource.DataSource = products.Categorias.Local.ToBindingList();
                MessageBox.Show("Categoria agregada correctamente", "categorias", MessageBoxButtons.OK);
            }
        }

        private void btnGuardarProd_Click(object sender, EventArgs e)
        {
            products = new ProductosEntities();
            Corte corte = new Corte
            {
                Corte1 = txtCorte.Text,
                IDcategoria = int.Parse(cbIDCat.Text),
                EsPremium = cbIsPremium.Text
            };
            products.Cortes.Add(corte);
            if(products.SaveChanges() > 0)
            {
                this.cortesTableAdapter.Fill(this.productosDataSet.Cortes);
                MessageBox.Show("Producto agregada correctamente", "productos", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Hubo un error al ingresar los datos", "productos",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void CorteGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            txtIDco.Text = CorteGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtCorte.Text = CorteGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            cbIDCat.Text = CorteGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            cbIsPremium.Text = CorteGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
        private void CategoriaGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            this.products = new ProductosEntities();

            try
            {
                var filtro = Convert.ToInt32( CategoriaGridView.Rows[e.RowIndex].Cells[0].Value); // guarda valor de id de la fila seleccionada
                cortesTableAdapter.Fill(this.productosDataSet.Cortes); //llenar datagridview primero, a continuacion se realiza filtro

                //creacion y carga de datos a gridview de cortes
                this.products.Database.CreateIfNotExists();
                this.products.Cortes.Load();

                // uso de defaultView para modificar lo almacenado en el gridview por medio de una consulta SQL
                this.CorteGridView.DataSource = productosDataSet.Cortes;
                productosDataSet.Cortes.DefaultView.RowFilter = $"IDcategoria = {filtro}";
                var catN = CategoriaGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                var id = CategoriaGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

                txtNombreCat.Text = catN;
                txtIDca.Text = id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        private void btnActualizarCat_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtIDca.Text);
            Categoria categoria = this.products.Categorias.SingleOrDefault(x => x.IDcategoria == id);
            categoria.NombreCategoria = txtNombreCat.Text;
            if(products.SaveChanges() > 0)
            {
                this.products.Categorias.Load();
                this.categoriasBindingSource.DataSource = products.Categorias.Local.ToBindingList();
                MessageBox.Show("categoria actualizada correctamente", "categorias", MessageBoxButtons.OK);
            }
        }
        //actualizar
        private void btnActualizarProd_Click(object sender, EventArgs e)
        {
        //    var id = Convert.ToInt32(txtIDco.Text);
        //    Corte corte = this.products.Cortes.SingleOrDefault(x => x.ID == id);
        //    corte.Corte1 = txtCorte.Text;
        //    corte.IDcategoria = int.Parse(cbIDCat.Text);
        //    corte.EsPremium = cbIsPremium.Text;
        //    products.SaveChanges();
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtIDca.Text);
            Categoria categoria = this.products.Categorias.SingleOrDefault(x => x.IDcategoria == id);
            this.products.Categorias.Remove(categoria);
            if (products.SaveChanges() > 0)
            {
                this.products.Categorias.Load();
                this.categoriasBindingSource.DataSource = products.Categorias.Local.ToBindingList();
                MessageBox.Show("categoria eliminada correctamente", "categorias", MessageBoxButtons.OK);
            }
        }

        private void btnEliminarCo_Click(object sender, EventArgs e)
        {
            var id = Convert.ToInt32(txtIDco.Text);
            Corte corte = this.products.Cortes.SingleOrDefault(x => x.ID == id);
            this.products.Cortes.Remove(corte);
            products.SaveChanges();
        }

        
    }
}
