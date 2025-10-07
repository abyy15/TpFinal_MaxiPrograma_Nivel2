using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominioo;

namespace Negocio
{
    public class MarcaNegocio
    {
        AccesoDatos datos = new AccesoDatos();
        public List<Marca> listarMarcas()
        {
            List<Marca> listaMarcas = new List<Marca>();
            try
            {
                datos.setQuery("Select Id, Descripcion from MARCAS");
                datos.ejecutarRead();
                while (datos.Lector.Read())
                {
                    Marca auxiliar = new Marca();
                    auxiliar.IdMarca = (int)datos.Lector["Id"];
                    auxiliar.Descripcion = (string)datos.Lector["Descripcion"];
                    listaMarcas.Add(auxiliar);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return listaMarcas;
        }

    }
}
