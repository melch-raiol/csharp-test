// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Escreva seu nome :");
string name = Console.ReadLine();

Console.WriteLine("digite seu peso:"); 
double weight = double.Parse(Console.ReadLine());
       
Console.WriteLine("digite sua altura:"); 
double height = double.Parse(Console.ReadLine());

double bmi = weight / (height * height);
Console.WriteLine("olá, " + name);
Console.WriteLine("seu imc é: " + bmi);
