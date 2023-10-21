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
            if ((nota < 0) || (nota > 10))
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Fim do método

        //Exercício 02
        public double Comparar(double num1, double num2)
        {
            if (num1 > num2)
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
        public double Percentual(double votos, double totalEleitores)
        {
            return (votos / totalEleitores) * 100;
        }//Fim do percentual

        public Boolean Validar(double num)
        {
            if (num < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Exercício 06
        public double NovoSalario(double salario, double reajuste)
        {
            return salario + (salario * (reajuste / 100));
        }//Fim do NovoSalario

        //Exercicio 07
        public double CustoFinal(double custoFabrica, double pDistribuidor, double pImposto)
        {
            return custoFabrica + (custoFabrica * (pDistribuidor / 100)) + (custoFabrica * (pImposto / 100));
        }//Fim do CustoFinal

        //Exercício 08
        public double SalarioFinal(double salario, double comissao, int quantidade, double totalVendas)
        {
            return salario + (comissao * quantidade) + (totalVendas * 0.05);
        }//Fim do SalarioFinal

        //Exercício 09
        public double Media(double nota1, double nota2, double nota3)
        {
            return (nota1 + nota2 + nota3) / 3;
        }//Fim Media

        public double NotaParaPassar(double media)
        {
            if (media >= 0 && media < 5)
            {
                return 10 - media + 2;
            }
            else
            {
                return 10 - media;
            }
        }//Fim NotaParaPassar

        //Exercício 11
        public Boolean ValidarPar(int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Exercício 12
        public Boolean MaiorDeIdade(int num)
        {
            if (num >= 18)
            {
                return true;
            }
            else
            { 
                return false; 
            }
        }

        //Exercício 14
        public Boolean Bissexto(int ano)
        {
            if (ano % 4 == 0)
            {
                return true;
            }
            else
            {
                if(ano % 100 == 0 && ano % 400 ==0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        //Método Alternativo --------  DateTime.IsLeapYear(ano) - Retorna como valor True ou False

        //Exercício 16
        public Boolean Equilatero(double lado1, double lado2, double lado3)
        {
            if (lado1 == lado2 && lado2 == lado3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public Boolean Escaleno(double lado1, double lado2, double lado3)
        {
            if (lado1 != lado2 && lado1 != lado3 && lado2 != lado3)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        //Exercício 17
        public Boolean Positivo(double num)
        {
            if(num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Validação caso positivo

        public Boolean Negativo(double num)
        {
            if (num < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Validação caso negativo

        public Boolean Zero(double num)
        {
            if (num == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//Validação caso 0

        //Exercício 18
        public Boolean ValidarMes(int mes)
        {
            if(mes >= 1 && mes <= 12)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Método Alternativo --------- DateTime.DaysInMonth(ano, mês) ----- informa quantidade de dias em um mês e dia informados

        //Exercício 19
        public double ImpostoRenda(double salario)
        {
            if (salario <= 2112)
            {
                return salario;
            }
            else
            {
                if(salario >= 2112.01 && salario <= 2826.65)
                {
                    return salario - 158.40;
                }
                else
                {
                    if(salario >= 2826.66 && salario <= 3751.05)
                    {
                        return salario - 370.40;
                    }
                    else
                    {
                        if (salario >= 3751.06 && salario <= 4664.68)
                        {
                            return salario - 651.73;
                        }
                        else
                        {
                            return salario - 884.96;
                        }
                    }
                }
            }
        }
        }//Fim da Classe
}//Fim do Projeto
