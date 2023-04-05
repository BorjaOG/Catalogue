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

namespace Catalogo
{
    public partial class frmDetail : Form
    {
        public frmDetail()
        {
            InitializeComponent();
        }
       
        public frmDetail(Articulo selected)
        {
            InitializeComponent();
            this.selected = selected;
            Text = "Article details";
        }
         public Articulo selected { get; }
      
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
        private void frmDetail_Load(object sender, EventArgs e)
        {
            

            try
            {
                loadImage(selected.UrlImagen);
                txtCodigo.Text = selected.Codigo;
                txtNombre.Text = selected.Nombre;
                txtDescripcion.Text = selected.Descripcion;
                txtMarca.Text = selected.Marca.ToString();
                txtCategoria.Text = selected.Categoria.ToString();
                txtPrice.Text = selected.Precio.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
