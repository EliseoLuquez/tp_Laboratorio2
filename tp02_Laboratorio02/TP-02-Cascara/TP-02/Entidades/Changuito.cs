using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace Entidades
{
  /// <summary>
  /// No podrá tener clases heredadas.
  /// </summary>
  public class Changuito
  {
    List<Producto> productos;
    private int espacioDisponible;

    public enum ETipo
    {
      Dulce, Leche, Snacks, Todos
    }

    private Changuito()
    {
      this.productos = new List<Producto>();
    }

    public Changuito(int espacioDisponible) : this()
    {
      this.espacioDisponible = espacioDisponible;
    }

    /// <summary>
    /// Agrega un Producto al Changuito
    /// </summary>
    /// <param name="c"></param>
    /// <param name="p"></param>
    /// <returns></returns>
    public static Changuito operator +(Changuito c, Producto p)
    {
      int cantidad;
      cantidad = c.productos.Count();
      foreach (Producto pAux in c.productos)
      {
        if (p == pAux)
        {
          return c;
        }
      }
      if (cantidad < c.espacioDisponible)
      {
        c.productos.Add(p);
      }
      return c;
    }

    /// <summary>
    /// Elimina un producto del Chamguito
    /// </summary>
    /// <param name="c"></param>
    /// <param name="p"></param>
    /// <returns></returns>
    public static Changuito operator -(Changuito c, Producto p)
    {
      foreach (Producto pAux in c.productos)
      {
        if (p == pAux)
        {
          c.productos.Remove(p);
          break;
        }
      }
      return c;
    }

    /// <summary>
    /// Sobreescritura, muestra la cantidad de productos y el espacio disponible
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine("Tenemos " + this.productos.Count() + " lugares ocupados de un total de " +
          espacioDisponible + " disponibles");
      return sb.ToString();
    }

    /// <summary>
    /// Muestra Producto dependiendo de su Tipo
    /// </summary>
    /// <param name="c"></param>
    /// <param name="tipo"></param>
    /// <returns></returns>
    public string Mostrar(Changuito c, ETipo tipo)
    {
      StringBuilder sb = new StringBuilder(ToString());
      foreach (Producto p in productos)
      {
        switch (tipo)
        {
          case ETipo.Dulce:
            if (p is Dulce)
            {
              sb.Append(p.Mostrar());
            }
            break;
          case ETipo.Leche:
            if (p is Leche)
            {
              sb.Append(p.Mostrar());
            }
            break;
          case ETipo.Snacks:
            if (p is Snacks)
            {
              sb.Append(p.Mostrar());
            }
            break;
          default:
            sb.Append(p.Mostrar());
            break;

        }
      }
      return sb.ToString();

    }
  }
}
