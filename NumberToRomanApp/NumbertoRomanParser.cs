namespace NumberToRomanApp
{
    public class NumbertoRomanParser
    {
        public static string NumberToRoman(int num)
        {
            if (num > 10000)
                return "Out of Range";

            string[] tenThousandSeries = { "", "X" };
            string[] thousandSeries = { "", "M", "MM", "MMM", "MV","V","VM","VMM", "VMMM", "MX" };
            string[] hundredSeries = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" };
            string[] tenSeries = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] onesSeries = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string romanNumber = "";

            romanNumber += tenThousandSeries[(int)(num / 10000) % 10];
            romanNumber += thousandSeries[(int)(num / 1000) % 10];
            romanNumber += hundredSeries[(int)(num / 100) % 10];
            romanNumber += tenSeries[(int)(num / 10) % 10];
            romanNumber += onesSeries[num % 10];

            return romanNumber;
        }
    }
}
