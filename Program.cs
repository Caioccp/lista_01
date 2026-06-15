Console.Write("Informe o valor total da compra: ");
int valorCompra = int.Parse(Console.ReadLine()!);

double desconto = 0;
double valorFinal = valorCompra;

if (valorCompra >= 200)
{
    desconto = valorCompra * 0.10;
    valorFinal = valorCompra - desconto;
}

Console.WriteLine($"Valor original: R$ {valorCompra}");
Console.WriteLine($"Desconto aplicado: R$ {desconto}");
Console.WriteLine($"Valor final: R$ {valorFinal}");