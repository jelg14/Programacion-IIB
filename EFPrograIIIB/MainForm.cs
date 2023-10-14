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

        private void dataGridViewCategories_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.dbContext != null)
            {
                var category = (Category)this.dataGridViewCategories.CurrentRow.DataBoundItem;
                if (category != null)
                {
                    this.dbContext.Entry(category).Collection(e => e.Products).Load();
                }
            }
        }

    }
}

