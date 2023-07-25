using System.ComponentModel.Design;

int[] grades = new int[365];

List<string> dayOfWeeks = new List<string>();
dayOfWeeks.Add("poniedziałek");
dayOfWeeks.Add("wtorek");
dayOfWeeks.Add("środa");
dayOfWeeks.Add("czwartek");
dayOfWeeks.Add("piątek");
dayOfWeeks.Add("sobota");
dayOfWeeks.Add("niedziela");
//^lista      


for (int i = 0; i < dayOfWeeks.Count; i = i + 3)
{
    // Console.WriteLine(dayOfWeeks[i]);
}
// ^pętla

foreach (var day in dayOfWeeks)
{
    //Console.WriteLine(day);
}
int[] number4566 = new int[4];
number4566[0] = '4';
number4566[1] = '5';
number4566[2] = '6';
number4566[3] = '6';

for (int i = 0; i < number4566.Length; i++)
{
    Console.WriteLine(number4566[i]);
}



int number = 859044666;
string numberAsString = number.ToString();
char[] letters = numberAsString.ToCharArray();

int counter0 = 0;
int counter1 = 0;
int counter2 = 0;
int counter3 = 0;
int counter4 = 0;
int counter5 = 0;
int counter6 = 0;
int counter7 = 0;
int counter8 = 0;
int counter9 = 0;


foreach (char digit in letters)
{
    if (digit == '0')
    {
        counter0++;
    }
    else if (digit == '1')
    {
        counter1++;
    }
    else if (digit == '2')
    {
        counter2++;
    }
    else if (digit == '3')
    {
        counter3++;
    }
    else if (digit == '4')
    {
        counter4++;
    }
    else if (digit == '5')
    {

        counter5++;
    }
    else if (digit == '6')
    {
        counter6++;
    }
    else if (digit == '7')
    {
        counter7++;
    }
    else if (digit == '8')
    {
        counter8++;
    }
    else if (digit == '9')
    {
        counter9++;
    }


}

Console.WriteLine("Digits in number 859044666");
Console.WriteLine($"0 => {counter0}");
Console.WriteLine($"1 => {counter1}");
Console.WriteLine($"2 => {counter2}");
Console.WriteLine($"3 => {counter3}");
Console.WriteLine($"4 => {counter4}");
Console.WriteLine($"5 => {counter5}");
Console.WriteLine($"6 => {counter6}");
Console.WriteLine($"7 => {counter7}");
Console.WriteLine($"8 => {counter8}");
Console.WriteLine($"9 => {counter9}");