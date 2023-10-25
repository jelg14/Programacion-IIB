using EFPrograIIIB.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFPrograIIIB
{
    public partial class MainForm : Form
    {
        private ProductsContext? dbContext;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.dbContext = new ProductsContext();
            //this.dbContext.Database.EnsureDeleted(); crea la base de datos cada vez que se ejecuta
            this.dbContext.Database.EnsureCreated(); //unicamente la crea una vez y la utiliza n veces
            this.dbContext.Categories.Load();
            this.categoryBindingSource.DataSource = dbContext.Categories.Local.ToBindingList();

        }
        protected override void OnClick(EventArgs e)
        {
            base.OnClick(e);
            this.dbContext?.Dispose();
            this.dbContext = null;
        }

        private void dataGridViewCategories_SelectionChanged(object sender, EventArgs e)
        {


        }

        private void dataGridViewCategories_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                if (this.dbContext != null)
                {
                    if (this.dataGridViewCategories.CurrentRow != null)
                    {
                        var category = (Category)this.dataGridViewCategories.CurrentRow.DataBoundItem;
                        if (category != null)
                        {
                            this.dbContext.Entry(category).Collection(e => e.Products).Load();
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            this.dbContext!.SaveChanges();
            this.dataGridViewCategories.Refresh();
            this.dataGridViewProducts.Refresh();
        }

        private void btnCargarProductos_Click(object sender, EventArgs e)
        {
            //Cargar un solo objeto por id
            var category = dbContext!.Categories.Single(c => c.CategoryId == 1);
            //Cargar por nombre
            var categories = dbContext!.Categories.Where(c => c.Name.StartsWith("P")).ToList();
            //using de conexion 
            //parametrizacion
            //Ejecucion para guardar
            //adapter
            //ejecutabamos el query
            //cargabamos

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                //Context de DB instanciado
                //Seleccionar la entidad (modelo, dbset)
                //add, update, delete, 
                //Guardar cambios SaveChanges
                this.dbContext!.Categories.Add(new Category { CategoryId = 56, Name = "herramientas" });
                this.dbContext!.SaveChanges(true);
            }
            catch (Exception ex)
            {
                //guadar el error
                MessageBox.Show(ex.Message.ToString());
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Eliminar
            Category medicina = this.dbContext!.Categories.Single(c => c.CategoryId == 53);
            this.dbContext!.Categories.Remove(medicina);
            this.dbContext!.SaveChanges();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Actualizar(modificar)
            Category categoria = this.dbContext!.Categories.Single(c => c.CategoryId == 61);
            categoria.Name = "Modificado";
            this.dbContext!.SaveChanges();
        }

        private void agregarProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var prod = new AgregarProducto()) { prod.ShowDialog(); }
        }

        private void agregarCategoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var cat = new AgregarCategoria()) { cat.ShowDialog(); }
        }
        //Hacer 2 forms, uno para categoria y otro para producto
    }
}
