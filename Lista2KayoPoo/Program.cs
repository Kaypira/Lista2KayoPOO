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











            }
        }
    }
}