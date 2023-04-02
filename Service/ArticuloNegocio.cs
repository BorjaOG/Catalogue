using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Threading;
using Domain;
using Service;
using System.Data.SqlTypes;
using System.Xml.Schema;

namespace Catalogo
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conection = new SqlConnection();
            SqlCommand comand = new SqlCommand();
            SqlDataReader reader;

            try
            {
                // Query //
                conection.ConnectionString = "server=DESKTOP-6NCI6TM\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true";
                comand.CommandType = System.Data.CommandType.Text;
                comand.CommandText = "Select A.Id, Codigo, Nombre, A.Descripcion, M.Descripcion Marca, C.Descripcion Categoria, ImagenUrl, A.Precio, A.IdMarca, A.IdCategoria, M.Id, C.Id\r\nFrom ARTICULOS A, CATEGORIAS C, MARCAS M \r\nwhere C.Id = A.IdCategoria and M.id = A.IdMarca";
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
                    aux.Id = (int)reader["Id"];
                    aux.Precio = (decimal)reader["Precio"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)reader["IdMarca"];
                    aux.Marca.Descripcion = (string)reader["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)reader["IdCategoria"];
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
                string consulta = "insert into ARTICULOS (Id,Codigo, Nombre, Descripcion, ImagenUrl, Precio, IdMarca, IdCategoria)" +
                                  "values (@Codigo, @Nombre, @Descripcion, @UrlImagen, @Precio, @IdMarca, @IdCategoria)";

                data.setearConsulta(consulta);
                data.setearParametro("@Codigo", nuevo.Codigo);
                data.setearParametro("@Nombre", nuevo.Nombre);
                data.setearParametro("@Descripcion", nuevo.Descripcion);
                data.setearParametro("@UrlImagen", nuevo.UrlImagen);
                data.setearParametro("@Precio", nuevo.Precio);
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


        public void modificar(Articulo article)
        {
                DataAcces data = new DataAcces();
            try
            {
                data.setearConsulta("update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id");
                data.setearParametro("@Codigo", article.Codigo);
                data.setearParametro("@Nombre", article.Nombre);
                data.setearParametro("@Descripcion", article.Descripcion);
                data.setearParametro("@IdMarca", article.Marca.Id);
                data.setearParametro("@IdCategoria", article.Categoria.Id);
                data.setearParametro("@ImagenUrl", article.UrlImagen);
                data.setearParametro("@Precio", article.Precio);
                data.setearParametro("@Id", article.Id);

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


    }
}

