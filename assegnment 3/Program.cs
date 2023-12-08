namespace assegnment_3
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.Write("Enter a number (up to 4 digits): ");
            int number = int.Parse(Console.ReadLine());

            string result = ConvertNumberToWords(number);
            Console.WriteLine(result);
        }

        static string ConvertNumberToWords(int number)
        {
            if (number < 0 || number > 9999)
            {
                throw new ArgumentOutOfRangeException("Number should be between 0 and 9999.");
            }

            if (number == 0)
            {
                return "Zero";
            }

            string[] units = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen" };
            string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };

            string words = "";

            // Process thousands
            if (number / 1000 > 0)
            {
                words += units[number / 1000] + " Thousand ";
                number %= 1000;
            }

            // Process hundreds
            if (number / 100 > 0)
            {
                words += units[number / 100] + " Hundred ";
                number %= 100;
            }

            // Process tens and ones
            if (number >= 10 && number <= 19)
            {
                words += teens[number - 11] + " ";
            }
            else
            {
                words += tens[number / 10] + " ";
                number %= 10;

                if (number > 0)
                {
                    words += units[number] + " ";
                }
            }

            return words.Trim();
        }
    }
 }

