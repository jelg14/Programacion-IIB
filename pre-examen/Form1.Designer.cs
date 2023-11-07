namespace pre_examen
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.CategoriaGridView = new System.Windows.Forms.DataGridView();
            this.iDcategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosDataSet = new pre_examen.ProductosDataSet();
            this.CorteGridView = new System.Windows.Forms.DataGridView();
            this.cortesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasTableAdapter = new pre_examen.ProductosDataSetTableAdapters.CategoriasTableAdapter();
            this.cortesTableAdapter = new pre_examen.ProductosDataSetTableAdapters.CortesTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNombreCat = new System.Windows.Forms.TextBox();
            this.txtCorte = new System.Windows.Forms.TextBox();
            this.btnGuardarCat = new System.Windows.Forms.Button();
            this.btnGuardarProd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbIDCat = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.categoriasBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.cbIsPremium = new System.Windows.Forms.ComboBox();
            this.categoriasBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDcategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.esPremiumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriasBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.btnActualizarCat = new System.Windows.Forms.Button();
            this.btnActualizarProd = new System.Windows.Forms.Button();
            this.txtIDca = new System.Windows.Forms.TextBox();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            this.btnEliminarCo = new System.Windows.Forms.Button();
            this.txtIDco = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorteGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cortesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // CategoriaGridView
            // 
            this.CategoriaGridView.AutoGenerateColumns = false;
            this.CategoriaGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CategoriaGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDcategoriaDataGridViewTextBoxColumn,
            this.nombreCategoriaDataGridViewTextBoxColumn});
            this.CategoriaGridView.DataSource = this.categoriasBindingSource;
            this.CategoriaGridView.Location = new System.Drawing.Point(12, 23);
            this.CategoriaGridView.Name = "CategoriaGridView";
            this.CategoriaGridView.Size = new System.Drawing.Size(245, 267);
            this.CategoriaGridView.TabIndex = 0;
            this.CategoriaGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CategoriaGridView_CellMouseClick);
            // 
            // iDcategoriaDataGridViewTextBoxColumn
            // 
            this.iDcategoriaDataGridViewTextBoxColumn.DataPropertyName = "IDcategoria";
            this.iDcategoriaDataGridViewTextBoxColumn.HeaderText = "IDcategoria";
            this.iDcategoriaDataGridViewTextBoxColumn.Name = "iDcategoriaDataGridViewTextBoxColumn";
            this.iDcategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "NombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "NombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            // 
            // categoriasBindingSource
            // 
            this.categoriasBindingSource.DataMember = "Categorias";
            this.categoriasBindingSource.DataSource = this.productosDataSet;
            // 
            // productosDataSet
            // 
            this.productosDataSet.DataSetName = "ProductosDataSet";
            this.productosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CorteGridView
            // 
            this.CorteGridView.AutoGenerateColumns = false;
            this.CorteGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CorteGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.IDcategoria,
            this.corteDataGridViewTextBoxColumn,
            this.esPremiumDataGridViewTextBoxColumn});
            this.CorteGridView.DataSource = this.cortesBindingSource;
            this.CorteGridView.Location = new System.Drawing.Point(351, 23);
            this.CorteGridView.Name = "CorteGridView";
            this.CorteGridView.Size = new System.Drawing.Size(346, 267);
            this.CorteGridView.TabIndex = 1;
            this.CorteGridView.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.CorteGridView_CellMouseClick);
            // 
            // cortesBindingSource
            // 
            this.cortesBindingSource.DataMember = "Cortes";
            this.cortesBindingSource.DataSource = this.productosDataSet;
            // 
            // categoriasTableAdapter
            // 
            this.categoriasTableAdapter.ClearBeforeFill = true;
            // 
            // cortesTableAdapter
            // 
            this.cortesTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 309);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(252, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar Categoria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(436, 309);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "AgregarProducto";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 366);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Categoria";
            // 
            // txtNombreCat
            // 
            this.txtNombreCat.Location = new System.Drawing.Point(73, 362);
            this.txtNombreCat.Name = "txtNombreCat";
            this.txtNombreCat.Size = new System.Drawing.Size(109, 20);
            this.txtNombreCat.TabIndex = 6;
            // 
            // txtCorte
            // 
            this.txtCorte.Location = new System.Drawing.Point(470, 359);
            this.txtCorte.Name = "txtCorte";
            this.txtCorte.Size = new System.Drawing.Size(164, 20);
            this.txtCorte.TabIndex = 7;
            // 
            // btnGuardarCat
            // 
            this.btnGuardarCat.Location = new System.Drawing.Point(18, 388);
            this.btnGuardarCat.Name = "btnGuardarCat";
            this.btnGuardarCat.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarCat.TabIndex = 8;
            this.btnGuardarCat.Text = "Guardar";
            this.btnGuardarCat.UseVisualStyleBackColor = true;
            this.btnGuardarCat.Click += new System.EventHandler(this.btnGuardarCat_Click);
            // 
            // btnGuardarProd
            // 
            this.btnGuardarProd.Location = new System.Drawing.Point(442, 412);
            this.btnGuardarProd.Name = "btnGuardarProd";
            this.btnGuardarProd.Size = new System.Drawing.Size(75, 23);
            this.btnGuardarProd.TabIndex = 9;
            this.btnGuardarProd.Text = "Guardar";
            this.btnGuardarProd.UseVisualStyleBackColor = true;
            this.btnGuardarProd.Click += new System.EventHandler(this.btnGuardarProd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Premium";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(421, 362);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Corte";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(418, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "IDCategoria";
            // 
            // cbIDCat
            // 
            this.cbIDCat.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.categoriasBindingSource, "IDcategoria", true));
            this.cbIDCat.DataSource = this.categoriasBindingSource;
            this.cbIDCat.DisplayMember = "IDcategoria";
            this.cbIDCat.FormattingEnabled = true;
            this.cbIDCat.Location = new System.Drawing.Point(487, 385);
            this.cbIDCat.Name = "cbIDCat";
            this.cbIDCat.Size = new System.Drawing.Size(90, 21);
            this.cbIDCat.TabIndex = 13;
            this.cbIDCat.ValueMember = "IDcategoria";
            // 
            // categoriasBindingSource2
            // 
            this.categoriasBindingSource2.DataMember = "Categorias";
            this.categoriasBindingSource2.DataSource = this.productosDataSet;
            // 
            // categoriasBindingSource3
            // 
            this.categoriasBindingSource3.DataMember = "Categorias";
            this.categoriasBindingSource3.DataSource = this.productosDataSet;
            // 
            // cbIsPremium
            // 
            this.cbIsPremium.FormattingEnabled = true;
            this.cbIsPremium.Items.AddRange(new object[] {
            "si",
            "no"});
            this.cbIsPremium.Location = new System.Drawing.Point(640, 385);
            this.cbIsPremium.Name = "cbIsPremium";
            this.cbIsPremium.Size = new System.Drawing.Size(57, 21);
            this.cbIsPremium.TabIndex = 14;
            // 
            // categoriasBindingSource1
            // 
            this.categoriasBindingSource1.DataMember = "Categorias";
            this.categoriasBindingSource1.DataSource = this.productosDataSet;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            this.iDDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // IDcategoria
            // 
            this.IDcategoria.DataPropertyName = "IDcategoria";
            this.IDcategoria.HeaderText = "IDcategoria";
            this.IDcategoria.Name = "IDcategoria";
            // 
            // corteDataGridViewTextBoxColumn
            // 
            this.corteDataGridViewTextBoxColumn.DataPropertyName = "Corte";
            this.corteDataGridViewTextBoxColumn.HeaderText = "Corte";
            this.corteDataGridViewTextBoxColumn.Name = "corteDataGridViewTextBoxColumn";
            // 
            // esPremiumDataGridViewTextBoxColumn
            // 
            this.esPremiumDataGridViewTextBoxColumn.DataPropertyName = "EsPremium";
            this.esPremiumDataGridViewTextBoxColumn.HeaderText = "EsPremium";
            this.esPremiumDataGridViewTextBoxColumn.Name = "esPremiumDataGridViewTextBoxColumn";
            // 
            // categoriasBindingSource4
            // 
            this.categoriasBindingSource4.DataMember = "Categorias";
            this.categoriasBindingSource4.DataSource = this.productosDataSet;
            // 
            // btnActualizarCat
            // 
            this.btnActualizarCat.Location = new System.Drawing.Point(99, 388);
            this.btnActualizarCat.Name = "btnActualizarCat";
            this.btnActualizarCat.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarCat.TabIndex = 15;
            this.btnActualizarCat.Text = "Actualizar";
            this.btnActualizarCat.UseVisualStyleBackColor = true;
            this.btnActualizarCat.Click += new System.EventHandler(this.btnActualizarCat_Click);
            // 
            // btnActualizarProd
            // 
            this.btnActualizarProd.Location = new System.Drawing.Point(523, 412);
            this.btnActualizarProd.Name = "btnActualizarProd";
            this.btnActualizarProd.Size = new System.Drawing.Size(75, 23);
            this.btnActualizarProd.TabIndex = 16;
            this.btnActualizarProd.Text = "Actualizar";
            this.btnActualizarProd.UseVisualStyleBackColor = true;
            this.btnActualizarProd.Click += new System.EventHandler(this.btnActualizarProd_Click);
            // 
            // txtIDca
            // 
            this.txtIDca.Enabled = false;
            this.txtIDca.Location = new System.Drawing.Point(188, 362);
            this.txtIDca.Name = "txtIDca";
            this.txtIDca.Size = new System.Drawing.Size(32, 20);
            this.txtIDca.TabIndex = 17;
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Location = new System.Drawing.Point(180, 388);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCat.TabIndex = 18;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
            // 
            // btnEliminarCo
            // 
            this.btnEliminarCo.Location = new System.Drawing.Point(604, 412);
            this.btnEliminarCo.Name = "btnEliminarCo";
            this.btnEliminarCo.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCo.TabIndex = 19;
            this.btnEliminarCo.Text = "Eliminar";
            this.btnEliminarCo.UseVisualStyleBackColor = true;
            this.btnEliminarCo.Click += new System.EventHandler(this.btnEliminarCo_Click);
            // 
            // txtIDco
            // 
            this.txtIDco.Enabled = false;
            this.txtIDco.Location = new System.Drawing.Point(641, 359);
            this.txtIDco.Name = "txtIDco";
            this.txtIDco.Size = new System.Drawing.Size(56, 20);
            this.txtIDco.TabIndex = 20;
            this.txtIDco.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 473);
            this.Controls.Add(this.txtIDco);
            this.Controls.Add(this.btnEliminarCo);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.txtIDca);
            this.Controls.Add(this.btnActualizarProd);
            this.Controls.Add(this.btnActualizarCat);
            this.Controls.Add(this.cbIsPremium);
            this.Controls.Add(this.cbIDCat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnGuardarProd);
            this.Controls.Add(this.btnGuardarCat);
            this.Controls.Add(this.txtCorte);
            this.Controls.Add(this.txtNombreCat);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CorteGridView);
            this.Controls.Add(this.CategoriaGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CategoriaGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CorteGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cortesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriasBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CategoriaGridView;
        private System.Windows.Forms.DataGridView CorteGridView;
        private ProductosDataSet productosDataSet;
        private System.Windows.Forms.BindingSource categoriasBindingSource;
        private ProductosDataSetTableAdapters.CategoriasTableAdapter categoriasTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDcategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource cortesBindingSource;
        private ProductosDataSetTableAdapters.CortesTableAdapter cortesTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNombreCat;
        private System.Windows.Forms.TextBox txtCorte;
        private System.Windows.Forms.Button btnGuardarCat;
        private System.Windows.Forms.Button btnGuardarProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbIDCat;
        private System.Windows.Forms.ComboBox cbIsPremium;
        private System.Windows.Forms.BindingSource categoriasBindingSource1;
        private System.Windows.Forms.BindingSource categoriasBindingSource2;
        private System.Windows.Forms.BindingSource categoriasBindingSource3;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDcategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn corteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn esPremiumDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource categoriasBindingSource4;
        private System.Windows.Forms.Button btnActualizarCat;
        private System.Windows.Forms.Button btnActualizarProd;
        private System.Windows.Forms.TextBox txtIDca;
        private System.Windows.Forms.Button btnEliminarCat;
        private System.Windows.Forms.Button btnEliminarCo;
        private System.Windows.Forms.TextBox txtIDco;
    }
}

