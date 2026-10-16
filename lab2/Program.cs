/*question 1
while (true)
{
    Console.WriteLine("Enter a score: ");
    int score = int.Parse(Console.ReadLine());
    if (score > 100)
    {
        Console.WriteLine("Invalid score");
        continue;
    }
    if(score<0)
    {
        Console.WriteLine("Invalid score");
        continue;
    }

    if(score>= 90 && score <= 100)
    {
        Console.WriteLine($"Score:{score}    A");
    }
    else if(score>= 80 && score < 89)
    {
        Console.WriteLine($"Score:{score}    B");
    }
    else if (score >= 70 && score < 79)
    {
        Console.WriteLine($"Score:{score}    C");
    }
    else if (score>= 60 && score < 70)
    {
        Console.WriteLine($"Score:{score}    D    ");
    }
    else if(score < 60)
    {
        Console.WriteLine("Grade: F");
    }
}
*/
/*question 2
int num = 1;
int sum = 0;
int count = -1;

while (num != 0)
{
    Console.Write("Number (0 to stop) : ");
    num = int.Parse(Console.ReadLine());
    sum += num;
    count++;
}

double avg = sum / count;
Console.WriteLine($"Count : {count}, Sum : {sum}, Average : {avg:f2}");
*/