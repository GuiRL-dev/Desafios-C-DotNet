namespace Desafios_DotNet;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Instituti PROA - Equipe 2");
        Console.WriteLine("Bem vindo! \n Esses são desafios DotNet propostos pelo professor Jailson!");
        Thread.Sleep(10000);
        Console.Clear();
        Console.WriteLine("Escolha um Desafio: \n");
        Console.WriteLine("1 - Par ou Ímpar");
        Console.WriteLine("2 - Positivo ou Negativo");
        Console.WriteLine("3 - Numero Maior");
        Console.WriteLine("4 - Fazer um Triangulo");
        Console.WriteLine("5 - Media");
        Console.WriteLine("6 - Ano Bissexto");
        Console.WriteLine("7 - Idade Pessoa");
        Console.WriteLine("8 - Nota Aluno");
        Console.WriteLine("9 - Categoria de produto");
        Console.WriteLine("10 - Realizar Operação");
        Console.WriteLine("11 - Intervalo de numero");
        Console.WriteLine("12 - Maior que 100 ou Dobro");
        Console.WriteLine("13 - Desconto");
        Console.WriteLine("14 - Positivo negativo raiz");
        Console.WriteLine("15 - IMC");

        int numero = Convert.ToInt32(Console.ReadLine());
        
        switch (numero)
        {
            case 1:
                Console.Clear();
                Desafios.Desafio1(args);
                break;
            case 2:
                Console.Clear();
                Desafios.Desafio2(args);
                break;
            case 3:
                Console.Clear();
                Desafios.Desafio3(args);
                break;
            case 4:
                Console.Clear();
                Desafios.Desafio4(args);
                break;
            case 5:
                Console.Clear();
                Desafios.Desafio5(args);
                break;
            case 6:
                Console.Clear();
                Desafios.Desafio6(args);
                break;
            case 7:
                Console.Clear();
                Desafios.Desafio7(args);
                break;
            case 8:
                Console.Clear();
                Desafios.Desafio8(args);
                break;
            case 9:
                Console.Clear();
                Desafios.Desafio9(args);
                break;
            case 10:
                Console.Clear();
                Desafios.Desafio10(args);
                break;
            case 11:
                Console.Clear();
                Desafios.Desafio11(args);
                break;
            case 12:
                Console.Clear();
                Desafios.Desafio12(args);
                break;
            case 13:
                Console.Clear();
                Desafios.Desafio13(args);
                break;
            case 14:
                Console.Clear();
                Desafios.Desafio14(args);
                break;
            case 15:
                Console.Clear();
                Desafios.Desafio15(args);
                break;
            default:
                Console.WriteLine("Esse não é um desafio válido.");
                break;
        }
    }
}