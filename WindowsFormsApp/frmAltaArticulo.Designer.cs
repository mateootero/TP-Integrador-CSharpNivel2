namespace WindowsFormsApp
{
    partial class frmAltaArticulo
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
            this.lblCodArt = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDescrip = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblCateg = new System.Windows.Forms.Label();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.comboBoxCateg = new System.Windows.Forms.ComboBox();
            this.comboBoxMarca = new System.Windows.Forms.ComboBox();
            this.txtBoxCodArt = new System.Windows.Forms.TextBox();
            this.txtBoxPrecio = new System.Windows.Forms.TextBox();
            this.txtBoxDescrip = new System.Windows.Forms.TextBox();
            this.txtBoxNombre = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtBoxUrlImag = new System.Windows.Forms.TextBox();
            this.lblUrlImag = new System.Windows.Forms.Label();
            this.pictureBoxAgregar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregar)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCodArt
            // 
            this.lblCodArt.AutoSize = true;
            this.lblCodArt.Location = new System.Drawing.Point(45, 16);
            this.lblCodArt.Name = "lblCodArt";
            this.lblCodArt.Size = new System.Drawing.Size(83, 13);
            this.lblCodArt.TabIndex = 0;
            this.lblCodArt.Text = "Código Artículo:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(45, 42);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDescrip
            // 
            this.lblDescrip.AutoSize = true;
            this.lblDescrip.Location = new System.Drawing.Point(45, 68);
            this.lblDescrip.Name = "lblDescrip";
            this.lblDescrip.Size = new System.Drawing.Size(66, 13);
            this.lblDescrip.TabIndex = 2;
            this.lblDescrip.Text = "Descripción:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(45, 94);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(40, 13);
            this.lblMarca.TabIndex = 3;
            this.lblMarca.Text = "Marca:";
            // 
            // lblCateg
            // 
            this.lblCateg.AutoSize = true;
            this.lblCateg.Location = new System.Drawing.Point(45, 120);
            this.lblCateg.Name = "lblCateg";
            this.lblCateg.Size = new System.Drawing.Size(55, 13);
            this.lblCateg.TabIndex = 4;
            this.lblCateg.Text = "Categoria:";
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(45, 147);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(40, 13);
            this.lblPrecio.TabIndex = 5;
            this.lblPrecio.Text = "Precio:";
            // 
            // comboBoxCateg
            // 
            this.comboBoxCateg.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCateg.FormattingEnabled = true;
            this.comboBoxCateg.Location = new System.Drawing.Point(134, 117);
            this.comboBoxCateg.Name = "comboBoxCateg";
            this.comboBoxCateg.Size = new System.Drawing.Size(100, 21);
            this.comboBoxCateg.TabIndex = 4;
            // 
            // comboBoxMarca
            // 
            this.comboBoxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxMarca.FormattingEnabled = true;
            this.comboBoxMarca.Location = new System.Drawing.Point(134, 91);
            this.comboBoxMarca.Name = "comboBoxMarca";
            this.comboBoxMarca.Size = new System.Drawing.Size(100, 21);
            this.comboBoxMarca.TabIndex = 3;
            // 
            // txtBoxCodArt
            // 
            this.txtBoxCodArt.Location = new System.Drawing.Point(134, 13);
            this.txtBoxCodArt.Name = "txtBoxCodArt";
            this.txtBoxCodArt.Size = new System.Drawing.Size(100, 20);
            this.txtBoxCodArt.TabIndex = 0;
            // 
            // txtBoxPrecio
            // 
            this.txtBoxPrecio.Location = new System.Drawing.Point(134, 144);
            this.txtBoxPrecio.Name = "txtBoxPrecio";
            this.txtBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtBoxPrecio.TabIndex = 5;
            // 
            // txtBoxDescrip
            // 
            this.txtBoxDescrip.Location = new System.Drawing.Point(134, 65);
            this.txtBoxDescrip.Name = "txtBoxDescrip";
            this.txtBoxDescrip.Size = new System.Drawing.Size(100, 20);
            this.txtBoxDescrip.TabIndex = 2;
            // 
            // txtBoxNombre
            // 
            this.txtBoxNombre.Location = new System.Drawing.Point(134, 39);
            this.txtBoxNombre.Name = "txtBoxNombre";
            this.txtBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.txtBoxNombre.TabIndex = 1;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(78, 214);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(186, 214);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtBoxUrlImag
            // 
            this.txtBoxUrlImag.Location = new System.Drawing.Point(134, 170);
            this.txtBoxUrlImag.Name = "txtBoxUrlImag";
            this.txtBoxUrlImag.Size = new System.Drawing.Size(100, 20);
            this.txtBoxUrlImag.TabIndex = 6;
            this.txtBoxUrlImag.Leave += new System.EventHandler(this.txtBoxUrlImag_Leave);
            // 
            // lblUrlImag
            // 
            this.lblUrlImag.AutoSize = true;
            this.lblUrlImag.Location = new System.Drawing.Point(45, 173);
            this.lblUrlImag.Name = "lblUrlImag";
            this.lblUrlImag.Size = new System.Drawing.Size(61, 13);
            this.lblUrlImag.TabIndex = 15;
            this.lblUrlImag.Text = "Url Imagen:";
            // 
            // pictureBoxAgregar
            // 
            this.pictureBoxAgregar.Location = new System.Drawing.Point(258, 13);
            this.pictureBoxAgregar.Name = "pictureBoxAgregar";
            this.pictureBoxAgregar.Size = new System.Drawing.Size(198, 177);
            this.pictureBoxAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAgregar.TabIndex = 16;
            this.pictureBoxAgregar.TabStop = false;
            // 
            // frmAltaArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 249);
            this.Controls.Add(this.pictureBoxAgregar);
            this.Controls.Add(this.lblUrlImag);
            this.Controls.Add(this.txtBoxUrlImag);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtBoxNombre);
            this.Controls.Add(this.txtBoxDescrip);
            this.Controls.Add(this.txtBoxPrecio);
            this.Controls.Add(this.txtBoxCodArt);
            this.Controls.Add(this.comboBoxMarca);
            this.Controls.Add(this.comboBoxCateg);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.lblCateg);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblDescrip);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblCodArt);
            this.Name = "frmAltaArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Alta Articulo";
            this.Load += new System.EventHandler(this.frmAltaArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAgregar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCodArt;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDescrip;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblCateg;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.ComboBox comboBoxCateg;
        private System.Windows.Forms.ComboBox comboBoxMarca;
        private System.Windows.Forms.TextBox txtBoxCodArt;
        private System.Windows.Forms.TextBox txtBoxPrecio;
        private System.Windows.Forms.TextBox txtBoxDescrip;
        private System.Windows.Forms.TextBox txtBoxNombre;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBoxUrlImag;
        private System.Windows.Forms.Label lblUrlImag;
        private System.Windows.Forms.PictureBox pictureBoxAgregar;
    }
}