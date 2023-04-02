using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Domain;
using Catalogo;
using Service;
using static System.Net.Mime.MediaTypeNames;

namespace Catalogo
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo article = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
        }
        public frmAltaArticulo(Articulo article)
        {
            InitializeComponent();
            this.article = article;
            Text = "Modify Article";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {            
           Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {          
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (article == null)
                {
                    article = new Articulo();
                }
                article.Codigo = (string)txtCodigo.Text;
                article.Nombre = (string)txtNombre.Text;
                article.Descripcion = (string)txtDescripcion.Text;
                article.UrlImagen = (string)txtUrl.Text;
                article.Precio = decimal.Parse(txtPrice.Text);
                article.Marca = (Marca)cmbMarca.SelectedItem;
                article.Categoria = (Categoria)cmbCategoria.SelectedItem;

                if(article.Id != 0)
                {
                negocio.modificar(article);
                MessageBox.Show("Modification succesfull");
                }               
                else
                {
                    negocio.agregar(article);
                    MessageBox.Show("Succefully added");
                }               
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cmbMarca.DataSource = marcaNegocio.listar();
                cmbMarca.ValueMember = "Id";
                cmbMarca.DisplayMember = "Descripcion";
                cmbCategoria.DataSource = categoriaNegocio.listar();
                cmbCategoria.ValueMember = "Id";
                cmbCategoria.DisplayMember = "Descripcion";

                if (article != null)
                {
                    txtCodigo.Text = article.Codigo;
                    txtNombre.Text = article.Nombre;
                    txtDescripcion.Text = article.Descripcion;
                    txtPrice.Text = article.Precio.ToString();
                    txtUrl.Text = article.UrlImagen;
                    loadImage(article.UrlImagen);
                    cmbCategoria.SelectedValue = article.Categoria.Id;
                    cmbMarca.SelectedValue = article.Marca.Id;                   
                }
            }
            catch (Exception ex)
            {
               MessageBox.Show(ex.ToString());
            }
        }
        private void txtUrl_Leave(object sender, EventArgs e)
        {
            loadImage(txtUrl.Text);
        }
        private void loadImage(string image)
        {
            try
            {
                pcbArticulo.Load(image);
            }
            catch (Exception ex)
            {
                pcbArticulo.Load("https://worldwellnessgroup.org.au/wp-content/uploads/2020/07/placeholder.png");
            }

        }
    }
}
