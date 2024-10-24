using System.Collections.Generic;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts;
    private static Random rand = new Random();

    public ListingActivity() : base("Listing Activity", "This activity helps you focus on the good things in your life by making you list as many items as you can in a given area.")
    {
        _prompts = new List<string>
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people you have helped recently?",
            "Who are your personal heroes?"
        };
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("List based on the following prompt:");
        Console.WriteLine(GetRandomPrompt());
        ShowSpinner(3); // Give the user time to think

        List<string> userList = GetListFromUser();
        _count = userList.Count;
        Console.WriteLine($"You listed {_count} items.");

        DisplayEndingMessage();
    }

    private string GetRandomPrompt()
    {
        return _prompts[rand.Next(_prompts.Count)];
    }

    private List<string> GetListFromUser()
    {
        List<string> userList = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)
        {
            Console.Write("Enter an item: ");
            string item = Console.ReadLine();
            if (!string.IsNullOrEmpty(item))
            {
                userList.Add(item);
            }
        }

        return userList;
    }
}
