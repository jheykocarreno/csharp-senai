// ------------------------------- Funções -------------------------------

// --------- Fundamentais ---------
//1- Função de Soma

using System.Diagnostics;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
/*
static int soma()
{
    Console.WriteLine("Ingressa o primeiro numero: ");
    int i = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Ingressa o segundo numero: ");
    int j = Convert.ToInt32(Console.ReadLine());

    return i + j;
}

Console.WriteLine($"O total é {soma()}");
*/

//2- Função de Média
/*
List<double> notas = new List<double>();

Console.WriteLine("Quantas notas são: ");
int qtd = Convert.ToInt32(Console.ReadLine());

double promedio = media(notas, qtd);
Console.WriteLine(promedio);

static double media (List<double> list, int qtd)
{
    double sumaNotas = 0;
    for (int i = 0; i < qtd; i++)
    {
        Console.WriteLine($"Inserir nota {i+1}: ");
        list.Add(Convert.ToDouble(Console.ReadLine()));
        sumaNotas += list[i];
    }

    double promedio = sumaNotas / qtd;
    return promedio;
}
*/

//3-Função de Par ou Ímpar
/*
Console.WriteLine("Escreve um numero");
int numero = Convert.ToInt32(Console.ReadLine());

parImpar(numero);

static void parImpar(int numero)
{
    if (numero % 2 == 0)
    {
        Console.WriteLine("Numero par");
    }
    else
    {
        Console.WriteLine("Numero impar");
    }
}
*/

// --------- Intermediários ---------
//1- Função de Fatorial
/*
Console.WriteLine("Escreve um numero");
int numero = Convert.ToInt32(Console.ReadLine());
int fact = Convert.ToInt32(factorial(numero));

Console.WriteLine($"O factorial desse numero é: {fact}");

static int factorial(int numero)
{
    int fact = 1;
    
    if (numero != 0)
    {
        for (int i = 1; i <= numero; i++)
        {
            fact *= i;
        }
    }
    return fact;
}
*/

//2- Função para Inverter String
/*
Console.WriteLine("Qual é seu nome?");
String nome = Console.ReadLine();

Console.WriteLine(inverter(nome));

static string inverter (string nome)
{
    var nomeChar = nome.ToCharArray();
    string nomeInvertido = "";

    for (int i = nomeChar.Length; i> 0; i--)
    {
        nomeInvertido = nomeInvertido + nomeChar[i-1];
    }

    //tambem conseguimos fazer assim
    //foreach (char letra in nomeInvertido.Reverse()) 
    //{
    //    Console.WriteLine(letra);
    //}

    return nomeInvertido;
}
*/

//3- Função para Contar Vogais
/*
Console.WriteLine("Ingressar palavra ou frasse");
string palavra = Console.ReadLine().ToUpper();

Console.WriteLine(contarVogais(palavra));

static int contarVogais(string palavra)
{
    int contador = 0;

    var palavraChar = palavra.ToCharArray();

    for (int i = palavraChar.Length; i > 0; i--)
    {
        if (palavraChar[i - 1] == 'A') contador++;
        if (palavraChar[i - 1] == 'E') contador++;
        if (palavraChar[i - 1] == 'I') contador++;
        if (palavraChar[i - 1] == 'O') contador++;
        if (palavraChar[i - 1] == 'U') contador++;
    }

    return contador;
}
*/

// --------- Avançados ---------
//1- Função para Verificar Número Primo
/*
Console.WriteLine("Ingressar numero para conhecer se é numero primo");
int numero = Convert.ToInt32(Console.ReadLine());

numeroPrimo(numero);

static void numeroPrimo(double numero)
{
    double aux;
    bool ePrimo = false;

    for (int i = 2;  i < numero; i++)
    {
        aux = numero % i;

        if (aux == 0)
        {
            ePrimo = true;
            break;
        }
    }
    if (ePrimo) {
        Console.WriteLine("Não é numero primo");
    }
    else
    {
        Console.WriteLine("É numero primo");
    }
}
*/

//2- Função de Busca em Array
/*Console.WriteLine("Ingressar palavra");
string palavra = Console.ReadLine();

Console.WriteLine("Ingrese um numero");
int numero = Convert.ToInt32(Console.ReadLine());

*/

//3- Função Recursiva para Fibonacci

Console.WriteLine("Ingresse a possicao Fibonacci que quer conhecer");
int pos = int.Parse(Console.ReadLine());

int resultado = fibonacci(pos);

//Console.WriteLine(resultado);



static void fibonacci(int possicao)
{
    int fib = 0;
    int ant = 0;
    int aux = 0;

    for (int i = 1; i <= possicao; i++)
    {
        if (i <= 2)
        {
            fib = 1;
            ant = fib;
            Console.WriteLine($"{fib}, ");
        }
        else
        {
            aux = fib;
            fib = fib + ant;
            ant = aux;
            Console.WriteLine($"{fib}, ");
        }
    }
    //Console.WriteLine(fib);
}