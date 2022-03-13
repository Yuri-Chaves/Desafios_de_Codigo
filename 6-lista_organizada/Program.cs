var totalDeCasosDeTeste = int.Parse(Console.ReadLine());


for (int i = 0; i < totalDeCasosDeTeste; i++)
{
    string[] produtos = Console.ReadLine().Split(" ");
    Array.Sort(produtos);
    var distinta = produtos.Distinct();
    var linha = string.Join(" ", distinta);
    Console.WriteLine(linha);
}
Console.ReadKey();