using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.IO;
using Domain;




namespace Catalogo
{
    public partial class frmCatalogo : Form
    {
        private List<Articulo> listaArticulos;
        public frmCatalogo()
        {
            InitializeComponent();
        }
        private void frmCatalogo_Load(object sender, EventArgs e)
        {
            cargar();        
        }
        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulo selected = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                loadImage(selected.UrlImagen);
            }
        }
        private void cargar()
        {
                ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["UrlImagen"].Visible = false;
                dgvArticulos.Columns["Id"].Visible = false;
                loadImage(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
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
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }
        private void btnModify_Click(object sender, EventArgs e)
        {   
            {
                if (dgvArticulos.CurrentRow != null)
                {
                  Articulo selected;
                  selected = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                  frmAltaArticulo modify = new frmAltaArticulo(selected);
                  modify.ShowDialog();
                  cargar();
                    
                }
            }
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
