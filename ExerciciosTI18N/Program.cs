using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI18N
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conectar a control com a program
            ControlFormulario control = new ControlFormulario(); 
            control.Operacao();

            //Manter aberto
            Console.ReadLine();
        }//Fim do método Main
    }//Fim da classe Program
}//Fim do Projeto
