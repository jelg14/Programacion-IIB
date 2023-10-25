using EFPrograIIIB.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EFPrograIIIB
{
    public partial class AgregarCategoria : Form
    {
        //public ProductsContext? dbContext;
        public AgregarCategoria()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtIdCat.Text);

            try
            {
                if(txtIdCat.Text != null && txtNombreCat.Text != null)
                {
                    ProductsContext dbContext = new ProductsContext();
                    dbContext!.Categories.Add(new Category { CategoryId = id, Name = txtNombreCat.Text });
                    dbContext!.SaveChanges(true);
                    vaciarForm();
                }
                else MessageBox.Show("error: datos nulos");
                
               
            }
            catch (Exception ex)
            {
                //guadar el error
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void vaciarForm()
        {
            txtIdCat.Text = "";
            txtNombreCat.Text = "";
        }
    }
}
