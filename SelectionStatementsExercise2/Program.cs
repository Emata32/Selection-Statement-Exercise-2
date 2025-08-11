namespace SelectionStatementsExercise2
{
    public class Program
    {
        public static void FavSubject()
        {
            Console.WriteLine("What is your favorite school subject? ");
            string Subject = Console.ReadLine();

            switch (Subject.ToLower())
            {
                case "art":
                    Console.WriteLine("Why did the painter go to jail? Because they were framed..");
                    break;
                case "music":
                    Console.WriteLine("What kind of music are balloons afraid of?...Pop music.");
                    break;
                case "math":
                    Console.WriteLine("How dose a mathematician plow fields?...With a pro-tractor.");
                    break;
                case "science":
                    Console.WriteLine("What did one ion say to another ion?...I've got my ion you.");
                    break;
                
                default:
                    Console.WriteLine("That's a great subject ");
                    break;
            }
        }
        static void Main(string[] args)
        {
            FavSubject();
            
        }
    }
}