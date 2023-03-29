using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
using Domain;
using Service;

namespace Catalogo
{
     public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List < Articulo > lista = new List<Articulo>();
            SqlConnection conection = new SqlConnection();
            SqlCommand comand = new SqlCommand();
            SqlDataReader reader;

            try
            {
                // Query //
                conection.ConnectionString = "server=DESKTOP-6NCI6TM\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comand.CommandType = System.Data.CommandType.Text;
                comand.CommandText = "Select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, A.Precio, A.IdMarca, A.IdCategoria\r\nFrom ARTICULOS A, CATEGORIAS C, MARCAS M \r\nwhere C.Id = A.IdCategoria and M.id = A.IdMarca";
                comand.Connection = conection;

                conection.Open();
                reader = comand.ExecuteReader();

                while (reader.Read())
                {
                    Articulo aux = new Articulo();
                    if (!(reader["Codigo"] is DBNull))
                        aux.Codigo = (string)reader["Codigo"];
                    if (!(reader["Nombre"] is DBNull))
                        aux.Nombre = (string)reader["Nombre"];                    
                    if (!(reader["Descripcion"] is DBNull))
                        aux.Descripcion = (string)reader["Descripcion"];
                    if (!(reader["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)reader["ImagenUrl"];
                  //  if (!(reader.IsDBNull(reader.GetOrdinal("Precio"))))//
                    //    aux.Precio = (decimal)reader["Precio"];//


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
        //ADD//
        public void agregar(Articulo nuevo)
        {
            DataAcces data = new DataAcces();

            try
            {
                data.setearConsulta("insert into ARTICULOS (Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdMarca, IdCategoria) values ('"+ nuevo.Codigo +"','" + nuevo.Nombre + "','" + nuevo.Descripcion + "', '" + nuevo.Precio + "','" + nuevo.UrlImagen +"', @IdMarca, @IdCategoria)");             
                data.setearParametro("@IdMarca", nuevo.Marca.Id);
                data.setearParametro("@IdCategoria", nuevo.Categoria.Id);
                data.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                data.cerrarConection();
            }
        }

        public void modificar (Articulo modificar)
        {

        }
       
        
    }
}
