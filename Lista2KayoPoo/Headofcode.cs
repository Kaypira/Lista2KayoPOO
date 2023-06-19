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
     
        
    }
}