
var tamanho baralho = 50;
List<int> baralho = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52 };



List<int> embaralhar(List<int> baralho)
{
    return baralho.OrderBy(x => Random.Next()).ToList();
}
int darCartas(List<int> baralho)
{
    int posicaoPrimeiraCarta = baralho[0];
    int carta = baralho[posicaoPrimeiraCarta];
    baralho.RemoveAt(posicaoPrimeiraCarta);
    return carta;

}
var rand = new Random();


var carta1 = 0;
int carta2 = 0;

var jogador1 = rand.Next(1, 53);
var jogador2 = rand.Next(1, 53);

if (jogador1 > jogador2)
{
    Console.WriteLine("Jogador 1 ganhou");
}
else if (jogador1 < jogador2)
{

    Console.WriteLine("jogador 2 ganhou");
}
else
{
    Console.WriteLine("Empate!");
}
Console.ReadKey();