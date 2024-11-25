using System.Diagnostics;
using System.Reflection.Metadata;

Console.WriteLine("Press 1 to: Rotate text");
Console.WriteLine("Press 2 to: Change Word");

var input1 = Console.ReadLine();
int inputInt =int.Parse(input1);

switch (inputInt)
{
    case 1:
        Console.WriteLine("Skriv et ord");

        string wordInput = Console.ReadLine();

        char[] charArr = wordInput.ToCharArray();
        Array.Reverse(charArr);

        Console.WriteLine(new string(charArr));
        break;
    case 2:
        Console.WriteLine("Skriv et ord");
        string wordInput2 = Console.ReadLine();
        char[] changeWord =  wordInput2.ToCharArray();

        for (int i = 0; i < changeWord.Length; i++)
        {
            if (changeWord[i] == 'e')
            {
                changeWord[i] = 'a';
            }
        }
        Console.WriteLine(new string (changeWord));
       // return new string (bytteTekst);
        break;
}

