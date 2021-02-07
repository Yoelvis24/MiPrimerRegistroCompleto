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

namespace PrimerRegistroCompleto
{
    public partial class RegistroCompletoForm : Form
    {
        public RegistroCompletoForm()
        {
            InitializeComponent();
        }

        public static bool Existe(int id, string descripcion)
        {
            Contexto contexto = new Contexto();
            bool encontrado = false;

            try
            {
                encontrado = contexto.Roles.Any(e => e.RolId == id || e.Descripcion == descripcion );
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return encontrado;
        }

        public static bool Eliminar(int id)
        {
            bool interruptor = false;
            Contexto contexto = new Contexto();

            try
            {
                //buscar la entidad que se desee eliminar
                var roles = contexto.Roles.Find(id);

                if (roles != null)
                {
                    contexto.Roles.Remove(roles);//Remover la entidad
                    interruptor = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return interruptor;
        }

        public static bool Modificar(Roles roles)
        {
            Contexto contexto = new Contexto();
            bool paso = false;

            try
            {
                //Marcar la entidad como modificada para que 
                //el contexto sepa como proceder
                contexto.Entry(roles).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                paso = contexto.SaveChanges() > 0;

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }

            return paso;
        }

        private void GuardarButton_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Roles roles = new Roles();

            if(idRolTextBox.Text == "" || descripcionTextBox.Text == "")
            { 
                MessageBox.Show("Los campos están vacíos, favor de llenarlos", "Error", MessageBoxButtons.OK);
                return;
            }

            if (!Existe(Convert.ToInt32(idRolTextBox.Text), descripcionTextBox.Text)) //si no existe se añade
            {
                roles.RolId = Convert.ToInt32(idRolTextBox.Text);
                roles.FechaCreacion = Convert.ToDateTime(fechaDateTimePicker.Value);
                roles.Descripcion = descripcionTextBox.Text;
                contexto.Roles.Add(roles);
                contexto.SaveChanges();

                dataGridView1.DataSource = contexto.Roles.ToList();
                contexto.Dispose();
                idRolTextBox.Text = "";
                descripcionTextBox.Text = "";
            }
            else
                MessageBox.Show("Este Rol ya existe");
        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
            if (idRolTextBox.Text == "" || descripcionTextBox.Text == "")
            {
                MessageBox.Show("Los campos están vacíos, favor de llenarlos", "Error", MessageBoxButtons.OK);
                return;
            }

            if (Existe(Convert.ToInt32(idRolTextBox.Text), descripcionTextBox.Text))
            {
                Contexto contexto = new Contexto();
                Eliminar(Convert.ToInt32(idRolTextBox.Text));
                dataGridView1.DataSource = contexto.Roles.ToList();

                idRolTextBox.Text = "";
                descripcionTextBox.Text = "";
            }
            else
                MessageBox.Show("No se puede eliminar un Rol que no existe", "Error", MessageBoxButtons.OK);
        }

        private void EditarButton_Click(object sender, EventArgs e)
        {
            Contexto contexto = new Contexto();
            Roles roles = new Roles();

            if (idRolTextBox.Text == "" || descripcionTextBox.Text == "")
            {
                MessageBox.Show("Los campos están vacíos, favor de llenarlos", "Error", MessageBoxButtons.OK);
                return;
            }

            if (Existe(Convert.ToInt32(idRolTextBox.Text), descripcionTextBox.Text))
            {
                roles.RolId = Convert.ToInt32(idRolTextBox.Text);
                roles.FechaCreacion = Convert.ToDateTime(fechaDateTimePicker.Value);
                roles.Descripcion = descripcionTextBox.Text;
                Modificar(roles);
                contexto.SaveChanges();
                dataGridView1.DataSource = contexto.Roles.ToList();
                contexto.Dispose();

                idRolTextBox.Text = "";
                descripcionTextBox.Text = "";
            }
            else
                MessageBox.Show("Este Rol no existe", "Error", MessageBoxButtons.OK);
        }
    }
}
