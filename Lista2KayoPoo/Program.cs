// nivel 1 


using Classes;
namespace Mofi2
{


    public class mofao
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Digite o exercicio que voce quer iniciar "); int opcao = int.Parse(Console.ReadLine());
            Mofi Mofi = new Mofi();
            switch (opcao)
            {
                case 1:
                    Console.WriteLine(Mofi.exercicio1());
                    break;
                case 2:
                    Console.WriteLine(Mofi.exercicio2());
                    break;
                case 3:
                    Console.WriteLine(Mofi.exercicio3());
                    break;
                case 4:
                    Console.WriteLine(Mofi.exercicio4());
                    break;
                case 5:
                    Console.WriteLine(Mofi.exercicio5());
                    break;
                case 6:
                    Console.WriteLine(Mofi.exercicio6());
                    break;
                case 7:
                    Console.WriteLine(Mofi.exercicio7());
                    break;
                case 8:
                    Console.WriteLine(Mofi.exercicio8());
                    break;
                case 9:
                    Console.WriteLine(Mofi.exercicio9());
                    break;
                case 10:
                    Console.WriteLine(Mofi.exercicio10());
                    break;
                case 11:
                    Console.WriteLine(Mofi.exercicio11());
                    break;
                case 12:
                    Console.WriteLine(Mofi.exercicio12());
                    break;
                case 13:
                    Console.WriteLine(Mofi.exercicio13());
                    break;
                case 14:
                    Console.WriteLine(Mofi.exercicio14());
                    break;
                case 15:
                    Console.WriteLine(Mofi.exercicio15());
                    break;
                case 16:
                    Console.WriteLine(Mofi.exercicio16());
                    break;















            }
        }
    }
}
