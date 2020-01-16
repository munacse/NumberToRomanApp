namespace NumberToRomanApp
{
    public class NumbertoRomanParser
    {
        public static string NumberToRoman(int num)
        {
            //Validate num  
            if (num < 1 || num > 10000)
                return "Out of Range";

            //create an array, each array contain roman 
            //numeral representations of 1-9 in each respective
            //place(ones, tens, hundreds, etc...currently this handles
            // integers from 1-10000, but could be easily extended)
            string[] tenThousandSeries = { "", "X" };
            string[] thousandSeries = { "", "M", "MM", "MMM", "MV","V","VM","VMM", "VMMM", "MX" };
            string[] hundredSeries = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tenSeries = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] onesSeries = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            
            var romanNumber = "";

            //divided and modulo of the given number by and 
            //conacte each result to find the Roman number
            romanNumber += tenThousandSeries[(int)(num / 10000) % 10];
            romanNumber += thousandSeries[(int)(num / 1000) % 10];
            romanNumber += hundredSeries[(int)(num / 100) % 10];
            romanNumber += tenSeries[(int)(num / 10) % 10];
            romanNumber += onesSeries[num % 10];

            return romanNumber;
        }
    }
}
