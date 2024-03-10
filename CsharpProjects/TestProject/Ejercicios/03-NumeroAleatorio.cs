namespace TestProject.Ejercicios

{
  public class NumeroAleatorio
  {
    public static void Test()
    {
      Random dice = new Random();
      int roll1 = dice.Next(); // Retorna un valor entre 0 y 2,147,483,647 (valor máximo de int)
      int roll2 = dice.Next(101); // Retorna un valor entre 0 y 100
      int roll3 = dice.Next(50, 101); // Retorna un valor entre 50 y 100

      Console.WriteLine($"First roll: {roll1}");
      Console.WriteLine($"Second roll: {roll2}");
      Console.WriteLine($"Third roll: {roll3}");
    }
  }
}
