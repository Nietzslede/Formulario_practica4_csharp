using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Formulario_practica4
{
    public partial class Form1 : Form
    {
        private readonly string filePath = "registro.txt";

        public Form1()
        {
            InitializeComponent();

            // Obtener la ruta de la carpeta principal del proyecto
            string directoryPath = Directory.GetCurrentDirectory();
            // Subir un nivel para llegar a la carpeta principal
            directoryPath = Directory.GetParent(directoryPath).Parent.Parent.FullName;
            // Combinar la ruta con el nombre del archivo
            filePath = Path.Combine(directoryPath, "registro.txt");

            BtnGuardar.Click += new EventHandler(BtnGuardar_Click);
            BtnBorrar.Click += new EventHandler(BtnBorrar_Click);
            BtnFinalizar.Click += new EventHandler(BtnFinalizar_Click);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarFormulario())
            {
                GuardarDatos();
                MessageBox.Show("Datos guardados exitosamente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void BtnFinalizar_Click(object sender, EventArgs e)
        {
                GuardarDatos();
                MessageBox.Show("Registro finalizado. Los datos han sido guardados.", "Finalizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
        }

        private bool ValidarFormulario()
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) ||
                string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                string.IsNullOrWhiteSpace(TxtTelefono.Text) ||
                string.IsNullOrWhiteSpace(TxtEstatura.Text) ||
                string.IsNullOrWhiteSpace(TxtEdad.Text) ||
                (!RadioBMasculino.Checked && !RadioBFemenino.Checked))
            {
                MessageBox.Show("Por favor, complete todos los campos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void GuardarDatos()
        {
            try
            {
                string genero = RadioBMasculino.Checked ? "Masculino" : "Femenino";
                string datos = $"Nombre: {TxtNombre.Text}\r\n" +
                             $"Apellidos: {TxtApellido.Text}\r\n" +
                             $"Teléfono: {TxtTelefono.Text}\r\n" +
                             $"Estatura: {TxtEstatura.Text}\r\n" +
                             $"Edad: {TxtEdad.Text}\r\n" +
                             $"Género: {genero}\r\n" +
                             $"Fecha de registro: {DateTime.Now}\r\n" +
                             "----------------------------------------\r\n";

                File.AppendAllText(filePath, datos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarFormulario()
        {
            TxtNombre.Clear();
            TxtApellido.Clear();
            TxtTelefono.Clear();
            TxtEstatura.Clear();
            TxtEdad.Clear();
            RadioBMasculino.Checked = false;
            RadioBFemenino.Checked = false;
        }
    }
}
