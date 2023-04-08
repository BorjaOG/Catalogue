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
            if(selected == null)
            {
                throw new ArgumentNullException(nameof(selected));
            }
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
                txtCodigo.ReadOnly = true;
                txtNombre.Text = selected.Nombre;
                txtNombre.ReadOnly = true;
                txtDescripcion.Text = selected.Descripcion;
                txtDescripcion.ReadOnly = true;
                txtMarca.Text = selected.Marca.ToString();
                txtMarca.ReadOnly = true;
                txtCategoria.Text = selected.Categoria.ToString();
                txtCategoria.ReadOnly = true;
                txtPrice.Text = selected.Precio.ToString();
                txtPrice.ReadOnly = true;

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
