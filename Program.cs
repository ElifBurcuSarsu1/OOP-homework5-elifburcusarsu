
int count = 0;
int sum = 0;
int highest = 0;
int lowest = 0;

while (true)
{
    Console.Write("Enter a grade (-1 to finish): ");
    int grade = int.Parse(Console.ReadLine());

    if (grade == -1)
    {
        break;
    }

    if (count == 0)
    {
        highest = grade;
        lowest = grade;
    }

    if (grade > highest)
    {
        highest = grade;
    }

    if (grade < lowest)
    {
        lowest = grade;
    }

    sum += grade;
    count++;
}

if (count > 0)
{
    double average = (double)sum / count;

    Console.WriteLine($"Count: {count}");
    Console.WriteLine($"Sum: {sum}");
    Console.WriteLine($"Average: {average}");
    Console.WriteLine($"Highest: {highest}");
    Console.WriteLine($"Lowest: {lowest}");
}
else
{
    Console.WriteLine("No grades entered.");
}

