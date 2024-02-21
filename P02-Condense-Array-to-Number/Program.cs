List<int> input = Console.ReadLine()
                   .Split(" ")
                   .Select(int.Parse)
                   .ToList();


while (input.Count > 1)
{
    List<int> output = new List<int>();

    for (int i = 0; i < input.Count - 1; i++)
    {
        int numb1 = input[i];
        int numb2 = input[i + 1];
        int sum = numb1 + numb2;
        output.Add(sum);
    }
    input = output;
}

Console.WriteLine(input[0]);
