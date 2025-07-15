using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Reference reference = new Reference("2 Nephi", 8, 3);
        Scripture scripture = new Scripture(reference, "For the Lord shall comfort Zion, he will comfort all her waste places; and he will make her wilderness like Eden, and her desert like the garden of the Lord. Joy and gladness shall be found therein, thanksgiving and the voice of melody.");

        while (true)
        {
            if (scripture.IsCompletelyHidden())
            {
                break;
            }
            else
            {
                Console.WriteLine("Scripture Memorizer Program");
                Console.WriteLine($"{scripture.GetDisplayText()}");
                Console.Write("Press enter to hide words or type quit to end program: ");
                string cont = Console.ReadLine();
                if (cont == "")
                {
                    Console.Clear();
                    scripture.HideRandomWords(4); // is getting stuck because it runs out of words to hide
                }
                else if (cont == "quit")
                {
                    break;
                }
                else
                {
                    continue;
                }
            }
        }
    }
}