using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppNumero
{
    class Numero
    {
        //Atributos
        int NumeroMayor;
        int NumeroMenor;
        //Constructor Con Parametros
        public Numero(int numero, int NumeroMayor)
        {
            this.NumeroMenor = NumeroMenor;
            this.NumeroMayor = NumeroMayor;
        }
        //Metodo Get Y Set
        public int numeromenor
        {
            get
            {
                return numeromenor;
            }
            set
            {
                numeromenor = value;
            }
        }
        public int numeromayor
        {
            get
            {
                return numeromayor;
            }
            set
            {
                numeromayor = value;
            }
        }
        //Metodo Transaccional = Operaciones
        public List<int> MostrarRango()
        {
            List<int> rango = new List<int>();
            for (int contador = numeromenor; contador <= numeromayor; contador++)
            {
                rango.Add(contador);
            }
            return rango;
        }

    }
}
