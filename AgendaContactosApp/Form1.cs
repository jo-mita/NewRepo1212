using Ejemplo2.Datos;
using Ejemplo2.Modelos;
using System;
using System.Windows.Forms;

namespace AgendaContactosApp
{
    public partial class FormAgenda : Form
    {
        public FormAgenda()
        {
            InitializeComponent();
        }

        // ==========================
        // EVENTO LOAD (COINCIDE CON EL DESIGNER)
        // ==========================
        private void Form1_Load(object sender, EventArgs e)
        {
            CargarContactos();
        }

        // ==========================
        // EVENTO TextChanged (COINCIDE CON EL DESIGNER)
        // ==========================
        private void textNombre_TextChanged(object sender, EventArgs e)
        {
            // Se deja vacío
        }

        // ==========================
        // BOTÓN GUARDAR
        // ==========================
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Contacto contacto = new Contacto
            {
                Nombre = textNombre.Text,
                Telefono = txtTelefono.Text,
                Direccion = txtDireccion.Text,
                Instagram = txtInstagram.Text,
                Facebook = txtFacebook.Text,
                LinkedIn = txtLinkedIn.Text
            };

            ContactoDatos datos = new ContactoDatos();
            datos.Guardar(contacto);

            MessageBox.Show("Contacto guardado correctamente");

            Limpiar();
            CargarContactos();
        }

        // ==========================
        // BOTÓN LISTAR
        // ==========================
        private void btnListar_Click(object sender, EventArgs e)
        {
            CargarContactos();
        }

        // ==========================
        // BOTÓN BUSCAR (SIN TEXTBOX AÚN)
        // ==========================
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Agrega un TextBox para buscar contactos");
        }

        // ==========================
        // MÉTODOS AUXILIARES
        // ==========================
        private void CargarContactos()
        {
            ContactoDatos datos = new ContactoDatos();
            dgvContactos.DataSource = datos.Listar();
        }

        private void Limpiar()
        {
            textNombre.Clear();
            txtTelefono.Clear();
            txtDireccion.Clear();
            txtInstagram.Clear();
            txtFacebook.Clear();
            txtLinkedIn.Clear();
            textNombre.Focus();
        }
    }
}
