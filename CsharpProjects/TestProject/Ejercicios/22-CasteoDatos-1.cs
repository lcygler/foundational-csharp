namespace TestProject.Ejercicios

{
  public class CasteoDatos1
  {
    public static void Test()
    {
      /* ----------------------------- Casteo de datos ---------------------------- */

      // Casteo de int a decimal
      int myInt1 = 3;
      Console.WriteLine($"int: {myInt1}");

      decimal myDecimal1 = myInt1;
      Console.WriteLine($"decimal: {myDecimal1}");

      // Casteo de decimal a int
      decimal myDecimal2 = 3.14m;
      Console.WriteLine($"decimal: {myDecimal2}");

      int myInt2 = (int)myDecimal2;
      Console.WriteLine($"int: {myInt2}");

      // Casteo de float a decimal
      decimal myDecimal3 = 1.23456789m;
      float myFloat3 = (float)myDecimal3;

      Console.WriteLine($"Decimal: {myDecimal3}");
      Console.WriteLine($"Float  : {myFloat3}");

      /* ---------------------------- Método ToString() --------------------------- */

      // Uso de ToString() para convertir un número en string
      int first1 = 5;
      int second1 = 7;
      string message = first1.ToString() + second1.ToString();
      Console.WriteLine(message);

      /* ----------------------------- Método Parse() ----------------------------- */

      // Conversión de un objeto string en int mediante el método auxiliar Parse()
      string first2 = "5";
      string second2 = "7";
      int sum = int.Parse(first2) + int.Parse(second2);
      Console.WriteLine(sum);

      /* ------------------------------ Clase Convert ----------------------------- */

      // Conversión de un objeto string en int mediante la clase Convert
      string value1 = "5";
      string value2 = "7";
      int result1 = Convert.ToInt32(value1) * Convert.ToInt32(value2);
      Console.WriteLine(result1);

      // Comparación de la coerción y conversión de un objeto decimal en int
      // La coerción trunca y la conversión redondea
      int value3 = (int)1.5m; // casting truncates
      Console.WriteLine(value3); // prints 1

      int value4 = Convert.ToInt32(1.5m); // converting rounds up
      Console.WriteLine(value4); // prints 2

      /* ---------------------------- Método TryParse() --------------------------- */

      // Conversión de una cadena en un entero con TryParse()
      string value = "102";
      int result2 = 0;

      if (int.TryParse(value, out result2))
      {
        Console.WriteLine($"Measurement: {result2}");
      }
      else
      {
        Console.WriteLine("Unable to report the measurement.");
      }

      if (result2 > 0)
        Console.WriteLine($"Measurement (w/ offset): {50 + result2}");
    }
  }
}
