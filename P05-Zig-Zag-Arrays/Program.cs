int count = int.Parse(Console.ReadLine());

List<int> firstList = new List<int>();
List<int> secondList = new List<int>();

for (int i = 0; i < count; i++)
{
    List<int> numbers = Console.ReadLine()
                     .Split(" ")
                     .Select(int.Parse)
                     .ToList();
    int numb1 = numbers[0];
    int numb2 = numbers[1];

    if (i % 2 == 0)
    {
        firstList.Add(numb1);
        secondList.Add(numb2);
    }
    else
    {
        firstList.Add(numb2);
        secondList.Add(numb1);
    }
}

Console.WriteLine(string.Join(" ", firstList));
Console.WriteLine(string.Join(" ", secondList));
