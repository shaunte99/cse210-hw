using System;

class Program  
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Ruth", 1, 16, 17);
        string text = "And Ruth said, Intreat me not to leave thee, or to return from following after thee: " +
                      "for whither thou goest, I will go; and where thou lodgest, I will lodge: " +
                      "thy people shall be my people, and thy God my God. " +
                      "Where thou diest, will I die, and there will I be buried: " +
                      "the Lord do so to me, and more also, if ought but death part thee and me.";

    
        Scripture scripture = new Scripture(reference, text);

        
        while (true)
        {
        
            scripture.Display();

    
            if (scripture.AreAllWordsHidden())
            {
                Console.WriteLine("Good job!! you have memorized your scripture");
                break;
            }

            
            Console.WriteLine("Press Enter to hide words or type \"quit\" to exit");
            string input = Console.ReadLine();

            if (input.ToLower() == "quit")
            {
                Console.WriteLine("Goodbye!");
                break;
            }

            
            scripture.HideRandomWords(3);
        }
    }
}
