namespace Desafios_DotNet;

public class Desafios
{
    public static void Desafio1(string[] args)
    {
        //1) Escreva um programa que leia um número inteiro e informe se ele é par ou ímpar.
        Console.WriteLine("Digite um numero inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero % 2 == 0)
        {
            Console.WriteLine("O numero {0} é par!", numero);
        }
        else
        {
            Console.WriteLine("O numero {0} é ímpar!", numero);
        }
    }

    public static void Desafio2(string[] args)
    {
        //2) Escreva um programa que leia um número inteiro e informe se ele é positivo, negativo ou zero. 
        Console.WriteLine("Digite um numero inteiro: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        if (numero >= 1)
        {
            Console.WriteLine("O numero {0} é positivo!", numero);
        }
        else if(numero < 0)
        {
            Console.WriteLine("O numero {0} é negativo!", numero);
        }
        else
        {
            Console.WriteLine("O numero é {0}!", numero); 
        }
    }
    
    public static void Desafio3(string[] args)
    {
        //3) Escreva um programa que leia dois números inteiros e informe qual deles é o maior. 
        Console.Write("Digite o primeiro número inteiro: ");
        int numero1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Digite o segundo número inteiro: ");
        int numero2 = Convert.ToInt32(Console.ReadLine());

        if (numero1 > numero2)
        {
            Console.WriteLine("O maior número é: {0}", numero1);
        }
        else if (numero2 > numero1)
        {
            Console.WriteLine("O maior número é: {0}", numero2);
        }
        else
        {
            Console.WriteLine("Os números são iguais.");
        }
    }

    public static void Desafio4(string[] args)
    {
        //4) Escreva um programa que leia três lados de um triângulo e verifique se eles formam um triângulo válido. Para isso, a soma de dois lados deve ser sempre maior que o terceiro lado. 
        Console.Write("Digite o primeiro lado do triângulo: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo lado do triângulo: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o terceiro lado do triângulo: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        if (numero1 + numero2 > numero3 && numero1 + numero3 > numero2 && numero2 + numero3 > numero1)
        {
            Console.WriteLine("Os lados formam um triângulo válido.");
        }
        else
        {
            Console.WriteLine("Os lados não formam um triângulo válido.");
        }
    }
    public static void Desafio5(string[] args)
    {
        //5) Escreva um programa que leia três notas de um aluno e calcule a média. Informe se o aluno está aprovado (média >= 7), em recuperação (5 <= média < 7) ou reprovado (média < 5). 
        Console.Write("Digite a primeira nota: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a segunda nota: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a terceira nota: ");
        double numero3 = Convert.ToDouble(Console.ReadLine());

        double media = (numero1 + numero2 + numero3) / 3;

        Console.WriteLine("A média é: {0}", media);

        if (media >= 7)
        {
            Console.WriteLine("Aluno aprovado.");
        }
        else if (media >= 5 && media < 7)
        {
            Console.WriteLine("Aluno em recuperação.");
        }
        else
        {
            Console.WriteLine("Aluno reprovado.");
        }
    }

    public static void Desafio6(string[] args)
    {
        //6) Escreva um programa que leia um ano e verifique se ele é bissexto. Um ano é bissexto se for divisível por 4, mas não por 100, exceto se for divisível por 400. 
        Console.Write("Digite um ano: ");
        int ano = Convert.ToInt32(Console.ReadLine());

        if ((ano % 4 == 0 && ano % 100 != 0) || ano % 400 == 0)
        {
            Console.WriteLine("O ano é bissexto.");
        }
        else
        {
            Console.WriteLine("O ano não é bissexto.");
        }
    }

    public static void Desafio7(string[] args)
    {
        //7) Escreva um programa que leia a idade de uma pessoa e informe se ela é uma criança (0-12 anos), adolescente (13-17 anos), adulto (18-59 anos) ou idoso (60 anos ou mais). 
        Console.Write("Digite a idade: ");
        int idade = Convert.ToInt32(Console.ReadLine());

        if (idade >= 0 && idade <= 12)
        {
            Console.WriteLine("Criança");
        }
        else if (idade >= 13 && idade <= 17)
        {
            Console.WriteLine("Adolescente");
        }
        else if (idade >= 18 && idade <= 59)
        {
            Console.WriteLine("Adulto");
        }
        else if (idade >= 60)
        {
            Console.WriteLine("Idoso");
        }
        else
        {
            Console.WriteLine("Idade inválida.");
        }
    }

    public static void Desafio8(string[] args)
    {
        //8) Escreva um programa que leia a nota de um aluno e converta-a para conceito: A (nota >= 9), B (7 <= nota < 9), C (5 <= nota < 7), D (3 <= nota < 5) e F (nota < 3). 
        Console.Write("Digite a nota do aluno: ");
        double nota = Convert.ToDouble(Console.ReadLine());

        if (nota >= 9)
        {
            Console.WriteLine("A");
        }
        else if (nota >= 7)
        {
            Console.WriteLine("B");
        }
        else if (nota >= 5)
        {
            Console.WriteLine("C");
        }
        else if (nota >= 3)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }
    }

    public static void Desafio9(string[] args)
    {
        /*9)Escreva um programa que leia o código de um produto e informe a sua categoria: 
        1 a 10: Alimento não-perecível 
        11 a 20: Alimento perecível 
        21 a 30: Vestuário 
        31 a 40: Eletrônicos 
        Outros: Código inválido */
        
        Console.Write("Digite o código do produto: ");
        int codigo = Convert.ToInt32(Console.ReadLine());

        if (codigo >= 1 && codigo <= 10)
        {
            Console.WriteLine("Alimento não-perecível");
        }
        else if (codigo >= 11 && codigo <= 20)
        {
            Console.WriteLine("Alimento perecível");
        }
        else if (codigo >= 21 && codigo <= 30)
        {
            Console.WriteLine("Vestuário");
        }
        else if (codigo >= 31 && codigo <= 40)
        {
            Console.WriteLine("Eletrônicos");
        }
        else
        {
            Console.WriteLine("Código inválido.");
        }
    }

    public static void Desafio10(string[] args)
    {
        //10) Escreva um programa que leia dois números e uma operação (adição, subtração, multiplicação ou divisão) e realize a operação correspondente. 
        Console.Write("Digite o primeiro número: ");
        double numero1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        double numero2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a operação (+, -, *, /): ");
        char operacao = Convert.ToChar(Console.ReadLine());

        double resultado;

        switch (operacao)
        {
            case '+':
                resultado = numero1 + numero2;
                break;
            case '-':
                resultado = numero1 - numero2;
                break;
            case '*':
                resultado = numero1 * numero2;
                break;
            case '/':
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    Console.WriteLine("Divisão por zero.");
                    return;
                }
                break;
            default:
                Console.WriteLine("Operação inválida.");
                return;
        }

        Console.WriteLine("O resultado da operação é: {0}", resultado);
    }

    public static void Desafio11(string[] args)
    {
        //11) Escreva um programa que leia um número e verifique se ele está no intervalo de 10 a 20 (inclusive). 
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero >= 10 && numero <= 20)
        {
            Console.WriteLine("O número está no intervalo de 10 a 20.");
        }
        else
        {
            Console.WriteLine("O número não está no intervalo de 10 a 20.");
        }
    }

    public static void Desafio12(string[] args)
    {
        //12) Escreva um programa que leia um número e verifique se ele é maior que 100. Se não for, informe o dobro desse número. 
        Console.Write("Digite um número: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero > 100)
        {
            Console.WriteLine("O número é maior que 100.");
        }
        else
        {
            Console.WriteLine("O dobro do número é: {0}", (numero * 2));
        }
    }

    public static void Desafio13(string[] args)
    {
        /*13) Escreva um programa que leia o valor de uma compra e a categoria do cliente (1 para comum, 2 para associado e 3 para VIP). Aplique os seguintes descontos: 
        Comum: Sem desconto 
        Associado: 10% de desconto 
        VIP: 20% de desconto 
        Informe o valor final da compra. */
        
        Console.Write("Digite o valor da compra: ");
        double valorCompra = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Categoria do cliente:");
        Console.WriteLine("1 - Comum");
        Console.WriteLine("2 - Associado");
        Console.WriteLine("3 - VIP");
        int categoria = Convert.ToInt32(Console.ReadLine());

        double valorFinal;

        switch (categoria)
        {
            case 1:
                valorFinal = valorCompra;
                break;
            case 2:
                valorFinal = valorCompra * 0.90;
                break;
            case 3:
                valorFinal = valorCompra * 0.80;
                break;
            default:
                Console.WriteLine("Categoria inválida.");
                return;
        }

        Console.WriteLine("O valor final da compra é: {0}", valorFinal);
    }

    public static void Desafio14(string[] args)
    {
        //14) Escreva um programa que leia um número e informe se ele é positivo ou negativo. Se for positivo, calcule a raiz quadrada; se for negativo, informe o número ao quadrado. 
        Console.Write("Digite um número: ");
        double numero = Convert.ToDouble(Console.ReadLine());

        if (numero >= 0)
        {
            Console.WriteLine("A raiz quadrada do número é: {0}", Math.Sqrt(numero));
        }
        else
        {
            Console.WriteLine("O quadrado do número é: {0}", (numero * numero));
        }
    }

    public static void Desafio15(string[] args)
    {
        /*15) Escreva um programa que leia o peso e a altura de uma pessoa, calcule o IMC e informe a categoria: 
        Abaixo do peso: IMC < 18.5 
        Peso normal: 18.5 <= IMC < 24.9 
        Sobrepeso: 25 <= IMC < 29.9 
        Obesidade grau I: 30 <= IMC < 34.9 
        Obesidade grau II: 35 <= IMC < 39.9 
        Obesidade grau III: IMC >= 40 */
        
        Console.Write("Digite o peso (kg): ");
        double peso = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite a altura (m): ");
        double altura = Convert.ToDouble(Console.ReadLine());

        double imc = peso / (altura * altura);

        Console.WriteLine("O IMC é: {0}", imc);

        if (imc < 18.5)
        {
            Console.WriteLine("Abaixo do peso");
        }
        else if (imc < 24.9)
        {
            Console.WriteLine("Peso normal");
        }
        else if (imc < 29.9)
        {
            Console.WriteLine("Sobrepeso");
        }
        else if (imc < 34.9)
        {
            Console.WriteLine("Obesidade grau I");
        }
        else if (imc < 39.9)
        {
            Console.WriteLine("Obesidade grau II");
        }
        else
        {
            Console.WriteLine("Obesidade grau III");
        }
    }
}