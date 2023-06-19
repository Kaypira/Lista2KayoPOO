using System.ComponentModel;
using System.Globalization;

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
            return ("o seu valor em reais é de " + (cota1 * dolar ));
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
           return($"tempo percorrido foi {tempo} a velocidade media foi {velo} a distancia foi {distancia} e o consumo foi {litrosusa} ");


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
            return ("A Diferença do maior para o menor é de " + (numb - numa) );
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
            if (raleu2 >= 70 ) return (" voce esta aprovado na recuperaçao sua media foi " + raleu2);
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
    }
}
