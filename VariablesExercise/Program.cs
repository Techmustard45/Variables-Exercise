namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string name = "Elias";
            int age = 21;
            char inital = 'E';
            bool isTrue = false;
            double randNum = 12.65;
            decimal randNum2 = 23.345m;

            Console.WriteLine("Hello! My name is " + name + " and I'm " + age + " years old. My name begins with an " + inital + ". The statement \"Could I think of anything else to write\" is " + isTrue + ". Here are some numbers: " + randNum + " and " + randNum2 + ".");
        }
    }
}
