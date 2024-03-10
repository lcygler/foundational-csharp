namespace TestProject.Ejercicios

{
  public class ModificarCadenas1
  {
    public static void Test()
    {
      /* ------------------------- IndexOf() y Substring() ------------------------ */

      string message = "Find what is (inside the parentheses)";

      int openingPosition = message.IndexOf('(');
      int closingPosition = message.IndexOf(')');

      openingPosition += 1;

      int length = closingPosition - openingPosition;
      Console.WriteLine(message.Substring(openingPosition, length));

      /* -------------------------------------------------------------------------- */

      message = "What is the value <span>between the tags</span>?";

      openingPosition = message.IndexOf("<span>");
      closingPosition = message.IndexOf("</span>");

      openingPosition += 6;
      length = closingPosition - openingPosition;
      Console.WriteLine(message.Substring(openingPosition, length));

      /* -------------------------------------------------------------------------- */

      message = "What is the value <span>between the tags</span>?";

      const string openSpan = "<span>";
      const string closeSpan = "</span>";

      openingPosition = message.IndexOf(openSpan);
      closingPosition = message.IndexOf(closeSpan);

      openingPosition += openSpan.Length;
      length = closingPosition - openingPosition;
      Console.WriteLine(message.Substring(openingPosition, length));

      /* ------------------------------ LastIndexOf() ----------------------------- */

      message = "(What if) I am (only interested) in the last (set of parentheses)?";
      openingPosition = message.LastIndexOf('(');

      openingPosition += 1;
      closingPosition = message.LastIndexOf(')');
      length = closingPosition - openingPosition;
      Console.WriteLine(message.Substring(openingPosition, length));

      /* -------------------------------------------------------------------------- */

      message = "(What if) there are (more than) one (set of parentheses)?";
      while (true)
      {
        openingPosition = message.IndexOf('(');
        if (openingPosition == -1) break;

        openingPosition += 1;
        closingPosition = message.IndexOf(')');
        length = closingPosition - openingPosition;
        Console.WriteLine(message.Substring(openingPosition, length));

        // Note the overload of the Substring to return only the remaining 
        // unprocessed message:
        message = message.Substring(closingPosition + 1);

        // Using range operator:
        // message = message[(closingPosition + 1)..];

        /* ------------------------------ IndexOfAny() ------------------------------ */

        message = "Help (find) the {opening symbols}";
        Console.WriteLine($"Searching THIS Message: {message}");
        char[] openSymbols = { '[', '{', '(' };
        int startPosition = 5;
        openingPosition = message.IndexOfAny(openSymbols);
        Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

        openingPosition = message.IndexOfAny(openSymbols, startPosition);
        Console.WriteLine($"Found WITH using startPosition {startPosition}:  {message.Substring(openingPosition)}");
      }
    }
  }
}
