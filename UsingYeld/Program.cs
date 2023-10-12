
var numbers = GetEvenNumbers(1000000000); //1 Bilion

foreach (var number in numbers)
{
    Console.WriteLine(number);
}

static IEnumerable<int> GetEvenNumbers(int max)
{
    //List<int> numbers = new List<int>();

    for (int i = 0; i < max; i++)
    {
        if(i % 2 == 0)
        {
            //numbers.Add(i);
            yield return i;
        }
    }

    //return numbers;
}