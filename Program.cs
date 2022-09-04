using System;

namespace md06_CadernoExercicios_03
{
    class Program
    /*
     3. Faça um algoritmo que calcule a média de salários de uma empresa,
        pedindo ao usuário a quantidade de funcionários e o salário de cada
        funcionário. Exiba a média salarial, o salário mais alto e o salário mais baixo.
        O programa deve perguntar ao usuário se deseja encerrar a aplicação.
        Números devem ser tratados.
     */
    {
        static void Main(string[] args)
        {
            string Sair = "N";
            do
            {
                int qtdFuncionarios, i = 1;
                double salarioFuncionarios = 0, salarioFuncionariosTotal = 0, mediaSalarial,
                    maiorSalario = 0, menorSalario = 0;
                string  OpcaoInvalida = "S";

                Console.WriteLine("Informe a Quantidade de Funcionários!");
                qtdFuncionarios = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Informe o salário de cada funcionário;\n");

                do
                {
                    Console.WriteLine("Digite o salário do " + i + "° funcionário;");
                    salarioFuncionarios = Convert.ToDouble(Console.ReadLine());
                    salarioFuncionariosTotal = salarioFuncionariosTotal + salarioFuncionarios;
                    if (menorSalario == 0)
                    {
                        menorSalario = salarioFuncionarios;
                    }
                    if (maiorSalario < salarioFuncionarios)
                    {
                        maiorSalario = salarioFuncionarios;
                    }
                    if (menorSalario > salarioFuncionarios)
                    {
                        menorSalario = salarioFuncionarios;
                    }

                    i++;
                } while (i <= qtdFuncionarios);
                mediaSalarial = salarioFuncionariosTotal / qtdFuncionarios;
                Console.WriteLine("\nRESULTADO DA CONSULTA\n");
                Console.WriteLine("A média salarial é : R$ {0}", mediaSalarial.ToString("0.00"));
                Console.WriteLine("\nSalário mais alto : R$ {0}", maiorSalario.ToString("0.00"));
                Console.WriteLine("\nSalário mais baixo : R$ {0}", menorSalario.ToString("0.00"));
                Console.WriteLine("\nSomatório de Salários : R$ {0}", salarioFuncionariosTotal.ToString("0.00"));


                Console.WriteLine("\nDeseja sair do sistema?\nDigite (S) para sair, ou (N) para Continuar.");
                Sair = Console.ReadLine();
                if (Sair.Equals("s"))
                {
                    Sair = "S";
                }
                else if (Sair.Equals("n"))
                {
                    Sair = "N";
                }
                else if (Sair != "S" || Sair != "N")
                {

                    do
                    {
                        Console.WriteLine("\nOpção Inválida.\nDigite (S) para sair, ou (N) para Continuar.");
                        Sair = Console.ReadLine();
                        if (Sair.Equals("s"))
                        {
                            Sair = "S";
                        }
                        else if (Sair.Equals("n"))
                        {
                            Sair = "N";
                        }
                        if (Sair.Equals("S") || Sair.Equals("N"))
                        {
                            OpcaoInvalida = "N";
                        }

                    } while (OpcaoInvalida == "S");
                    OpcaoInvalida = "S";
                }

            } while (Sair == "N");

            Console.WriteLine("\nObrigado por utilizar o sistema!");
            Sair = "N";
        }
    }
}
