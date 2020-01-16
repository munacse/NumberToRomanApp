# Number To Roman App
I have created a library that expose a class named NumbertoRomanParser, It takes a number and returns the roman numeral representation.

1 -> I, 5 -> V, 4 -> IV

Support numbers from 0 -> 10,000


In this NumbertoRomanParser class, I have written a function named NumberToRoman.

Number to Roman number convertion is a one kind of math. I have developed an algorithm to solve this problem. 

Lets we want to conver 25 to its roman number. Lets try to solve it, by our algorithm.

Given,<br/>
tenThousandSeries = [ "", "X" ]<br/>
thousandSeries = [ "", "M", "MM", "MMM", "MV","V","VM","VMM", "VMMM", "MX" ]<br/>
hundredSeries = [ "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "CM" ]<br/>
tenSeries = [ "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" ]<br/>
onesSeries = [ "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" ]<br/>
<br/>
romanNumber = tenThousandSeries[(int)(25 / 10000) % 10] = tenThousandSeries[0] = ""<br/>
romanNumber = thousandSeries[(int)(25 / 1000) % 10] = thousandSeries[0] = ""<br/>
romanNumber = hundredSeries[(int)(25 / 100) % 10] = hundredSeries[0] = ""<br/>
romanNumber = tenSeries[(int)(25 / 10) % 10] = tenSeries[2] = "XX"<br/>
romanNumber = onesSeries[25 % 10] = onesSeries[5] = "V"<br/>
Concate this result = "XXV"<br/>
So, 25 = "XXV"<br/>
<br/>
<br/>
Lets convert 7777 to its roman number<br/>
romanNumber = tenThousandSeries[(int)(7777 / 10000) % 10] = tenThousandSeries[0] = ""<br/>
romanNumber = thousandSeries[(int)(7777 / 1000) % 10] = thousandSeries[7] = "VMM"<br/>
romanNumber = hundredSeries[(int)(7777 / 100) % 10] = hundredSeries[7] = "DCC"<br/>
romanNumber = tenSeries[(int)(7777 / 10) % 10] = tenSeries[7] = "LXX"<br/>
romanNumber = onesSeries[7777 % 10] = onesSeries[7] = "VII"<br/>
Concate this result = "VMMDCCLXXVII"<br/>
So, 7777 = "VMMDCCLXXVII"<br/>


<br/><br/>
You can also run the test code under NumberToRomanTest.cs class
