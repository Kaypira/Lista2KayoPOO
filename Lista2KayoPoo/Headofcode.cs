using System;
using System.Reflection.Metadata.Ecma335;

namespace Classes
{
    public class Mofi
    {


        public string exercicio1()
        {
            //ex1
            Console.WriteLine("digite o estoque minimo da peça "); int esto1 = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o estoque maximo da peça "); int esto2 = int.Parse(Console.ReadLine());
            double esto3 = (esto1 + esto2) / 2;
            return (" o estoque medio é " + esto3);

        }
        public string exercicio2()
        {
            //ex2

            Console.WriteLine("digite a cotaçao do dolar de hoje "); double cota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("digite o seu valor em dólar "); double dolar = double.Parse(Console.ReadLine());
            return ("o seu valor em reais é de " + (cota1 * dolar));
        }
        public string exercicio3()
        {
            //ex3
            Console.WriteLine("digite o seu codigo de vendedor "); int codvendedor = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o codigo da peça "); int codpeca = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a quantidade vendida da peça "); int quantpeca = int.Parse(Console.ReadLine());
            Console.WriteLine("digite o valor da peça "); double valorpeca = double.Parse(Console.ReadLine());
            double valorvendido = valorpeca * quantpeca;
            double comissao = valorvendido * 0.05;
            return ($"o vendedor {codvendedor} vendeu a  quantidade de {quantpeca}  da peça {codpeca}  pelo valor final de {valorvendido} e sua comissão foi {comissao}: ");
        }
        public string exercicio4()
        {
            // ex4
            int a, b, c, d;
            Console.WriteLine("Digite o valor de A: "); a = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de B: "); b = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de C: "); c = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor de D: "); d = int.Parse(Console.ReadLine());
            int somaAB = a + b;
            int somaAC = a + c;
            int somaAD = a + d;
            int somaBC = b + c;
            int somaBD = b + d;
            int somaCD = c + d;

            int multAB = a * b;
            int multAC = a * c;
            int multAD = a * d;
            int multBC = b * c;
            int multBD = b * d;
            int multCD = c * d;
            Console.WriteLine("Soma A+B: " + somaAB);
            Console.WriteLine("Soma A+C: " + somaAC);
            Console.WriteLine("Soma A+D: " + somaAD);
            Console.WriteLine("Soma B+C: " + somaBC);
            Console.WriteLine("Soma B+D: " + somaBD);
            Console.WriteLine("Soma C+D: " + somaCD);

            Console.WriteLine("Multiplicação A*B: " + multAB);
            Console.WriteLine("Multiplicação A*C: " + multAC);
            Console.WriteLine("Multiplicação A*D: " + multAD);
            Console.WriteLine("Multiplicação B*C: " + multBC);
            Console.WriteLine("Multiplicação B*D: " + multBD);
            Console.WriteLine("Multiplicação C*D: " + multCD);
            return " ";
        }
        public string exercicio5()
        {
            Console.WriteLine("digite o tempo percorrido horas durante a viagem"); int tempo = int.Parse(Console.ReadLine());
            Console.WriteLine("digite a velocidade media da viagem "); int velo = int.Parse(Console.ReadLine());
            int distancia = tempo * velo;
            int litrosusa = distancia / 12;
            return ($"tempo percorrido foi {tempo} a velocidade media foi {velo} a distancia foi {distancia} e o consumo foi {litrosusa} ");


        }

        public string exercicio6()
        {
            Console.WriteLine("Digite a temperatura em graus celsius "); Decimal c = Decimal.Parse(Console.ReadLine());
            decimal f = (9 * c + 160) / 5;
            return ($"A Temperatura  {c} em celsius é {f} em fahrenheit ");
        }
        public string exercicio7()

        {
            Console.WriteLine("Digite a temperatura em graus Fahrenheit "); Decimal f = Decimal.Parse(Console.ReadLine());
            decimal c = (f - 32) * 5 / 9;
            return ($"A Temperatura  {f} em fahrenheit é {c} em celsius ");



        }
        public string exercicio8()
        {

            Console.WriteLine("Digite o raio da lata "); decimal r = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura da lata "); decimal a = decimal.Parse(Console.ReadLine());
            decimal v = 3 * r * r * a;
            return ("o volume da lata de oleo é " + v);

        }
        public string exercicio9()
        {
            Console.WriteLine("Digite sua idade em anos "); int idadea = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite os meses completos apos os anos "); int mesesa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a quantidade de dias apos os meses completos"); int diasa = int.Parse(Console.ReadLine());
            int idadediaria = (idadea * 365) + (mesesa * 30) + diasa;
            return ($" Sua idade em dias é de {idadediaria} ");
        }
        public string exercicio10()
        {
            Console.WriteLine("Digite o numero A "); int numa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero B "); int numb = int.Parse(Console.ReadLine());
            if (numa == numb)
            {
                return ("eles sao iguais ");
            }
            if (numa != numb)
            {
                Console.WriteLine(" eles são diferetes ");
            }
            if (numa > numb) Console.WriteLine(" o primeiro numero é maior ");
            return (" o segundo numero é maior ");



        }

        public string exercicio11()
        {
            Console.WriteLine("Digite o numero A "); int numa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero B "); int numb = int.Parse(Console.ReadLine());
            int numc = numa;
            numa = numb;
            numb = numc;
            return ($"os valores de a é {numa} e b {numb} ");


        }
        public string exercicio12()
        {
            Console.WriteLine("Digite um numero  "); int numa = int.Parse(Console.ReadLine());
            if (numa >= 0) return ($" o modulo do nuemro é {numa} ");
            return ($" o modulo do numero -{numa}");
        }
        public string exercicio13()
        {
            int[] decre = new int[3];
            int i = 0;
            do
            {
                Console.WriteLine("Digite um numero  "); decre[i] = int.Parse(Console.ReadLine());
                i++;

            } while (i != 3);
            Array.Sort(decre);
            Array.Reverse(decre);
            string resulta = " ";
            foreach (int a in decre)
            {
                resulta += a + "\n";

            }
            return resulta;
        }
        public string exercicio14()
        {
            Console.WriteLine("Digite o numero A "); int numa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero B "); int numb = int.Parse(Console.ReadLine());
            ;
            if (numa >= numb)
            {
                int numx = numa - numb;
                Console.WriteLine("A Diferença do maior para o menor é de " + numx);


            }
            return ("A Diferença do maior para o menor é de " + (numb - numa));
        }
        public string exercicio15()
        {
            Console.WriteLine("Digite a primeira nota "); int notaa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota "); int notab = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota "); int notac = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a querta nota "); int notad = int.Parse(Console.ReadLine());
            int mediaa = (notaa + notab + notac + notad) / 4;
            if (mediaa >= 70) return (" voce esta aprovado parabens sua media foi " + mediaa);
            Console.WriteLine("Digite a sua nota de recuperaçao  "); int recu1 = int.Parse(Console.ReadLine());
            int raleu2 = mediaa + recu1 / 2;
            if (raleu2 >= 70) return (" voce esta aprovado na recuperaçao sua media foi " + raleu2);
            return ("voce esta reprovado :( " + raleu2);

        }
        public string exercicio16()
        {
            Console.WriteLine("Digite o numero A "); int numa = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o numero B "); int numb = int.Parse(Console.ReadLine());
            if (numa > numb) return ($"o numero a {numa} é maior que o b {numb} ");
            if (numa < numb) return ($"o numero b {numb} é maior que o a {numa} ");
            return ("os dois numeros são iguais ");


        }
        public string exercicio17()
        {
            Console.WriteLine("Digite o numero A "); int numa = int.Parse(Console.ReadLine());
            if (numa > 0 && numa < 9) return ("valor valido");
            return ("valor invalido");


        }
        public string exercicio18()
        {
            return ("Digite um número inteiro: ");
            int CODIGO = Convert.ToInt32(Console.ReadLine());
            switch (CODIGO)
            {
                case 1:
                    Console.WriteLine("um");
                    break;
                case 2:
                    Console.WriteLine("dois");
                    break;
                case 3:
                    Console.WriteLine("três");
                    break;
                default:
                    Console.WriteLine("Código inválido");
                    break;
            }


        }
        public string exercicio19()
        {
            Console.Write("Digite o valor do lado A: ");
            double A = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do lado B: ");
            double B = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite o valor do lado C: ");
            double C = Convert.ToDouble(Console.ReadLine());

            if (A < B + C && B < A + C && C < A + B)
            {
                if (A == B && B == C)
                {
                    Console.WriteLine("O triângulo é equilátero.");
                }
                else if (A == B || A == C || B == C)
                {
                    Console.WriteLine("O triângulo é isósceles.");
                }
                else
                {
                    Console.WriteLine("O triângulo é escaleno.");
                }
            }
            return ("Os valores fornecidos não formam um triângulo.");




        }
        public string exercicio20()
        {
            int a, b, c;
            a = LerValor("a");
            b = LerValor("b");
            c = LerValor("c");

            int maior = Math.Max(a, Math.Max(b, c));
            int menor = Math.Min(a, Math.Min(b, c));

            Console.WriteLine("Menor valor multiplicado pelo maior: " + (menor * maior));
            return ("Maior valor dividido pelo menor: " + ((double)maior / menor));
        }

        static int LerValor(string nomeVariavel)
        {
            int valor;
            do
            {
                Console.Write("Digite um valor maior que zero para " + nomeVariavel + ": ");
                valor = int.Parse(Console.ReadLine());
                if (valor <= 0)
                {
                    Console.WriteLine("Valor inválido. Tente novamente.");
                }
            } while (valor <= 0);
            return valor;

        }

        public string exercicio21()
        {
            while (true)
            {
                Console.Write("Digite um número inteiro (ou 'sair' para encerrar): ");
                string entrada = Console.ReadLine();
                if (entrada.ToLower() == "sair")
                {
                    break;
                }
                int numero = int.Parse(entrada);
                if (numero > 0)
                {
                    Console.WriteLine("O número é positivo.");
                }
                else if (numero < 0)
                {
                    Console.WriteLine("O número é negativo.");
                }
                else
                {
                    Console.WriteLine("O número é zero.");
                }

            }
            return ("fim algoritmo");
        }
        public string exercicio22()
        {
            int? A = null;
            int? B = null;

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero > 0)
            {
                A = numero;
            }
            else if (numero < 0)
            {
                B = numero;
            }

            Console.WriteLine("A: " + (A.HasValue ? A.Value.ToString() : "não definido"));
            return ("B: " + (B.HasValue ? B.Value.ToString() : "não definido"));
        }
        public string exercicio23()
        {
            return ("Escolha uma opção:");
            Console.WriteLine("1 - Adição");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            int opcao = int.Parse(Console.ReadLine());

            Console.Write("Digite o primeiro número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número: ");
            double num2 = double.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Resultado: " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Resultado: " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Resultado: " + (num1 * num2));
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Erro: não é possível dividir por zero.");
                    }
                    else
                    {
                        Console.WriteLine("Resultado: " + (num1 / num2));
                    }
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
        public string exercicio24()
        {
            Console.Write("Digite o primeiro número inteiro: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número inteiro: ");
            int num2 = int.Parse(Console.ReadLine());

            while (true)
            {
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Verificar se um dos números lidos é ou não múltiplo do outro");
                Console.WriteLine("2 - Verificar se os dois números lidos são pares");
                Console.WriteLine("3 - Verificar se a média dos dois números é maior ou igual a 7");
                return ("4 - Sair");
                int opcao = int.Parse(Console.ReadLine());

                if (opcao == 4)
                {
                    break;
                }

                switch (opcao)
                {
                    case 1:
                        if (num1 % num2 == 0 || num2 % num1 == 0)
                        {
                            Console.WriteLine("Um dos números é múltiplo do outro.");
                        }
                        else
                        {
                            Console.WriteLine("Os números não são múltiplos entre si.");
                        }
                        break;
                    case 2:
                        if (num1 % 2 == 0 && num2 % 2 == 0)
                        {
                            Console.WriteLine("Os dois números são pares.");
                        }
                        else
                        {
                            Console.WriteLine("Um ou ambos os números são ímpares.");
                        }
                        break;
                    case 3:
                        double media = (num1 + num2) / 2.0;
                        if (media >= 7)
                        {
                            Console.WriteLine("A média dos dois números é maior ou igual a 7.");
                        }
                        else
                        {
                            Console.WriteLine("A média dos dois números é menor que 7.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
        }
        public string exercicio25()
        {

            Console.Write("Digite sua altura em metros: ");
            double altura = double.Parse(Console.ReadLine());
            Console.Write("Digite seu sexo (M para masculino, F para feminino): ");
            char sexo = char.Parse(Console.ReadLine());

            double pesoIdeal = 0;
            if (sexo == 'M' || sexo == 'm')
            {
                pesoIdeal = (72.7 * altura) - 58;
            }
            else if (sexo == 'F' || sexo == 'f')
            {
                pesoIdeal = (62.1 * altura) - 44.7;
            }
            else
            {
                Console.WriteLine("Sexo inválido.");
            }

            return ("Seu peso ideal é: " + pesoIdeal);
        }
        public string exercicio26()
        {
            for (int i = 100; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
            return "Fim codigo";
        }
        public string exercicio27()
        {
            Console.Write("Digite a quantidade de números que deseja processar: ");
            int quantidade = int.Parse(Console.ReadLine());

            for (int i = 0; i < quantidade; i++)
            {
                Console.Write("Digite um número: ");
                int numero = int.Parse(Console.ReadLine());

                long fatorial = 1;
                for (int j = 1; j <= numero; j++)
                {
                    fatorial *= j;
                }

                Console.WriteLine("Fatorial de " + numero + ": " + fatorial);
            }
            return "fim exercicio 27 ";
        }
        public string exercicio28()
        {

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();

            return "fim exercicio 28";

        }
        public string exercicio29()
        {
            {
                for (int i = 1; i <= 2000; i++)
                {
                    Console.WriteLine(i);
                }
                Console.ReadLine();
            }
            return "fim exercicio 29";
        }
        public string exercicio30()
        {
            Console.WriteLine("Digite um número para ver sua tabuada:");
            int num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(num + " x " + i + " = " + (num * i));
            }
            Console.ReadLine();
            return "fim exercicio 30";
        }
        public string exercicio31()
        {
            int num, sumEven = 0, sumOdd = 0;
            Console.WriteLine("Digite uma sequência de números positivos (digite um número negativo para encerrar):");

            do
            {
                num = Convert.ToInt32(Console.ReadLine());
                if (num > 0)
                {
                    if (num % 2 == 0)
                    {
                        Console.WriteLine(num + " é par");
                        sumEven += num;
                    }
                    else
                    {
                        Console.WriteLine(num + " é ímpar");
                        sumOdd += num;
                    }
                }
            } while (num > 0);

            Console.WriteLine("A soma dos números pares é: " + sumEven);
            Console.WriteLine("A soma dos números ímpares é: " + sumOdd);
            Console.ReadLine();
            return "fim exercicio 31";
        }
        public string exercicio32()
        {
            Console.WriteLine("Digite um número menor que 10 e maior que zero:");
            int num = Convert.ToInt32(Console.ReadLine());

            if (num > 0 && num < 10)
            {
                int sum = 0;
                for (int i = num; i <= num + 38; i += 2)
                {
                    sum += i * i;
                }
                Console.WriteLine("A soma dos quadrados dos 20 primeiros números inteiros positivos ímpares a partir de " + num + " é: " + sum);
            }
            else
            {
                Console.WriteLine("O número digitado não é válido.");
            }
            Console.ReadLine();
            return "fim exercicio 32";
        }
    }
}

