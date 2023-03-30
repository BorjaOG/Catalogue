﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
     public class Articulo
    {
        [DisplayName("Code")]
        public string Codigo { get; set; }
        [DisplayName("Name")]
        public string Nombre { get; set; }
        [DisplayName("Description")]
        public string Descripcion { get; set; }
        public string UrlImagen { get; set; }
        [DisplayName("Price")]
        public decimal Precio { get; set; }
        [DisplayName("Brand")]
        public Marca Marca { get; set; }
        [DisplayName("Category")]
        public Categoria Categoria { get; set; }
    }
}
