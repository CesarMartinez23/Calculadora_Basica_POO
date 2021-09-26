using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora_Funcional
{
    class Calculadora
    {

        //Properties

        //Primer valor o dato.
        public double _numero_1 { get; set; }

        //Segundo valor o dato.
        public double _numero_2 { get; set; }

        //Listo 2 numeros para poder realizar una operacion matematica.

        //Operador segun seleccion.
        public string _operador { get; set; }




        //Creacion de Metodos de Operaciones Matematicas.


        //Metodo para Sumar.
        public double Sumar(double numero_1, double numero_2)
        {
            double Suma = numero_1 + numero_2;
            return Suma; 
        }

        //Metodo para Restar.
        public double Restar(double numero_1, double numero_2)
        {
            double Resta = numero_1 - numero_2;
            return Resta;
        }

        //Metodo para Multiplicar.
        public double Multiplicar(double numero_1, double numero_2)
        {
            double Multiplicacion = numero_1 * numero_2;
            return Multiplicacion;
        }

        //Metodo para Dividir.
        public double Dividir(double numero_1, double numero_2)
        {
            double Division = numero_1 / numero_2;
            return Division;
        }
    }
}
