using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient; // Incluir el uso de la libreria SQL
using Dominio; // Permitimos que utilice del dominio

namespace Negocio
{
    public class ArticuloNegocio
        // Clase en la que voy a crear los metodos de acceso a BD
    {
        public List<Articulo> listar()
        {
            List<Articulo> lista = new List<Articulo>();
            SqlConnection conexion = new SqlConnection();
            SqlCommand comando = new SqlCommand();
            SqlDataReader lector;

            try
            {
                // Código de conexión y configuración del comando...
                conexion.ConnectionString = "server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true"; // donde me conecto: "server= ; database= ;integrated security=true";
                comando.CommandType = System.Data.CommandType.Text; // Selecciono el tipo del comando
                comando.CommandText = "Select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, IdMarca, M.Descripcion DescripcionMarca, IdCategoria, C.Descripcion DescripcionCategoria\r\nFrom ARTICULOS A, MARCAS M, CATEGORIAS C\r\nWHERE A.Id = M.Id AND A.Id = C.Id"; // Aca escribo la Consulta
                comando.Connection = conexion; //Ejecutar ese comando en esta conexion

                conexion.Open(); // Abro la conexion
                lector = comando.ExecuteReader(); //El lector devuelve el ExecuteReader

                while (lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)lector["Id"];
                    aux.Codigo = (string)lector["Codigo"];
                    aux.Nombre = (string)lector["Nombre"];
                    aux.Descripcion = (string)lector["Descripcion"];
                    aux.UrlImagen = (string)lector["ImagenUrl"];
                    aux.Precio = (decimal)lector["Precio"];
                    aux.IdMarca = (int)lector["IdMarca"];
                    aux.DescripcionMarca = new Marca()
                    {
                        IdMarca = (int)lector["IdMarca"],
                        DescripcionMarca = (string)lector["DescripcionMarca"]
                    };
                    aux.IdCategoria = (int)lector["IdCategoria"];
                    aux.DescripcionCategoria = new Categoria()
                    {
                        IdCategoria = (int)lector["IdCategoria"],
                        DescripcionCategoria = (string)lector["DescripcionCategoria"]
                    };

                    lista.Add(aux);
                }

                conexion.Close();
                return lista;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al intentar listar los artículos desde la base de datos.", ex);
            }
        }

        public void agregar (Articulo nuevo)
        //Aca construir la logica para que se conecte a la base de datos
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Insert into ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio, ImagenUrl)values('"+ nuevo.Codigo +"','"+ nuevo.Nombre +"','"+ nuevo.Descripcion +"',@IdMarca,@IdCategoria,'"+ nuevo.Precio +"','"+ nuevo.UrlImagen +"')");
                datos.setearParametro("@IdMarca", nuevo.IdMarca);
                datos.setearParametro("@IdCategoria", nuevo.IdCategoria);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

        }

        public void modificar (Articulo articulo) 
        {
            AccesoDatos datos =new AccesoDatos();

            try
            {
                datos.setearConsulta("update ARTICULOS set Codigo=@Codigo, Nombre=@Nombre, Descripcion=@Descripcion, IdMarca=@IdMarca, IdCategoria=@IdCategoria, ImagenUrl=@ImagenUrl, Precio=@Precio where Id=@Id");
                datos.setearParametro("@Codigo", articulo.Codigo);
                datos.setearParametro("@Nombre", articulo.Nombre);
                datos.setearParametro("@Descripcion", articulo.Descripcion);
                datos.setearParametro("@IdMarca", articulo.IdMarca);
                datos.setearParametro("@IdCategoria", articulo.IdCategoria);
                datos.setearParametro("@ImagenUrl", articulo.UrlImagen);
                datos.setearParametro("@Precio", articulo.Precio);
                datos.setearParametro("@Id", articulo.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            
        }

        public void eliminar(int id)
        {
            try
            {
                AccesoDatos datos = new AccesoDatos();
                datos.setearConsulta("delete from ARTICULOS where Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex) 
            { 
                throw ex;
            }
        }

        public List<Articulo> filtrar(string campo, string criterio, string filtro)
        {
            List<Articulo> lista = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                string consulta = "Select A.Id, Codigo, Nombre, A.Descripcion, ImagenUrl, Precio, IdMarca, M.Descripcion DescripcionMarca, IdCategoria, C.Descripcion DescripcionCategoria\r\nFrom ARTICULOS A, MARCAS M, CATEGORIAS C\r\nWHERE A.Id = M.Id AND A.Id = C.Id AND ";
                if (campo == "A.Id")
                {
                    switch (criterio)
                    {
                        case "Mayor a":
                            consulta += "A.Id > " + filtro;
                            break;
                        case "Menor a":
                            consulta += "A.Id < " + filtro;
                            break;
                        default:
                            consulta += "A.Id = " + filtro;
                            break;
                    }
                }
                else if (campo == "Nombre")
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "' ";
                            break;
                        default:
                            consulta += "Nombre like '%" + filtro + "%' ";
                            break;
                    }
                }
                else
                {
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "A.Descripcion like '" + filtro + "%' ";
                            break;
                        case "Termina con":
                            consulta += "A.Descripcion like '%" + filtro + "' ";
                            break;
                        default:
                            consulta += "A.Descripcion like '%" + filtro + "%' ";
                            break;
                    }
                }
                datos.setearConsulta(consulta);
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)datos.Lector["Precio"];
                    aux.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.DescripcionMarca = new Marca()
                    {
                        IdMarca = (int)datos.Lector["IdMarca"],
                        DescripcionMarca = (string)datos.Lector["DescripcionMarca"]
                    };
                    aux.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.DescripcionCategoria = new Categoria()
                    {
                        IdCategoria = (int)datos.Lector["IdCategoria"],
                        DescripcionCategoria = (string)datos.Lector["DescripcionCategoria"]
                    };
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }

}

