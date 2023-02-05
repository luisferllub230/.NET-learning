using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora.Controller
{
    public class CalculatorControler
    {
        private float answer = 0;

        
        public string operation(String operate, float num1, float num2) 
        {
            switch (operate) 
            {
                case "+":
                    this.answer =num1 + num2;
                    return ""+this.answer;
                case "-":
                    this.answer = num1 - num2;
                    return ""+this.answer;
                case "/":
                    if (num1 != 0 && num2 != 0)
                    {
                       
                        this.answer = num2/num1;
                        return "" + answer;
                    }
                    else 
                    {
                        return "error 0 division :|";
                    }
                case "*":
                    this.answer = num1 * num2;
                    return ""+answer;
                default:
                    return "error capa 8";
            }
        }

    }
}
