namespace EFPrograIIIB
{
    partial class AgregarCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            label1 = new Label();
            label2 = new Label();
            txtIdCat = new TextBox();
            txtNombreCat = new TextBox();
            btnGuardar = new Button();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(307, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 30);
            label1.Name = "label1";
            label1.Size = new Size(69, 15);
            label1.TabIndex = 1;
            label1.Text = "IDCategoria";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 81);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 2;
            label2.Text = "NombreCategoria";
            // 
            // txtIdCat
            // 
            txtIdCat.Location = new Point(86, 27);
            txtIdCat.Name = "txtIdCat";
            txtIdCat.Size = new Size(80, 23);
            txtIdCat.TabIndex = 3;
            // 
            // txtNombreCat
            // 
            txtNombreCat.Location = new Point(120, 78);
            txtNombreCat.Name = "txtNombreCat";
            txtNombreCat.Size = new Size(150, 23);
            txtNombreCat.TabIndex = 4;
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(172, 12);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(98, 50);
            btnGuardar.TabIndex = 5;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // AgregarCategoria
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(307, 154);
            Controls.Add(btnGuardar);
            Controls.Add(txtNombreCat);
            Controls.Add(txtIdCat);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AgregarCategoria";
            Text = "AgregarCategoria";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private Label label1;
        private Label label2;
        private TextBox txtIdCat;
        private TextBox txtNombreCat;
        private Button btnGuardar;
    }
}