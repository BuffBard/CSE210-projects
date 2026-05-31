using System;

class Program
{
    static void Main(string[] args)
    {
//         VerseReference reference=new VerseReference("John", 3, 16);
//         Scripture scripture=new Scripture(reference,
// "For God so loved the world, that he gave his only begotten Son.");
        VerseReference reference=new VerseReference("Jacob", 6, 12, 13);
        Scripture scripture=new Scripture(reference,
"O be wise; what can I say more? Finally, I bid you farewell, until I shall meet you before the pleasing bar of God, which bar striketh the wicked with awful dread and fear. Amen.");
        while (!scripture.IsFullyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine();
            Console.Write("Press Enter or type quit: ");
            string input = Console.ReadLine();

            if(input.ToLower()=="quit")
            {
                return;
            }

            scripture.HideRandomWords(3);
        }
        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());
        Console.WriteLine();
        Console.Write("Press Enter to quit: ");
        Console.ReadLine();
    }
}