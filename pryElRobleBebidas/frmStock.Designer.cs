namespace pryElRobleBebidas
{
    partial class frmStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStock));
            this.lblNombre = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbTipoBebidas = new System.Windows.Forms.ComboBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.lblTamaño = new System.Windows.Forms.Label();
            this.lblEnvase = new System.Windows.Forms.Label();
            this.cmbTamaño = new System.Windows.Forms.ComboBox();
            this.cmbEnvase = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbProveedores = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.Label();
            this.txtPrecioUnidad = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 87);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(59, 16);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 43);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipo de Bebidas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 245);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 16);
            this.label5.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 261);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 16);
            this.label7.TabIndex = 6;
            // 
            // cmbTipoBebidas
            // 
            this.cmbTipoBebidas.FormattingEnabled = true;
            this.cmbTipoBebidas.Items.AddRange(new object[] {
            "1 ",
            "Bebidas blancas",
            "2 ",
            "Cervezas",
            "3 ",
            "Gaseosas",
            "4 ",
            "Champagnes ",
            "5",
            "Vinos",
            "6",
            "Aperitivos"});
            this.cmbTipoBebidas.Location = new System.Drawing.Point(322, 43);
            this.cmbTipoBebidas.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoBebidas.Name = "cmbTipoBebidas";
            this.cmbTipoBebidas.Size = new System.Drawing.Size(160, 24);
            this.cmbTipoBebidas.TabIndex = 7;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(322, 84);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 22);
            this.txtNombre.TabIndex = 10;
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.SeaShell;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Font = new System.Drawing.Font("Arial Narrow", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Location = new System.Drawing.Point(179, 369);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(161, 28);
            this.btnCargar.TabIndex = 14;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(322, 125);
            this.txtMarca.Margin = new System.Windows.Forms.Padding(4);
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(160, 22);
            this.txtMarca.TabIndex = 17;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(13, 128);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(48, 16);
            this.lblMarca.TabIndex = 16;
            this.lblMarca.Text = "Marca:";
            // 
            // lblTamaño
            // 
            this.lblTamaño.AutoSize = true;
            this.lblTamaño.Location = new System.Drawing.Point(13, 166);
            this.lblTamaño.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTamaño.Name = "lblTamaño";
            this.lblTamaño.Size = new System.Drawing.Size(61, 16);
            this.lblTamaño.TabIndex = 18;
            this.lblTamaño.Text = "Tamaño:";
            // 
            // lblEnvase
            // 
            this.lblEnvase.AutoSize = true;
            this.lblEnvase.Location = new System.Drawing.Point(13, 204);
            this.lblEnvase.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEnvase.Name = "lblEnvase";
            this.lblEnvase.Size = new System.Drawing.Size(56, 16);
            this.lblEnvase.TabIndex = 20;
            this.lblEnvase.Text = "Envase:";
            // 
            // cmbTamaño
            // 
            this.cmbTamaño.FormattingEnabled = true;
            this.cmbTamaño.Items.AddRange(new object[] {
            "1",
            "*50 mlts",
            "2",
            "*100 mlts",
            "3",
            "*200 mlts",
            "4",
            "*250 mlts",
            "5",
            "*330 mlts",
            "6",
            "*350 mlts",
            "7",
            "*440 mlts",
            "8",
            "*500 mlts",
            "9",
            "*700 mlts",
            "10",
            "*750 mlts",
            "11",
            "*1000 mlts",
            "12",
            "*1250 mlts",
            "13",
            "*1500 mlts",
            "14",
            "*2000 mlts",
            "15",
            "*2500 mlts",
            "16",
            "*3000 mlts",
            "17",
            "*5000 mlts"});
            this.cmbTamaño.Location = new System.Drawing.Point(322, 163);
            this.cmbTamaño.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTamaño.Name = "cmbTamaño";
            this.cmbTamaño.Size = new System.Drawing.Size(160, 24);
            this.cmbTamaño.TabIndex = 23;
            // 
            // cmbEnvase
            // 
            this.cmbEnvase.FormattingEnabled = true;
            this.cmbEnvase.Items.AddRange(new object[] {
            "1",
            "Botella de vidrio",
            "2",
            "Botella plástica",
            "3",
            "Tetrabrick o cartón",
            "4",
            "Damajuana",
            "5",
            "Petaca",
            "6",
            "Sachet",
            "7",
            "Lata",
            "8",
            "Barril",
            "9",
            "Pouche o sobre"});
            this.cmbEnvase.Location = new System.Drawing.Point(322, 201);
            this.cmbEnvase.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEnvase.Name = "cmbEnvase";
            this.cmbEnvase.Size = new System.Drawing.Size(160, 24);
            this.cmbEnvase.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 242);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Cantidad:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(322, 239);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(160, 22);
            this.txtCantidad.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 288);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 16);
            this.label2.TabIndex = 27;
            this.label2.Text = "Proveedor:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbProveedores
            // 
            this.cmbProveedores.FormattingEnabled = true;
            this.cmbProveedores.Items.AddRange(new object[] {
            "8",
            "Cuestión de Gustos",
            "9",
            "Mosto Bebidas",
            "10",
            "Rural",
            "11",
            "Piatelli",
            "18",
            "Silvestre",
            "19",
            "Luigi",
            "20",
            "Bosca",
            "21",
            "Sotano",
            "22",
            "Nieto Sentiner",
            "23",
            "CCU(Heineken)"});
            this.cmbProveedores.Location = new System.Drawing.Point(322, 285);
            this.cmbProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.cmbProveedores.Name = "cmbProveedores";
            this.cmbProveedores.Size = new System.Drawing.Size(160, 24);
            this.cmbProveedores.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(12, 9);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(319, 19);
            this.label9.TabIndex = 44;
            this.label9.Text = "Seleccione el NÚMERO que desee cargar.";
            // 
            // txtPrecio
            // 
            this.txtPrecio.AutoSize = true;
            this.txtPrecio.Location = new System.Drawing.Point(13, 333);
            this.txtPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(116, 16);
            this.txtPrecio.TabIndex = 45;
            this.txtPrecio.Text = "Precio por unidad:";
            this.txtPrecio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPrecioUnidad
            // 
            this.txtPrecioUnidad.Location = new System.Drawing.Point(322, 330);
            this.txtPrecioUnidad.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrecioUnidad.Name = "txtPrecioUnidad";
            this.txtPrecioUnidad.Size = new System.Drawing.Size(160, 22);
            this.txtPrecioUnidad.TabIndex = 46;
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.BurlyWood;
            this.ClientSize = new System.Drawing.Size(504, 410);
            this.Controls.Add(this.txtPrecioUnidad);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.cmbProveedores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbEnvase);
            this.Controls.Add(this.cmbTamaño);
            this.Controls.Add(this.lblEnvase);
            this.Controls.Add(this.lblTamaño);
            this.Controls.Add(this.txtMarca);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.cmbTipoBebidas);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmStock";
            this.Text = "Carga de Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbTipoBebidas;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Label lblTamaño;
        private System.Windows.Forms.Label lblEnvase;
        private System.Windows.Forms.ComboBox cmbTamaño;
        private System.Windows.Forms.ComboBox cmbEnvase;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbProveedores;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtPrecio;
        private System.Windows.Forms.TextBox txtPrecioUnidad;
    }
}