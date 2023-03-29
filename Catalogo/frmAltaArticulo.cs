﻿using System;
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
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo article = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                article.Codigo = (string)txtCodigo.Text;
                article.Nombre = (string)txtNombre.Text;
                article.Descripcion = (string)txtDescripcion.Text;
                article.UrlImagen = (string)txtUrl.Text;
                article.Precio = decimal.Parse(txtPrice.Text);
                article.Marca = (Marca)cmbMarca.SelectedItem;
                article.Categoria = (Categoria)cmbCategoria.SelectedItem;

                negocio.agregar(article);
                MessageBox.Show("Succefully added");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            try
            {
                cmbCategoria.DataSource = categoriaNegocio.listar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            MarcaNegocio marcaNegocio = new MarcaNegocio();
            try
            {
                cmbMarca.DataSource = marcaNegocio.listar();
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
