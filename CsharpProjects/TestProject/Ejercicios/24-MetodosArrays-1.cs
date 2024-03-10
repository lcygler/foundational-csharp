namespace TestProject.Ejercicios

{
  public class MetodosArrays1
  {
    public static void Test()
    {
      /* ---------------------------------- Sort ---------------------------------- */

      string[] pallets = { "B14", "A11", "B12", "A13" };

      Console.WriteLine("Sorted...");
      Array.Sort(pallets);
      foreach (var pallet in pallets)
      {
        Console.WriteLine($"-- {pallet}");
      }

      /* --------------------------------- Reverse -------------------------------- */

      Console.WriteLine("");
      Console.WriteLine("Reversed...");
      Array.Reverse(pallets);
      foreach (var pallet in pallets)
      {
        Console.WriteLine($"-- {pallet}");
      }

      /* ---------------------------------- Clear --------------------------------- */

      Array.Clear(pallets, 0, 2);
      Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
      foreach (var pallet in pallets)
      {
        Console.WriteLine($"-- {pallet}");
      }

      /* --------------------------------- Resize --------------------------------- */

      Console.WriteLine("");
      Array.Resize(ref pallets, 6);
      Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

      pallets[4] = "C01";
      pallets[5] = "C02";

      foreach (var pallet in pallets)
      {
        Console.WriteLine($"-- {pallet}");
      }

      /* ------------------------------- ToCharArray ------------------------------ */

      string value = "abc123";
      char[] valueArray = value.ToCharArray();
      Array.Reverse(valueArray);
      string result = new string(valueArray);
      Console.WriteLine(result);

      /* ---------------------------------- Join ---------------------------------- */

      string value2 = "abc123";
      char[] valueArray2 = value2.ToCharArray();
      Array.Reverse(valueArray2);
      // string result = new string(valueArray2);
      string result2 = String.Join(",", valueArray2);
      Console.WriteLine(result2);

      /* ---------------------------------- Split --------------------------------- */

      string value3 = "abc123";
      char[] valueArray3 = value3.ToCharArray();
      Array.Reverse(valueArray3);
      // string result = new string(valueArray3);
      string result3 = String.Join(",", valueArray3);
      Console.WriteLine(result3);

      string[] items = result3.Split(',');
      foreach (string item in items)
      {
        Console.WriteLine(item);
      }
    }
  }
}
