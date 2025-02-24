using System;
using System.Text.RegularExpressions;

namespace calculator_c_sharp
{
    class Program
    {
        static bool IsAffirmative(string input)
        {
            string sanitized = Regex.Replace(input, "[^a-zA-Z]", "").ToLower();
            if (sanitized.Length > 3) return false;
            return sanitized == "j" || sanitized == "ja" || sanitized == "y" || sanitized == "yes";
        }

        static void Main(string[] args)
        {
            ICalculator calc = new Calculator();
            string value = "j";
            do
            {
                Console.Write("Skriv inn beregning (f.eks. 5+3 eller 10.5*2): ");
                string input = Console.ReadLine()?.Trim() ?? "";
                Match match = Regex.Match(input, @"^(\d+(\.\d+)?)([+\-*/])(\d+(\.\d+)?)$");
                if (!match.Success)
                {
                    Console.WriteLine("Ugyldig format! Bruk for eksempel 5+3 eller 10.5*2");
                    continue;
                }
                double num1 = double.Parse(match.Groups[1].Value);
                string symbol = match.Groups[3].Value;
                double num2 = double.Parse(match.Groups[4].Value);
                double result = 0;
                bool valid = true;
                switch (symbol)
                {
                    case "+":
                        result = calc.AddNumbers(num1, num2);
                        break;
                    case "-":
                        result = calc.SubtractNumbers(num1, num2);
                        break;
                    case "*":
                        result = calc.MultiplyNumbers(num1, num2);
                        break;
                    case "/":
                        if (num2 != 0)
                            result = calc.DivideNumbers(num1, num2);
                        else
                        {
                            Console.WriteLine("Feil: Kan ikke dele på null!");
                            valid = false;
                        }
                        break;
                    default:
                        Console.WriteLine("Ugyldig operator! Bruk +, -, * eller /");
                        valid = false;
                        break;
                }
                if (valid)
                    Console.WriteLine($"Resultat = {result}");
                Console.Write("Ønsker du å fortsette (j/n): ");
                string continueInput = Console.ReadLine() ?? "";
                value = IsAffirmative(continueInput) ? "j" : "n";
            } while (value == "j");
        }
    }
}
