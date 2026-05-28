

namespace myfirstapplication;

internal class Exercise4
{
    public void Strings(string first, string second)
    {
        if (first == second)
        {
            Console.WriteLine("The strings are equal.");
        }
        else
        {
            Console.WriteLine("The strings are not equal");
        }
    }

    public string Grades(char grade)
    {
        return grade switch
        {
            'e' => "excellent",
            'v' => "very good",
            'g' => "good",
            'a' => "average",
            'f' => "fail",
            _ => "not a valid grade"
        };
    }

    public void displayThree()
    {
        for (int i = 0; i <= 30; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine(i);
            }
        }

    }
}

