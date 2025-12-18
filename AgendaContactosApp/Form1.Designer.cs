namespace AgendaContactosApp
{
    partial class FormAgenda
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
            this.IblNombre = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.IblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.MaskedTextBox();
            this.lblInstagram = new System.Windows.Forms.Label();
            this.txtInstagram = new System.Windows.Forms.MaskedTextBox();
            this.lblFacebook = new System.Windows.Forms.Label();
            this.txtFacebook = new System.Windows.Forms.MaskedTextBox();
            this.lblLinkedIn = new System.Windows.Forms.Label();
            this.txtLinkedIn = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvContactos = new System.Windows.Forms.DataGridView();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // IblNombre
            // 
            this.IblNombre.AutoSize = true;
            this.IblNombre.BackColor = System.Drawing.Color.Silver;
            this.IblNombre.Location = new System.Drawing.Point(20, 30);
            this.IblNombre.Name = "IblNombre";
            this.IblNombre.Size = new System.Drawing.Size(47, 13);
            this.IblNombre.TabIndex = 0;
            this.IblNombre.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 1;
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(110, 30);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(250, 20);
            this.textNombre.TabIndex = 2;
            this.textNombre.TextChanged += new System.EventHandler(this.textNombre_TextChanged);
            // 
            // IblTelefono
            // 
            this.IblTelefono.AutoSize = true;
            this.IblTelefono.Location = new System.Drawing.Point(20, 70);
            this.IblTelefono.Name = "IblTelefono";
            this.IblTelefono.Size = new System.Drawing.Size(49, 13);
            this.IblTelefono.TabIndex = 3;
            this.IblTelefono.Text = "Teléfono";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(110, 70);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(250, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(20, 110);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 5;
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(110, 110);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(250, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // lblInstagram
            // 
            this.lblInstagram.AutoSize = true;
            this.lblInstagram.Location = new System.Drawing.Point(20, 150);
            this.lblInstagram.Name = "lblInstagram";
            this.lblInstagram.Size = new System.Drawing.Size(56, 13);
            this.lblInstagram.TabIndex = 7;
            this.lblInstagram.Text = "Instagram:";
            // 
            // txtInstagram
            // 
            this.txtInstagram.Location = new System.Drawing.Point(110, 150);
            this.txtInstagram.Name = "txtInstagram";
            this.txtInstagram.Size = new System.Drawing.Size(250, 20);
            this.txtInstagram.TabIndex = 8;
            // 
            // lblFacebook
            // 
            this.lblFacebook.AllowDrop = true;
            this.lblFacebook.AutoSize = true;
            this.lblFacebook.Location = new System.Drawing.Point(20, 190);
            this.lblFacebook.Name = "lblFacebook";
            this.lblFacebook.Size = new System.Drawing.Size(58, 13);
            this.lblFacebook.TabIndex = 9;
            this.lblFacebook.Text = "Facebook:";
            // 
            // txtFacebook
            // 
            this.txtFacebook.Location = new System.Drawing.Point(110, 190);
            this.txtFacebook.Name = "txtFacebook";
            this.txtFacebook.Size = new System.Drawing.Size(250, 20);
            this.txtFacebook.TabIndex = 10;
            // 
            // lblLinkedIn
            // 
            this.lblLinkedIn.AutoSize = true;
            this.lblLinkedIn.Location = new System.Drawing.Point(20, 230);
            this.lblLinkedIn.Name = "lblLinkedIn";
            this.lblLinkedIn.Size = new System.Drawing.Size(51, 13);
            this.lblLinkedIn.TabIndex = 11;
            this.lblLinkedIn.Text = "LinkedIn:";
            // 
            // txtLinkedIn
            // 
            this.txtLinkedIn.Location = new System.Drawing.Point(110, 230);
            this.txtLinkedIn.Name = "txtLinkedIn";
            this.txtLinkedIn.Size = new System.Drawing.Size(250, 20);
            this.txtLinkedIn.TabIndex = 12;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGuardar.Location = new System.Drawing.Point(20, 280);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnListar
            // 
            this.btnListar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnListar.Location = new System.Drawing.Point(140, 280);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(100, 35);
            this.btnListar.TabIndex = 14;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = false;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.Location = new System.Drawing.Point(250, 270);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(100, 35);
            this.btnBuscar.TabIndex = 15;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dgvContactos
            // 
            this.dgvContactos.AllowUserToAddRows = false;
            this.dgvContactos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContactos.Location = new System.Drawing.Point(380, 12);
            this.dgvContactos.Name = "dgvContactos";
            this.dgvContactos.ReadOnly = true;
            this.dgvContactos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvContactos.Size = new System.Drawing.Size(734, 400);
            this.dgvContactos.TabIndex = 16;
            // 
            // grpDatos
            // 
            this.grpDatos.BackColor = System.Drawing.Color.AliceBlue;
            this.grpDatos.Controls.Add(this.btnBuscar);
            this.grpDatos.Location = new System.Drawing.Point(10, 10);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(360, 402);
            this.grpDatos.TabIndex = 17;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Datos del Contacto";
            // 
            // FormAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(1126, 511);
            this.Controls.Add(this.dgvContactos);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtLinkedIn);
            this.Controls.Add(this.lblLinkedIn);
            this.Controls.Add(this.txtFacebook);
            this.Controls.Add(this.lblFacebook);
            this.Controls.Add(this.txtInstagram);
            this.Controls.Add(this.lblInstagram);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.IblTelefono);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IblNombre);
            this.Controls.Add(this.grpDatos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormAgenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agenda de conctactos";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContactos)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IblNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label IblTelefono;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.MaskedTextBox txtDireccion;
        private System.Windows.Forms.Label lblInstagram;
        private System.Windows.Forms.MaskedTextBox txtInstagram;
        private System.Windows.Forms.Label lblFacebook;
        private System.Windows.Forms.MaskedTextBox txtFacebook;
        private System.Windows.Forms.Label lblLinkedIn;
        private System.Windows.Forms.MaskedTextBox txtLinkedIn;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dgvContactos;
        private System.Windows.Forms.GroupBox grpDatos;
    }
}

