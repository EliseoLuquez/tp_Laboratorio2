using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Dulce : Producto
  {
    public Dulce(EMarca marca, string patente, ConsoleColor color) : base(patente, marca, color)
    {

    }

    /// <summary>
    /// Los dulces tienen 80 calorías
    /// </summary>
    protected short CantidadCalorias
    {
      get { return 80; }
    }


    /// <summary>
    /// Muestra los atributos de Producto y Dulce
    /// </summary>
    /// <returns></returns>
    public override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();

      sb.AppendLine("DULCE ");
      sb.AppendLine((string)this);
      sb.AppendLine("CALORIAS : " + this.CantidadCalorias);
      sb.AppendLine("");
      sb.AppendLine("---------------------");

      return sb.ToString();
    }
  }
}
