namespace TestProject.Ejercicios

{
    public class CaraSeca
    {
        public static void Test()
        {
            Random coin = new Random();
            int flip = coin.Next(0, 2);
            Console.WriteLine((flip == 0) ? "heads" : "tails");
        }
    }
}
