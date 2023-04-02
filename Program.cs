double valor1, valor2, troco;
Console.Write("Digite o valor de compra: ");
valor1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Digite o valor pago: ");
valor2 = Convert.ToDouble(Console.ReadLine());

troco = valor1 - valor2;

Console.WriteLine($"Valor do troco: {troco:N2}");
