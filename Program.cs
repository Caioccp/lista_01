Console.Write("Informe o primeiro valor: ");
int valor1 = int.Parse(Console.ReadLine()!);

Console.Write("Informe o segundo valor: ");
int valor2 = int.Parse(Console.ReadLine()!);

Console.Write("Informe o terceiro valor: ");
int valor3 = int.Parse(Console.ReadLine()!);

Console.Write("Informe o quarto valor: ");
int valor4 = int.Parse(Console.ReadLine()!);

Console.Write("Informe o quinto valor: ");
int valor5 = int.Parse(Console.ReadLine()!);

int soma = valor1 + valor2 + valor3 + valor4 + valor5;
double media = soma / 5.0;

Console.WriteLine($"Soma dos valores: {soma}");
Console.WriteLine($"Média dos valores: {media}");