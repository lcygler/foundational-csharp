namespace TestProject.Ejercicios

{
  public class FormatearData1
  {
    public static void Test()
    {
      // Formato compuesto
      string first = "Hello";
      string second = "World";
      Console.WriteLine("{1} {0}!", first, second);
      Console.WriteLine("{0} {0} {0}!", first, second);

      string result = string.Format("{0} {1}!", first, second);
      Console.WriteLine(result);

      // Interpolación de cadenas
      Console.WriteLine($"{first} {second}!");
      Console.WriteLine($"{second} {first}!");
      Console.WriteLine($"{first} {first} {first}!");

      // Aplicación de formato a valores de moneda
      decimal price = 123.45m;
      int discount = 50;
      Console.WriteLine($"Price: {price:C} (Save {discount:C})");

      // Aplicación de formato a números
      decimal measurement = 123456.78912m;
      Console.WriteLine($"Measurement: {measurement:N} units");
      Console.WriteLine($"Measurement: {measurement:N4} units");

      // Aplicación de formato a porcentajes
      decimal tax = .36785m;
      Console.WriteLine($"Tax rate: {tax:P2}");

      // Combinación de enfoques de formato
      decimal price2 = 67.55m;
      decimal salePrice = 59.99m;

      string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price2 - salePrice), price2);

      yourDiscount += $"A discount of {((price2 - salePrice) / price2):P2}!"; // inserted
      Console.WriteLine(yourDiscount);

      // Ejercicio recibo
      int invoiceNumber = 1201;
      decimal productShares = 25.4568m;
      decimal subtotal = 2750.00m;
      decimal taxPercentage = .15825m;
      decimal total = 3185.19m;

      Console.WriteLine($"Invoice Number: {invoiceNumber}");
      Console.WriteLine($"   Shares: {productShares:N3} Product");
      Console.WriteLine($"     Sub Total: {subtotal:C}");
      Console.WriteLine($"           Tax: {taxPercentage:P2}");
      Console.WriteLine($"     Total Billed: {total:C}");

      /*
      Agregar espacios en blanco a la izquierda de la cadena para que el número total de caracteres sea igual al argumento que se envía, es decir, que la longitud total de la cadena sea de 12 caracteres en este caso
      */
      string input = "Pad this";
      Console.WriteLine(input.PadLeft(12));

      // Agregar guiones con PadLeft() y PadRight()
      string input2 = "Pad this";
      Console.WriteLine(input2.PadLeft(12, '-'));
      Console.WriteLine(input2.PadRight(12, '-'));

      // Uso de cadenas con relleno
      string paymentId = "769C";
      string payeeName = "Mr. Stephen Ortega";
      string paymentAmount = "$5,000.00";

      var formattedLine = paymentId.PadRight(6);
      formattedLine += payeeName.PadRight(24);
      formattedLine += paymentAmount.PadLeft(10);

      Console.WriteLine("1234567890123456789012345678901234567890");
      Console.WriteLine(formattedLine);
    }
  }
}
