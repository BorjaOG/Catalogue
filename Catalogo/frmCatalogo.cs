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
            cmbCampo.Items.Add("Price");
            cmbCampo.Items.Add("Name");
            cmbCampo.Items.Add("Description");

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
                hidecolumns();
                loadImage(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void hidecolumns()
        {
                dgvArticulos.Columns["UrlImagen"].Visible = false;
                dgvArticulos.Columns["Id"].Visible = false;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            Articulo selected;
            try
            {
                DialogResult reply = MessageBox.Show("Do you want to remove this article?", "Deleting article", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (reply == DialogResult.Yes)
                {
                    selected = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.delete(selected.Id);
                    cargar();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            try
            {
                string campo = cmbCampo.SelectedItem.ToString();
                string criterio = cmbCriterio.SelectedItem.ToString();
                string avanzado = cmbAvanzado.Text;
                dgvArticulos.DataSource = negocio.filtrar(campo, criterio, avanzado);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listafiltrada;
            string filter = txtFilter.Text;

            if (filter != "")
            {
                listafiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filter.ToUpper()));
            }
            else
            {
                listafiltrada = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listafiltrada;
            hidecolumns();
        }

        //Quick Filter//
        private void cmbCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            string option = cmbCampo.SelectedItem.ToString();
            if(option == "Price")
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Higher of");
                cmbCriterio.Items.Add("Lower of");
                cmbCriterio.Items.Add("Equal of");
            }
            else
            {
                cmbCriterio.Items.Clear();
                cmbCriterio.Items.Add("Start with");
                cmbCriterio.Items.Add("End with");
                cmbCriterio.Items.Add("Contains");
            }
        }
    }
}
