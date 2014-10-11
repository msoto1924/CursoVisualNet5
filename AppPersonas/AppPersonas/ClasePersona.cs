using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPersonas
{
    class ClasePersona
    {
        //Declarar Atributos
        string nombre;
        int edad;
        //Constructor Vacio
        public ClasePersona()
        {
        }
        //Constructor Con Parametros
        public ClasePersona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        //Metodos Get Y Set
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
            set
            {
                edad = value;
            }
        }
    }
}
