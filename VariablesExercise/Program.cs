namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Johnny";
            int numberOfApples = 5;
            char newPencils = '9';
            bool likesSchool = true;
            double hisClassmates = 30;
            decimal amountOfMoney = 15.55m;

            Console.WriteLine($"My son {firstName} has {numberOfApples} apples " +
                              $"for his school lunches this week.");
            Console.WriteLine($"He is excited to go back on Monday, {likesSchool}, but he is nervous because he " +
                              $"wanted to bring a new pencil for his {hisClassmates} classmates.");
            Console.WriteLine($"Unfortunately, he only has {newPencils} left to hand out.");
            Console.WriteLine($"He could spend his ${amountOfMoney} to buy more.");
        }
    }
}
    
