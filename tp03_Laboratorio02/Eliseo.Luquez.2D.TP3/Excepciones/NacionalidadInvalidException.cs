﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Excepciones
{
    public class NacionalidadInvalidException : Exception
    {
		public NacionalidadInvalidException() : this("Nacionalidad invalida")
		{

		}

		public NacionalidadInvalidException(string menssage) : base(menssage)
		{

		}
	}
}
