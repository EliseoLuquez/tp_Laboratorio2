using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excepciones
{
    public class DniInvalidException : Exception
    {
		private string mensaje;

		/// <summary>
		/// 
		/// </summary>
		public DniInvalidException() : base()
		{
			this.mensaje = this.Message;
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="e"></param>
		public DniInvalidException(Exception e) : base()
		{
		}

		/// <summary>
		/// 
		/// </summary>
		public DniInvalidException(string message) : base(message)
		{
		}

		/// <summary>
		/// 
		/// </summary>
		/// <param name="message"></param>
		public DniInvalidException(string message, Exception e) : base(message, e)
		{
		}

	}
}
