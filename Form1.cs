using primerfromulario.Dato;
using primerfromulario.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primerfromulario
{
    public partial class Form1 : Form
    {
        DataTable tabla;
        Usuario dato = new Usuario();
        ErrorProvider errorProvider = new ErrorProvider();
        public Form1()
        {
            InitializeComponent();
            Iniciar();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (validaciones()) 
            { 
            Guardar();
            Iniciar();
            Limpiar();
            Consultar(); 
            }
        }

        private void BtnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private bool validaciones()
        {
            bool camposvalidate = true;
            errorProvider.Clear();

            if (string.IsNullOrWhiteSpace(TextNombre.Text))
            {
                errorProvider.SetError(TextNombre, "El nombre es oblidatorio");
                camposvalidate = false;

            }

            if (!int.TryParse(TextEdad.Text,out _))
            {
                errorProvider.SetError(TextEdad, "la edad es obligatorio");
                camposvalidate = false;
            }

            string sexo = TextSexo.Text.ToLower();

            if (sexo!="hombre" && sexo!= "mujer")
            {
                errorProvider.SetError(TextSexo, " Solo se permite Hombre o Mujer");
                camposvalidate = false;
            }

            return camposvalidate;
        }
        private void Iniciar()
        {
            tabla = new DataTable();
            tabla.Columns.Add("Nombre");
            tabla.Columns.Add("Edad");
            tabla.Columns.Add("Sexo");
            grilla.DataSource = tabla;

        }

        private void Guardar() {
            UsuarioModels modelo = new UsuarioModels() {
                Nombre = TextNombre.Text,
                Edad = int.Parse(TextEdad.Text),
                Sexo = TextSexo.Text



            };
            dato.Guardar(modelo);   
        }

        private void Consultar() { 
            foreach(var item in dato.Consultar())
            {
                DataRow fila = tabla.NewRow();
                fila["Nombre"] = item.Nombre;
                fila["Edad"] = item.Edad;
                fila["Sexo"] = item.Sexo;
                tabla.Rows.Add(fila);
            }
        }

        private void Limpiar()
        {
            TextNombre.Text = "";
            TextEdad.Text = "";
            TextSexo.Text = "";
        }

        private void TextSexo_TextChanged(object sender, EventArgs e)
        {

        }

        private void TitleEdad_Click(object sender, EventArgs e)
        {

        }
    }
}
