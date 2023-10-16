using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI18N
{
    class ModelExercicio
    {
        public ModelExercicio()
        {

        }//Fim do Construtor

        //Exercício 01 - A média de duas notas

        public double MediaDuasNotas(double nota1, double nota2)
        {
            return (nota1 + nota2) / 2;
        }//Fim do método média

        //Método de validação
        public Boolean ValidarNotas(double nota)
        {
            if((nota < 0) || (nota > 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Fim do método

        //Exercício 02
        public int Comparar(int num1, int num2)
        {
            if(num1>num2)
            {
                return num1;
            }
            else
            {
                return num2;
            }
        }//Fim do comparar

        //Exercício 03 - Mostrar o antecessor
        public int Antecessor(int num)
        {
            return num - 1;
        }//Fim do antecessor

        //Exercício 04 - Mostrar a área de um retângulo
        public double Area(double base2, double altura)
        {
            return base2 * altura;
        }//Fim do area

        //Exercício 05 - Percentual de Eleitores
        public double Percentual(int votos, int totalEleitores)
        {
            return (votos / totalEleitores) * 100;
        }//Fim do percentual
        
    }//Fim da Classe
}//Fim do Projeto
