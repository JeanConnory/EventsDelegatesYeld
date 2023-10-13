
#region Delegate

//int resultado;
////resultado = CalculaMedia(2, 6);

////Funcao funcao = new Funcao(CalculaMedia);
//Funcao funcao = CalculaMedia; //Mais simples, só chamando a função direto

//resultado = funcao(8, 4);
//Console.WriteLine($"Média: {resultado}");

//funcao = CalculaMultiplicacao;
//resultado = funcao(4, 6);
//Console.WriteLine($"Multiplicação: {resultado}");

//static int CalculaMedia(int p1, int p2)
//{
//    int media;
//    media = (p1 + p2) / 2;
//    return media;
//}

//static int CalculaMultiplicacao(int p1, int p2)
//{
//    int mult;
//    mult = p1 * p2;
//    return mult;
//}

//delegate int Funcao(int a, int b);

#endregion

#region Func

//float media;
////media = CalculaMedia(3, 5);

//defFuncDelegate f;
//f = CalculaMedia;
//media = f(8, 10);

//defFuncDelegateGenerico<int, int, float> f1;
//f1 = CalculaMedia;
//media = f1(5, 9);

//Func<int, int, float> f2; //Forma mais fácil e padrão de usar
//f2 = CalculaMedia;
//media = f2(6, 4);

//Console.WriteLine($"Média: {media}");

//static float CalculaMedia(int p1, int p2)
//{
//    int media;
//    media = (p1 + p2) / 2;
//    return media;
//}

//delegate float defFuncDelegate(int p1, int p2);

//delegate TResult defFuncDelegateGenerico<in T1, in T2, out TResult>(T1 p1, T2 p2);

#endregion

#region Predicate

//bool resultado;
////resultado = DeterminaNumeroPar(2);

//Predicate<int> p;
//p = DeterminaNumeroPar;
////resultado = p(2);
////Console.WriteLine($"Resultado: {resultado}");

//List<int> listaCompleta = new List<int>
//{
//    10,
//    11,
//    12,
//    13,
//    14,
//    15
//};

//List<int> listaDosPares = new List<int>();
//listaDosPares = listaCompleta.FindAll(p);

//ImprimeLista(listaDosPares);

//static bool DeterminaNumeroPar(int num)
//{
//    return num % 2 == 0;
//}

//static void ImprimeLista(List<int> lista)
//{
//    for (int i = 0; i < lista.Count; i++)
//    {
//        Console.WriteLine(lista[i]);
//    }
//}

////delegate bool Predicate(int num);

////delegate bool Predicate<in T>(T num); Já existe um Predicate padrão

#endregion

#region Action

Action<int, int> p;
p = CalculaMedia;
p(3, 7);


static void CalculaMedia(int p1, int p2)
{
    int media;
    media = (p1 + p2) / 2;
    Console.WriteLine(media);
}

//delegate void Action<in T1, in T2>(T1 a, T2 b); //Usando Action Generic e Action já existe na linguagem

#endregion