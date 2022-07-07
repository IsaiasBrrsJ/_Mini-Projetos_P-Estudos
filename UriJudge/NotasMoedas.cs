// moedas
double valor = double.Parse(Console.ReadLine().Replace(",", "."));
int resultado = 0;
int[] cedulas = { 100, 50, 20, 10, 5, 2 };
double[] moedas = { 1, 0.50, 0.25, 0.10, 0.05, 0.01 };

Console.WriteLine("NOTAS:");
for (int i = 0; i < cedulas.Length; i++)
{
    resultado = (int)valor / cedulas[i];
    Console.WriteLine($"{resultado} nota(s) de R$ {cedulas[i]}");
    valor -= resultado * cedulas[i];
}
Console.WriteLine("MOEDAS:");
for (int i = 0; i < moedas.Length; i++)
{
    string moeda = moedas[i].ToString("N2");
    resultado = (int)(Math.Round(valor, 2) / moedas[i]);
    Console.WriteLine($"{resultado} Moeda(s) de R$ {moeda}");
    valor -= (double)(resultado * moedas[i]);
}
