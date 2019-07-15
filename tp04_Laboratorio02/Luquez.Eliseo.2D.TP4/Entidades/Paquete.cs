using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {
        private string direccionEntrega;
        private EEstado estado;
        private string trackingID;

        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformarEstado;

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }

        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { this.direccionEntrega = value; }
        }

        public EEstado Estado
        {
            get { return this.estado; }
            set { this.estado = value; }
        }

        public string TrackingID
        {
            get { return this.trackingID; }
            set { this.trackingID = value; }
        }

        public Paquete(string direccionEntrega, string trackingID)
        {
            this.trackingID = trackingID;
            this.direccionEntrega = direccionEntrega;
        }

        public void MockCicloDeVida()
        {
            while(this.Estado != EEstado.Entregado)
            {
                Thread.Sleep(2000);
                if(this.Estado == EEstado.Ingresado)
                {
                    this.Estado = EEstado.EnViaje;
                }
                else if(this.Estado == EEstado.EnViaje)
                {
                    this.Estado = EEstado.Entregado;
                }
                DelegadoEstado delegado = this.InformarEstado;
                delegado(this, null);
            }
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            return string.Format("{0} para {1}", ((Paquete)elemento).trackingID, ((Paquete)elemento).direccionEntrega);
        }

        public static bool operator ==(Paquete p1, Paquete p2)
        {
            if(p1.trackingID == p2.trackingID)
            {
                return true;
            }
            return false;
        }

        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }

        public override string ToString()
        {
            return this.MostrarDatos((IMostrar<Paquete>)this);
        }

    }
}
