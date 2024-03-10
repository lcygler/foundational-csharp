namespace TestProject.Ejercicios

{
  public class Switch1
  {
    public static void Test()
    {
      string fruit = "apple";

      switch (fruit)
      {
        case "apple":
          Console.WriteLine($"App will display information for apple.");
          break;

        case "banana":
          Console.WriteLine($"App will display information for banana.");
          break;

        case "cherry":
          Console.WriteLine($"App will display information for cherry.");
          break;
      }

      /* -------------------------------------------------------------------------- */

      int employeeLevel = 200;
      string employeeName = "John Smith";

      string title = "";

      switch (employeeLevel)
      {
        case 100:
          title = "Junior Associate";
          break;
        case 200:
          title = "Senior Associate";
          break;
        case 300:
          title = "Manager";
          break;
        case 400:
          title = "Senior Manager";
          break;
        default:
          title = "Associate";
          break;
      }

      /* Switch Expression
      title = employeeLevel switch
      {
        100 => "Junior Associate",
        200 => "Senior Associate",
        300 => "Manager",
        400 => "Senior Manager",
        _ => "Associate",
      };
      */

      Console.WriteLine($"{employeeName}, {title}");

      /* -------------------------------------------------------------------------- */

      switch (employeeLevel)
      {
        case 100:
        case 200:
          title = "Senior Associate";
          break;
        case 300:
          title = "Manager";
          break;
        case 400:
          title = "Senior Manager";
          break;
        default:
          title = "Associate";
          break;
      }

      Console.WriteLine($"{employeeName}, {title}");
    }
  }
}
