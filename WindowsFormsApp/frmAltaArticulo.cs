using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace WindowsFormsApp
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        public frmAltaArticulo (Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                articulo.Codigo = txtBoxCodArt.Text;
                articulo.Nombre = txtBoxNombre.Text;
                articulo.Descripcion = txtBoxDescrip.Text;
                articulo.DescripcionMarca = (Marca)comboBoxMarca.SelectedItem;
                articulo.DescripcionCategoria = (Categoria)comboBoxCateg.SelectedItem;
                articulo.Precio = int.Parse(txtBoxPrecio.Text);
                articulo.UrlImagen = txtBoxUrlImag.Text;

                if (articulo.Id != 0)
                {
                    negocio.agregar(articulo);
                    MessageBox.Show("Modificado exitosamente");
                }

                else
                {
                    negocio.modificar(articulo);
                    MessageBox.Show("Agragado exitosamente");

                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
            //CONFIGURO EL DESPLEGABLE DE MARCA y CATEGORIA
            // Propiedad DropDownList -> para q sea solo desplegable y no se pueda escribir
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                comboBoxMarca.DataSource = marcaNegocio.Listar();
                if (articulo != null)
                {
                    txtBoxCodArt.Text = articulo.Codigo;
                    txtBoxNombre.Text = articulo.Nombre;
                    txtBoxDescrip.Text = articulo.Descripcion;
                    txtBoxPrecio.Text = articulo.Precio.ToString();
                    txtBoxUrlImag.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                comboBoxCateg.DataSource = categoriaNegocio.Listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtBoxUrlImag_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtBoxUrlImag.Text);
        }
        private void cargarImagen(string imagen)
        // Carga la imagen al correspondiente seleccionado y si no puede muestra una imagen vacia
        {
            try
            {
                pictureBoxAgregar.Load(imagen);
            }
            catch (Exception)
            {
                pictureBoxAgregar.Load("https://upload.wikimedia.org/wikipedia/commons/thumb/6/65/No-Image-Placeholder.svg/1665px-No-Image-Placeholder.svg.png");
            }
        }
    }
}
