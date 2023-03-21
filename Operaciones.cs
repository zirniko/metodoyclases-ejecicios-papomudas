using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetodosYclasesEjercicio1
{
    //ahi que incorporar la palabra public antes del class
    public class Operaciones
    {
      public int  Sumar (int num1,
                         int num2)
        {
            int Resultado = 0;
            try
            {
                Resultado = num1 + num2;
                return Resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
       }
        public int Multiplicar(int num1,
                         int num2)
        {
            int Resultado = 0;
            try
            {
                Resultado = num1 * num2;
                return Resultado;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Restar (int num1,
                            int num2)
        {
            int Resultado = 0;
            try
            {
                Resultado = num1 - num2;
                return Resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public int Divicion(int num1,
                            int num2)
        {
            int Resultado = 0;
            try
            {
                Resultado = num1 / num2;
                return Resultado;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
