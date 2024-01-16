// See https://aka.ms/new-console-template for more information
Console.WriteLine("Bem Vindo a Academia X, melhor academia do seu bairro!!");

Console.WriteLine("Para iniciarmos, precisamos fazer um simples cadastro, por isso irei solicitar algumas informacoes basicas");

Console.WriteLine("Peço que iniciei digitando o seu nome!!");

string nome;

nome = Console.ReadLine();

Console.WriteLine("Olá " + nome + "!!");

Console.WriteLine(nome + ", agora nos informe a sua idade, sexo, peso e altura...");

Console.WriteLine("Qual a sua idade?");

int idade;

idade = int.Parse(Console.ReadLine());

Console.WriteLine("Qual o seu sexo?");

string sexo;

sexo = Console.ReadLine();

Console.WriteLine("Digite agora o seu peso");

decimal peso;

peso = decimal.Parse(Console.ReadLine());

Console.WriteLine("Digite agora a sua altura");

decimal altura;

altura = decimal.Parse(Console.ReadLine());

Console.WriteLine("Perfeito " + nome + "!!");

Console.Clear();

string imc = (peso / (altura * altura)).ToString("F2");

Console.WriteLine("Segue o seu cadastro completo para análise:");

Console.WriteLine("Seu nome é " + nome);
Console.WriteLine("Você é do sexo " + sexo + " e tem " + idade + " anos");
Console.WriteLine("Pesa " + peso + " Kgs e ");
Console.WriteLine("Tem " + altura + "m de altura");
Console.WriteLine("Por fim o seu IMC é: " + imc + "!!");

Console.WriteLine("Um IMC elevado neh...");

Console.WriteLine("Vamos fechar um plano?");