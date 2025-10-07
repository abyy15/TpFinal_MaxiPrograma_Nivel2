﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominioo;

namespace Negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listarArticulos()
        {
            List<Articulo> listaArticulos = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("select A.Id, A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, A.Precio, A.IdMarca, A.IdCategoria from ARTICULOS A, MARCAS M, CATEGORIAS C");
                datos.ejecutarRead();
                while (datos.Lector.Read())
                {
                    Articulo aux = new Articulo();
                    aux.IdArticulo = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["DescripcionMarca"]; //USA EL NOMBRE QUE LE DI EN LA BDD
                    aux.Categoria = new Categorias();
                    aux.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["DescripcionCategoria"];
                    //Leo si la imagen NO es nula
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];

                    aux.Precio = (decimal)datos.Lector["Precio"];

                    listaArticulos.Add(aux);
                }

                return listaArticulos;
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
        public void agregarArticulo(Articulo articuloAgregado)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setQuery("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio) VALUES " +
                    "('" + articuloAgregado.Codigo + "', '" +
                     articuloAgregado.Nombre + "', '" +
                     articuloAgregado.Descripcion + "', '" +
                     articuloAgregado.Marca.IdMarca + "', '" +
                     articuloAgregado.Categoria.IdCategoria + "', '" +
                     articuloAgregado.UrlImagen + "', '" +
                     articuloAgregado.Precio + "')");
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

        public void modificarArticulo(Articulo articuloModificado)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setQuery("UPDATE ARTICULOS SET Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @Url, Precio = @Precio WHERE Id = @Id");
                datos.setearParametro("Codigo", articuloModificado.Codigo);
                datos.setearParametro("Nombre", articuloModificado.Nombre);
                datos.setearParametro("Descripcion", articuloModificado.Descripcion);
                datos.setearParametro("IdMarca", articuloModificado.Marca.IdMarca);
                datos.setearParametro("IdCategoria", articuloModificado.Categoria.IdCategoria);
                datos.setearParametro("Url", articuloModificado.UrlImagen);
                datos.setearParametro("Precio", articuloModificado.Precio);
                datos.setearParametro("Id", articuloModificado.IdArticulo);
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

        public void eliminarArticulos(Articulo seleccionado)
        {
            AccesoDatos datos = new AccesoDatos();
            datos.setQuery("DELETE from ARTICULOS where Id= @Id");
            datos.setearParametro("@Id", seleccionado.IdArticulo);
            try
            {
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

        public List<Articulo> filtrarArticulos(string Campo, string Criterio, string Filtros)
        {
            List<Articulo> listaFiltrada = new List<Articulo>();
            AccesoDatos datos = new AccesoDatos();
            string query = "Select A.Id, A.Codigo, A.Nombre, A.Descripcion,C.Id AS IdCategoria, C.Descripcion AS DescripcionCategoria, M.Id AS IdMarca, M.Descripcion AS DescripcionMarca, A.ImagenUrl, A.Precio from ARTICULOS A, CATEGORIAS C, MARCAS M where A.IdCategoria = C.Id AND A.IdMarca = M.Id AND ";
            try
            {
                switch (Campo)
                {
                    case "Codigo":
                        {
                            switch (Criterio)
                            {
                                case "Comienza con":
                                    {
                                        query += "A.Codigo like '" + Filtros + "%'";
                                        break;
                                    }
                                case "Termina con":
                                    {
                                        query += "A.Codigo like '%" + Filtros + "'";
                                        break;
                                    }
                                default:
                                    {
                                        query += "A.Codigo like '%" + Filtros + "%'";
                                        break;
                                    }

                            }
                            break;
                        }
                    case "Nombre":
                        switch (Criterio)
                        {
                            case "Comienza con":
                                {
                                    query += "A.Nombre like '" + Filtros + "%'";
                                    break;
                                }
                            case "Termina con":
                                {
                                    query += "A.Nombre like '%" + Filtros + "'";
                                    break;
                                }
                            default:
                                {
                                    query += "A.Nombre like '%" + Filtros + "%'";
                                    break;
                                }

                        }
                        break;

                    case "Descripcion":
                        switch (Criterio)
                        {
                            case "Comienza con":
                                {
                                    query += "A.Descripcion like '" + Filtros + "%'";
                                    break;
                                }
                            case "Termina con":
                                {
                                    query += "A.Descripcion like '%" + Filtros + "'";
                                    break;
                                }
                            default:
                                {
                                    query += "A.Descripcion like '%" + Filtros + "%'";
                                    break;
                                }
                        }
                        break;

                    case "Marca":
                        switch (Criterio)
                        {
                            case "Comienza con":
                                {
                                    query += "M.Descripcion like '" + Filtros + "%'";
                                    break;
                                }
                            case "Termina con":
                                {
                                    query += "M.Descripcion like '%" + Filtros + "'";
                                    break;
                                }
                            default:
                                {
                                    query += "M.Descripcion like '%" + Filtros + "%'";
                                    break;
                                }
                        }
                        break;

                    case "Categoria":
                        switch (Criterio)
                        {
                            case "Comienza con":
                                {
                                    query += "C.Descripcion like '" + Filtros + "%'";
                                    break;
                                }
                            case "Termina con":
                                {
                                    query += "C.Descripcion like '%" + Filtros + "'";
                                    break;
                                }
                            default:
                                {
                                    query += "C.Descripcion like '%" + Filtros + "%'";
                                    break;
                                }
                        }
                        break;

                    case "Precio":
                        {
                            switch (Criterio)
                            {
                                case "Mayor a":
                                    {
                                        query += "A.Precio > " + Filtros;
                                        break;
                                    }
                                case "Menor a":
                                    {
                                        query += "A.Precio < " + Filtros;
                                        break;
                                    }
                                default:
                                    {
                                        query += "A.Precio = " + Filtros;
                                        break;
                                    }
                            }
                            break;
                        }
                    default:
                        {
                            break;
                        }


                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
            datos.setQuery(query);
            datos.ejecutarRead();
            while (datos.Lector.Read())
            {
                Articulo aux = new Articulo();
                aux.IdArticulo = (int)datos.Lector["Id"];
                aux.Codigo = (string)datos.Lector["Codigo"];
                aux.Nombre = (string)datos.Lector["Nombre"];
                aux.Descripcion = (string)datos.Lector["Descripcion"];
                aux.Marca = new Marca();
                aux.Marca.IdMarca = (int)datos.Lector["IdMarca"];
                aux.Marca.Descripcion = (string)datos.Lector["DescripcionMarca"]; //USA EL NOMBRE QUE LE DI EN LA BDD
                aux.Categoria = new Categorias();
                aux.Categoria.IdCategoria = (int)datos.Lector["IdCategoria"];
                aux.Categoria.Descripcion = (string)datos.Lector["DescripcionCategoria"];
                if (!(datos.Lector["ImagenUrl"] is DBNull))
                    aux.UrlImagen = (string)datos.Lector["ImagenUrl"];

                aux.Precio = (decimal)datos.Lector["Precio"];

                listaFiltrada.Add(aux);
            }
            return listaFiltrada;
        }
    }
}