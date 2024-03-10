namespace TestProject.Ejercicios

{
  public class CicloFor
  {
    public static void Test()
    {
      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(i);
      }

      for (int i = 10; i >= 0; i--)
      {
        Console.WriteLine(i);
      }

      for (int i = 0; i < 10; i += 3)
      {
        Console.WriteLine(i);
      }

      for (int i = 0; i < 10; i++)
      {
        Console.WriteLine(i);
        if (i == 7) break;
      }

      // Recorrer todos los elementos de un arreglo
      string[] names = { "Alex", "Eddie", "David", "Michael" };
      for (int i = names.Length - 1; i >= 0; i--)
      {
        Console.WriteLine(names[i]);
      }

      // Variante abreviada
      for (int i = 0; i < names.Length; i++)
        if (names[i] == "David") names[i] = "Sammy";

      foreach (var name in names) Console.WriteLine(name);

      // Variante con llaves
      for (int i = 0; i < names.Length; i++)
      {
        if (names[i] == "David")
        {
          names[i] = "Sammy";
        }
      }

      foreach (var name in names)
      {
        Console.WriteLine(name);
      }
    }
  }
}
