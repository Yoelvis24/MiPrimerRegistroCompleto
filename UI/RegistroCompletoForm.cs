using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PrimerRegistroCompleto.DAL;
using PrimerRegistroCompleto.Entidades;
using PrimerRegistroCompleto.BLL;

namespace PrimerRegistroCompleto
{
    public partial class RegistroCompletoForm : Form
    {
        public RegistroCompletoForm()
        {
            InitializeComponent();
        }


        private bool Validar()
        {
            bool paso = true;
            errorProvider1.Clear();

            if (Convert.ToInt32(idTextBox.Text) == 0)
            {
                errorProvider1.SetError(idTextBox, "Campo obligatorio");
                paso = false;
            }

            if (nombresTextBox.Text == "")
            {
                errorProvider1.SetError(nombresTextBox, "Campo obligatorio");
                paso = false;
            }

            if (claveTextBox.Text == "")
            {
                errorProvider1.SetError(claveTextBox, "Campo obligatorio");
                paso = false;
            }

            if (confirmarTextBox.Text == "")
            {
                errorProvider1.SetError(confirmarTextBox, "Campo obligatorio");
                paso = false;
            }

            if (emailTextBox.Text == "")
            {
                errorProvider1.SetError(emailTextBox, "Campo obligatorio");
                paso = false;
            }

            if (rolComboBox.Text == "")
            {
                errorProvider1.SetError(rolComboBox, "Campo obligatorio");
                paso = false;
            }

            if (confirmarTextBox.Text != claveTextBox.Text && confirmarTextBox.Text != "")
            {
                errorProvider1.SetError(confirmarTextBox, "Claves no coinciden");
                paso = false;
            }

            if (Convert.ToSingle(costoTextBox.Text) == 0)
            {
                errorProvider1.SetError(costoTextBox, "Campo obligatorio");
                paso = false;
            }
            return paso;
        }

        private void LlenarCampos(Usuarios usuarios)
        {
            idTextBox.Text = Convert.ToString(usuarios.UsuarioId);
            nombresTextBox.Text = usuarios.Nombres;
            aliasTextBox.Text = usuarios.Alias;
            emailTextBox.Text = usuarios.Email;
            costoTextBox.Text = Convert.ToString(usuarios.Costo);
            claveTextBox.Text = usuarios.Clave;
            activoCheckBox.Checked = usuarios.Activo;
            rolComboBox.Text = usuarios.Rol;
        }

        private Usuarios LlenarClase()
        {
            Usuarios usuarios = new Usuarios();

            usuarios.UsuarioId = Convert.ToInt32(idTextBox.Text);
            usuarios.Alias = aliasTextBox.Text;
            usuarios.Email = emailTextBox.Text;
            usuarios.Clave = claveTextBox.Text;
            usuarios.Costo = Convert.ToSingle(costoTextBox.Text);
            usuarios.Activo = activoCheckBox.Checked;
            usuarios.Nombres = nombresTextBox.Text;
            usuarios.Rol = rolComboBox.Text;

            return usuarios;
        }


        public void Limpiar()
        {
            idTextBox.Text = string.Empty;
            aliasTextBox.Text = string.Empty;
            emailTextBox.Text = string.Empty;
            claveTextBox.Text = string.Empty;
            nombresTextBox.Text = string.Empty;
            confirmarTextBox.Text = string.Empty;
            rolComboBox.Text = string.Empty;
            costoTextBox.Text = string.Empty;
            activoCheckBox.Checked = false;
            errorProvider1.Clear();
        }

        private bool ExisteEnLaBaseDeDatos()
        {
            Usuarios usuarios = UsuariosBLL.Buscar(Convert.ToInt32(idTextBox.Text));
            return (usuarios != null);
        }


        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Usuarios usuarios;
            bool paso = false;

            if (!Validar())
                return;

            usuarios = LlenarClase();

            //determinar si es guardar o modificar
            if (Convert.ToInt32(idTextBox.Text) != 0)
                paso = UsuariosBLL.Guardar(usuarios);
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar un usuario que no existe");
                    return;
                }
                paso = UsuariosBLL.Modificar(usuarios);
            }

            //Informar el resultado
            if (paso)
            {
                Limpiar();
                MessageBox.Show("Se ha guardado correctamente");
            }
            else
                MessageBox.Show("No fue posible guardar");
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            int id;
            int.TryParse(idTextBox.Text, out id);

            Limpiar();

            if (UsuariosBLL.Eliminar(id))
                MessageBox.Show("Usuario eliminado");
            else
                errorProvider1.SetError(idTextBox, "Este usuario no existe");

        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            
        }

        private void idRollabel_Click(object sender, EventArgs e)
        {

        }

        private void descripcionlabel_Click(object sender, EventArgs e)
        {

        }

        private void NuevoButton_Click(object sender, EventArgs e)
        {

        }

        private void BuscarButton_Click(object sender, EventArgs e)
        {

        }
    }
}
