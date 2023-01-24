using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraTest
{
    public class Calculator
    {
        private char[] delimiters = new char[] { ',', ';', '/' };

        public int Add(string values)
        {
            if (string.IsNullOrEmpty(values))
                return 0;

            if(values.IndexOfAny(delimiters) < 0)
                throw new Exception("Cáracter no válido como separador");

            return values.Split(delimiters)
                .Select(x => ParseValue(x))
                .Sum();
            
        }

        private int ParseValue(string x)
        {
            int parsedValue = 0;

            if(!int.TryParse(x,out parsedValue))    
                throw new Exception($"{x} no es posible convertirlo en entero");

            if (parsedValue < 0)
                throw new Exception("No se admiten valores negativos");

            if (parsedValue > 100)
                return 0;

            return parsedValue;
        }
    }
}
