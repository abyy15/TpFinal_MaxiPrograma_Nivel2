using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominioo;

namespace Negocio
{
    public class CategoriaNegocio
    {
        public List<Categorias> listarCategorias()
        {
            List<Categorias> lista = new List<dominioo.Categorias>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("select Id, Descripcion from CATEGORIAS");
                datos.ejecutarLectura();
                while (datos.Lector.Read())
                {
                    dominioo.Categorias aux = new dominioo.Categorias();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.Lector.Close();
                datos.cerrarConexion();
            }
        }
    }
}
