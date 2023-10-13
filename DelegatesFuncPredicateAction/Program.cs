
int resultado;
//resultado = CalculaMedia(2, 6);

//Funcao funcao = new Funcao(CalculaMedia);
Funcao funcao = CalculaMedia; //Mais simples, só chamando a função direto

resultado = funcao(8, 4);
Console.WriteLine($"Média: {resultado}");

funcao = CalculaMultiplicacao;
resultado = funcao(4, 6);
Console.WriteLine($"Multiplicação: {resultado}");

static int CalculaMedia(int p1, int p2)
{
    int media;
    media = (p1 + p2) / 2;
    return media;
}

static int CalculaMultiplicacao(int p1, int p2)
{
    int mult;
    mult = p1 * p2;
    return mult;
}

delegate int Funcao(int a, int b);