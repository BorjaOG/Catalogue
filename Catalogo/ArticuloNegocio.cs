using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;

namespace Catalogo
{
     class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List < Articulo > lista = new List<Articulo>();
            SqlConnection conection = new SqlConnection();
            SqlCommand comand = new SqlCommand();
            SqlDataReader reader;

            try
            {

                conection.ConnectionString = "server=DESKTOP-6NCI6TM\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comand.CommandType = System.Data.CommandType.Text;
                comand.CommandText = "Select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, A.Precio, A.IdMarca, A.IdCategoria From ARTICULOS A, CATEGORIAS C, MARCAS M where C.Id = A.IdCategoria AND A.IdCategoria = M.Id";
                comand.Connection = conection;

                conection.Open();
                reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Codigo = (string)reader["Codigo"];
                    aux.Nombre = (string)reader["Nombre"];
                    aux.Descripcion = (string)reader["Descripcion"];
                    aux.UrlImagen = (string)reader["imagenUrl"];
                    aux.Precio = (decimal)reader["Precio"];
                    aux.Marca = new Marca();
                    aux.Marca.Descripcion = (string)reader["Marca"];                   
                    aux.Categoria = new Categoria();
                    aux.Categoria.Descripcion = (string)reader["Categoria"];
                    

                    lista.Add(aux);
                 
                }
                conection.Close();
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
    }
}
