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
            List<Categorias> listaCategorias = new List<dominioo.Categorias>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("Select Id, Descripcion from CATEGORIAS");
                datos.ejecutarRead();
                while (datos.Lector.Read())
                {
                    Categorias auxiliar = new Categorias();
                    auxiliar.IdCategoria = (int)datos.Lector["Id"];
                    auxiliar.Descripcion = (string)datos.Lector["Descripcion"];
                    listaCategorias.Add(auxiliar);
                }
                return listaCategorias;
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
