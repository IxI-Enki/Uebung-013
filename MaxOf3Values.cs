/*------------------------------------------------------------------------------
 *                      HTBLA-Leonding / Class: 3ACIF                           
 *------------------------------------------------------------------------------
 *                      Jan Ritt                                                
 *------------------------------------------------------------------------------
 *  Description:  The program reads in three values, sorts them and outputs the 
 *                minimum and maximum.														
 *------------------------------------------------------------------------------
*/
using System;

namespace MaxOf3Values
{
  internal class Program
  {
    static void Main(string[] args)
    {
      double valueOne, valueTwo, valueThree;
      double swapValue;

      // Eingabe      (E)  --  Header
      Console.Clear();
      Console.WriteLine("  MaxOf3Values  ");
      Console.WriteLine("================\n");
      // Eingabe      (E)  --  Input
      Console.Write("Geben Sie den Ersten von drei Werten ein.  ");
      valueOne = Convert.ToDouble(Console.ReadLine());

      Console.Write("Geben Sie den Zweiten von drei Werten ein.  ");
      valueTwo = Convert.ToDouble(Console.ReadLine());

      Console.Write("Geben Sie den Dritten von drei Werten ein.  ");
      valueThree = Convert.ToDouble(Console.ReadLine());

      // Verarbeitung (V)  --  test values one vs two
      if (valueOne > valueTwo)
      {
        swapValue = valueOne;
        valueOne = valueTwo;
        valueTwo = swapValue;
      }
      // Verarbeitung (V)  --  test values one vs three
      if (valueOne > valueThree)
      {
        swapValue = valueThree;
        valueThree = valueOne;
        valueOne = swapValue;
      }
      // Verarbeitung (V)  --  test values two vs three
      if (valueTwo > valueThree)
      {
        swapValue = valueTwo;
        valueTwo = valueThree;
        valueThree = swapValue;
      }

      // Ausgabe      (A)  -- sorted output
      Console.WriteLine("--------------------");
      Console.WriteLine($"Der kleinste Wert ist: {valueOne}");
      Console.WriteLine($"Der mittlere Wert ist: {valueTwo}");
      Console.WriteLine($"Der höchste Wert ist:  {valueThree}");
      Console.WriteLine("--------------------");
      Console.WriteLine("Zum Beenden bitte Taste drücken ...");
      Console.ReadKey();
      Console.Clear();
    }
  }
}
