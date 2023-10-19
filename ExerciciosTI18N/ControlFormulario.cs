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
            Console.WriteLine("\n\n---------- Menu -------------\n" +
                              " 0. Sair\n" +
                              " 1. Exercício 01\n" +
                              " 2. Exercício 02\n" +
                              " 3. Exercício 03\n" +
                              " 4. Exercício 04\n" +
                              " 5. Exercício 05\n" +
                              " 6. Exercício 06\n" +
                              " 7. Exercício 07\n" +
                              " 8. Exercício 08\n" +
                              " 9. Exercício 09\n" +
                              "10. Exercício 10\n" +
                              "11. Exercício 11\n" +
                              "12. Exercício 12\n" +
                              "13. Exercício 13\n" +
                              "14. Exercício 14\n" +
                              "15. Exercício 15\n" +
                              "16. Exercício 16\n" +
                              "-----------------------------" +
                              "\nEscolha uma das opções acima: ");
            ConsultarOpcao = Convert.ToInt32(Console.ReadLine());
        }//Fim do método menu

        public int MenuCd()
        {
            Console.WriteLine("\n\n---------- Menu -------------\n" +
                              "0. Sair\n" +
                              "1. Verde\n" +
                              "2. Azul\n" +
                              "3. Amarelo\n" +
                              "4. Vermelho\n" +
                              "-----------------------------" +
                              "\nEscolha um dos tipos de CD's acima: ");
            int opcao = Convert.ToInt32((Console.ReadLine()));
            return opcao;
        }

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
                        double base2;
                        double altura;

                        do
                        {
                            Console.WriteLine("Informe a base: ");
                            base2 = Convert.ToDouble(Console.ReadLine());

                            if (base2 <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        } while (base2 <= 0);

                        do
                        {
                            Console.WriteLine("Informe a altura: ");
                            altura = Convert.ToDouble(Console.ReadLine());

                            if (altura <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        }while (altura <= 0);

                        //Área do retângulo
                        Console.WriteLine("A área deste retângulo é: " + exercicio.Area(base2, altura));
                        break;
                    case 5:
                        double totalEleitores = 0;
                        double vBranco = 0;
                        double vNulo = 0;
                        double vValido = 0;
                       
                        //Pegando os dados sobre os votos
                        do
                        {
                            do
                            {

                                Console.WriteLine("Informe o total de eleitores: ");
                                totalEleitores = Convert.ToInt32(Console.ReadLine());

                                if (exercicio.Validar(totalEleitores) == true)
                                {
                                    Console.WriteLine("Informe um valor maior que 0");
                                }
                            }while(totalEleitores <= 0);

                            do
                            {
                                Console.WriteLine("Informe o número de votos brancos: ");
                                vBranco = Convert.ToInt32(Console.ReadLine());

                                if (exercicio.Validar(vBranco) == true)
                                {
                                    Console.WriteLine("Informe um valor maior que 0");
                                }
                            }while(vBranco <= 0);

                            do
                            {
                                Console.WriteLine("Informe o número de votos nulos: ");
                                vNulo = Convert.ToInt32(Console.ReadLine());

                                if (exercicio.Validar(vNulo) == true)
                                {
                                    Console.WriteLine("Informe um valor maior que 0");
                                }
                            }while(vNulo <= 0);

                            do
                            {
                                Console.WriteLine("Informe o número de votos válidos: ");
                                vValido = Convert.ToInt32(Console.ReadLine());

                                if (exercicio.Validar(vValido) == true)
                                {
                                    Console.WriteLine("Informe um valor maior que 0");
                                }
                            }while(vValido <= 0);

                            if (totalEleitores != vBranco + vNulo + vValido)
                            {
                                Console.WriteLine("Erro! O número total de eleitores não coincide com o total de votos");
                            }
                        } while (totalEleitores != vBranco + vNulo + vValido);
                        //Fim

                        //Calculando o percentual
                        Console.WriteLine("O percentual de votos brancos é: " + exercicio.Percentual(vBranco, totalEleitores) + "%");
                        Console.WriteLine("O percentual de votos nulos é: " + exercicio.Percentual(vNulo, totalEleitores) + "%");
                        Console.WriteLine("O percentual de votos válidos é: " + exercicio.Percentual(vValido, totalEleitores) + "%");
                        //Fim
                        break;
                    case 6:
                        double salario;
                        double reajuste;

                        //Pedindo salário
                        do
                        {
                            Console.WriteLine("Informe o salário atual: ");
                            salario = Convert.ToDouble(Console.ReadLine());

                            if (salario <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        } while (salario <= 0);
                        //Fim

                        //Pedindo o percentual de reajuste
                        do
                        {
                            Console.WriteLine("Informe o percentual de reajuste: ");
                            reajuste = Convert.ToDouble(Console.ReadLine());

                            if (reajuste <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        }while (reajuste <= 0);
                        //Fim

                        //Informando o novo salário
                        Console.WriteLine("O novo salário deste funcionário é: " + exercicio.NovoSalario(salario, reajuste));

                        break;
                    case 7:
                        double custoFabrica;
                        double pDistribuidor;
                        double pImposto;

                        //Pegando os dados
                        do
                        {
                            Console.WriteLine("Informe o custo de fábrica: ");
                            custoFabrica = Convert.ToDouble(Console.ReadLine());

                            if (custoFabrica <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        }while(custoFabrica <= 0);

                        do
                        {
                            Console.WriteLine("Informe a porcentagem do distribuidor: ");
                            pDistribuidor = Convert.ToDouble(Console.ReadLine());

                            if (pDistribuidor <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        } while (pDistribuidor <= 0);

                        do
                        {
                            Console.WriteLine("Informe a porcentagem dos impostos: ");
                            pImposto = Convert.ToDouble(Console.ReadLine());

                            if (pImposto <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        } while (pImposto <= 0);

                        //Mostrando em tela
                        Console.WriteLine("O custo final é: " + exercicio.CustoFinal(custoFabrica, pDistribuidor, pImposto));

                        break;
                    case 8:
                        
                        //Pegando os dados
                        do
                        {
                            Console.WriteLine("Informe o salário do funcionário: ");
                            salario = Convert.ToDouble(Console.ReadLine());

                            if (salario <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        }while(salario <= 0);

                        double comissao;                        
                        do
                        {
                            Console.WriteLine("Informe a comissão por carro vendido: ");
                            comissao = Convert.ToDouble(Console.ReadLine());

                            if (comissao <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        } while (comissao <= 0);

                        int quantidade;
                        do
                        {
                            Console.WriteLine("Informe a quantidade de carros vendidos: ");
                            quantidade = Convert.ToInt32(Console.ReadLine());

                            if (quantidade <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        } while (quantidade <= 0);

                        double totalVendas;
                        do
                        {
                            Console.WriteLine("Informe o total de vendas deste funcionário: ");
                            totalVendas = Convert.ToDouble(Console.ReadLine());

                            if (totalVendas <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        } while (totalVendas <= 0);

                        //Mostrando o salário final
                        Console.WriteLine("O salário final deste vendedor é: " + exercicio.SalarioFinal(salario, comissao, quantidade, totalVendas));
                        break;
                    case 9:
                        double nota3;

                        //Pegando as notas
                        do
                        {
                            Console.WriteLine("Informe a 1° nota: ");
                            nota1 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota1) == true)
                            {
                                Console.WriteLine("Informe um valor de 0 a 10");
                            }
                        } while (exercicio.ValidarNotas(nota1) == true);

                        do
                        {
                            Console.WriteLine("Informe a 2° nota: ");
                            nota2 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota2) == true)
                            {
                                Console.WriteLine("Informe um valor de 0 a 10");
                            }
                        } while (exercicio.ValidarNotas(nota2) == true);

                        do
                        {
                            Console.WriteLine("Informe a 3° nota: ");
                            nota3 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota3) == true)
                            {
                                Console.WriteLine("Informe um valor de 0 a 10");
                            }
                        } while (exercicio.ValidarNotas(nota3) == true);

                        //Mensagem em tela
                        if (exercicio.Media(nota1, nota2, nota3) < 5)
                        {
                            Console.WriteLine("Aluno em recuperação e precisa de " + exercicio.NotaParaPassar(exercicio.Media(nota1, nota2,nota3)));
                        }
                        else
                        {
                            if (exercicio.Media(nota1, nota2, nota3) >= 5 && exercicio.Media(nota1, nota2, nota3) < 7)
                            {
                                Console.WriteLine("Aluno em prova final e precisa de " + exercicio.NotaParaPassar(exercicio.Media(nota1, nota2, nota3)));
                            }
                            else
                            {
                                Console.WriteLine("Aluno passado por média");
                            }
                        }
                        break;
                    case 10:
                        int opcao;
                        do
                        {
                            opcao = MenuCd();//Menu para escolha dos CD's
                            switch (opcao)
                            {
                                case 0:
                                    Console.WriteLine("Obrigado!!");
                                    break;
                                case 1:
                                    Console.WriteLine("R$10,00");
                                    break;
                                case 2:
                                    Console.WriteLine("R$20,00");
                                    break;
                                case 3:
                                    Console.WriteLine("R$30,00");
                                    break;
                                case 4:
                                    Console.WriteLine("R$40,00");
                                    break;
                                default:
                                    Console.WriteLine("Opção escolhida não é válida");
                                    break;
                            }
                            
                        } while (opcao != 0);
                        break;
                    case 11:
                        Console.WriteLine("Informe um número: ");
                        num = Convert.ToInt32(Console.ReadLine());

                        if (exercicio.ValidarPar(num) == true)
                        {
                            Console.WriteLine("Este número é par");
                        }
                        else
                        {
                            Console.WriteLine("Este número é impar");
                        }
                        break;
                    case 12:
                        //Idade
                        int idade;
                        do
                        {
                            Console.WriteLine("Informe a sua idade: ");
                            idade = Convert.ToInt32(Console.ReadLine());

                            if (idade < 0)
                            {
                                Console.WriteLine("Informe um valor positivo");
                            }
                        } while (idade < 0);

                        //Validação
                        if (exercicio.MaiorDeIdade(idade) == true)
                        {
                            Console.WriteLine("Você é maior de idade e já pode ser preso");
                        }
                        else
                        {
                            Console.WriteLine("Você é menor de idade e ainda não pode beber");
                        }
                        break;
                    case 13:
                        Console.WriteLine("Informe o 1° número: ");
                        double num3 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("Informe o 2° número: " );
                        double num4 = Convert.ToDouble(Console.ReadLine());

                        double maior = exercicio.Comparar(num3, num4);//Compara os dois números digitados e uma variável recebe o maior

                        Console.WriteLine("Informe o 3° número: ");
                        double num5 = Convert.ToDouble(Console.ReadLine());

                        Console.WriteLine("O maior número é: " + exercicio.Comparar(num5, maior));
                        break;
                    case 14:
                        int ano;
                        do
                        {
                            Console.WriteLine("Informe o ano: ");
                            ano = Convert.ToInt32(Console.ReadLine());

                            if (exercicio.Validar(ano) == true)
                            {
                                Console.WriteLine("Informe um número positivo");
                            }
                        } while (exercicio.Validar(ano) == true);

                        if (exercicio.Bissexto(ano) == true)
                        {
                            Console.WriteLine("Este ano é bissexto");
                        }
                        else
                        {
                            Console.WriteLine("Este ano não é bissexto");
                        }
                        break;
                    case 15:
                        do
                        {
                            Console.WriteLine("Informe a 1° nota: ");
                            nota1 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota1) == true)
                            {
                                Console.WriteLine("Informe um valor entre 0 e 10");
                            }
                        }while(exercicio.ValidarNotas(nota1) == true);

                        do
                        {
                            Console.WriteLine("Informe a 2° nota: ");
                            nota2 = Convert.ToDouble(Console.ReadLine());

                            if (exercicio.ValidarNotas(nota2) == true)
                            {
                                Console.WriteLine("Informe um valor entre 0 e 10");
                            }
                        } while (exercicio.ValidarNotas(nota2) == true);

                        if(exercicio.MediaDuasNotas(nota1, nota2) >= 7)
                        {
                            Console.WriteLine("Aprovado");
                        }
                        else
                        {
                            Console.WriteLine("Reprovado");
                        }
                        break;
                    case 16:
                        double lado1;
                        double lado2;
                        double lado3;

                        do
                        {
                            Console.WriteLine("Informe o 1° lado: ");
                            lado1 = Convert.ToDouble(Console.ReadLine());

                            if (lado1 <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        } while (lado1 <= 0);

                        do
                        {
                            Console.WriteLine("Informe o 2° lado: ");
                            lado2 = Convert.ToDouble(Console.ReadLine());

                            if (lado2 <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        } while (lado2 <= 0);

                        do
                        {
                            Console.WriteLine("Informe o 3° lado: ");
                            lado3 = Convert.ToDouble(Console.ReadLine());

                            if (lado3 <= 0)
                            {
                                Console.WriteLine("Informe um valor maior que 0");
                            }
                        } while (lado3 <= 0);

                        break;
                    default:
                        Console.WriteLine("Opção escolhida não é válida");
                        break;
                }//Fim do escolha
            } while (ConsultarOpcao != 0); //Fim do while
        }//Fim do operacao

    }//Fim da classe
}//Fim do Projeto
