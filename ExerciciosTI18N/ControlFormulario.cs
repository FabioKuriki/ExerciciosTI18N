using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciciosTI18N
{
    class ControlFormulario
    {
        ModelExercicio exercicio;
        private int opcao;
        public ControlFormulario()
        {
            exercicio = new ModelExercicio();//Conecta a classe model e a control
            ConsultarOpcao = -1;
        }//Fim do método construtor

        //Métodos modificadores
        public int ConsultarOpcao
        {
            get { return opcao; }
            set { opcao = value; }
        }//Fim do método

        public void Menu()
        {
            Console.WriteLine("\n\n ---------- Menu ----------\n" +
                              "0. Sair\n" +
                              "1. Exercício 01\n" +
                              "2. Exercício 02\n" +
                              "3. Exercício 03\n" +
                              "4. Exercício 04\n" +
                              "5. Exercício 05\n" +
                              "6. Exercício 06\n" +
                              "Escolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do método menu

        public void Operacao()
        {
            do
            {
                Menu();
                Console.Clear();//Limpar dados antigos
                switch (ConsultarOpcao)
                {
                    case 0:
                        Console.WriteLine("Obrigado");
                        break;
                    case 1:
                        double nota1 = 0;
                        double nota2 = 0;
                        do
                        {
                            Console.WriteLine("Informe a 1° nota: ");
                            nota1 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota1) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }//Fim da validação
                        } while (exercicio.ValidarNotas(nota1) == true);

                        do
                        {
                            Console.WriteLine("Informe a 2° nota: ");
                            nota2 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota2) == true)
                            {
                                Console.WriteLine("Informe uma nota entre 0 e 10");
                            }//Fim da validação
                        } while (exercicio.ValidarNotas(nota2) == true);

                        //Chamar o método da média que está na classe Model
                        Console.WriteLine("A média das notas digitadas é: " + exercicio.MediaDuasNotas(nota1, nota2));
                        break;
                    case 2:
                        Console.WriteLine("Informe o 1° número: ");
                        int num1 = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Informe o 2° número: ");
                        int num2 = Convert.ToInt32(Console.ReadLine());

                        //Comparação
                        Console.WriteLine("O maior número é: " + exercicio.Comparar(num1, num2));
                        break;
                    case 3:
                        Console.Write("Informe um número: ");
                        int num = Convert.ToInt32(Console.ReadLine());
                        //Mostrar o resultado
                        Console.WriteLine("O antecessor deste número é: " + exercicio.Antecessor(num));
                        break;
                    case 4:
                        Console.WriteLine("Informe a base: ");
                        double base2 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe a altura: ");
                        double altura = Convert.ToDouble(Console.ReadLine());

                        //Área do retângulo
                        Console.WriteLine("A área deste retângulo é: " + exercicio.Area(base2, altura));
                        break;
                    case 5:
                        int totalEleitores = 0;
                        int vBranco = 0;
                        int vNulo = 0;
                        int vValido = 0;
                        do
                        {
                            Console.WriteLine("Informe o total de eleitores: ");
                            totalEleitores = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o número de votos brancos: ");
                            vBranco = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o número de votos nulos: ");
                            vNulo = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Informe o número de votos válidos: ");
                            vValido = Convert.ToInt32(Console.ReadLine());

                            if (totalEleitores != vBranco + vNulo + vValido)
                            {
                                Console.WriteLine("Erro! O número total de eleitores não coincide com o total de votos");
                            }
                        } while (totalEleitores != vBranco + vNulo + vValido);

                        Console.WriteLine("O percentual de votos brancos é: " + exercicio.Percentual(vBranco, totalEleitores) + "%");
                        Console.WriteLine("O percentual de votos nulos é: " + exercicio.Percentual(vNulo, totalEleitores) + "%");
                        Console.WriteLine("O percentual de votos válidos é: " + exercicio.Percentual(vValido, totalEleitores) + "%");
                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida");
                        break;
                }//Fim do escolha
            } while (ConsultarOpcao != 0); //Fim do while
        }//Fim do operacao

    }//Fim da classe
}//Fim do Projeto
