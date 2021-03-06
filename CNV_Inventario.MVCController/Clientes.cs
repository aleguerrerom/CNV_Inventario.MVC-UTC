using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CNV_Inventario.MVCController
{
    public class Clientes
    {
        public int opc
        {
            get; set;
        }
        string tipo;
        int cedula;
        string contacto;
        int telefono;
        string correo;
        string direccion;
        string agente;

        public string Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }

        public int Cedula
        {
            get
            {
                return cedula;
            }

            set
            {
                cedula = value;
            }
        }

        public string Contacto
        {
            get
            {
                return contacto;
            }

            set
            {
                contacto = value;
            }
        }

        public int Telefono
        {
            get
            {
                return telefono;
            }

            set
            {
                telefono = value;
            }
        }

        public string Correo
        {
            get
            {
                return correo;
            }

            set
            {
                correo = value;
            }
        }

        public string Direccion
        {
            get
            {
                return direccion;
            }

            set
            {
                direccion = value;
            }
        }

        public string Agente
        {
            get
            {
                return agente;
            }

            set
            {
                agente = value;
            }
        }

        public Clientes(string tipo, int cedula, string contacto, int telefono, string correo, string direccion, string agente)
        {
            this.Tipo = tipo;
            this.Cedula = cedula;
            this.Contacto = contacto;
            this.Telefono = telefono;
            this.Correo = correo;
            this.Direccion = direccion;
            this.Agente = agente;
        }
        public Clientes()
        {
            this.Tipo = "";
            this.Cedula = 0;
            this.Contacto = "";
            this.Telefono = 0;
            this.Correo = "";
            this.Direccion = "";
            this.Agente = 0;
        }
    }
}
}
