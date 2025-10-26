
/*DateTime now = DateTime.Now;

string nowStr = now.ToString("dd-MM-yyyy");
int year = now.Year;
int month = now.Year;
int day = now.Year;
DateTime afterDay  = DateTime.Now.AddDays(5);

TimeSpan time = DateTime.Now.TimeOfDay;

Console.WriteLine($"This is the now date time : {nowStr}");

Console.WriteLine($"This is the now TimeOfDay : {time}");

Console.WriteLine($"This is the now date time after(5)Day: {afterDay}");
 ----------------------------------------------------------------------------------------------------------------
var x=55.5;
var y=66.5;

var z=Math.Min(x,y);
var y2 =Math.Round(y);

Console.WriteLine(z);
Console.WriteLine(y2);
------------------------------------------------------------------------------------------------------------------
Console.WriteLine("input a Intiger");
var input1 = Convert.ToInt32(Console.ReadLine());
if ( (int) input1 < 2 )
{
	
    Console.WriteLine("That is true condition");


}
Console.WriteLine("Enter your input");


int x =Convert.ToInt32(Console.ReadLine());

int z = 110;
int y = 120;

switch (x)
{
    case 110:

        Console.WriteLine("yas it is 110");

break;

    case 120:

        Console.WriteLine("yas it is 120");

        break;

    default:
        Console.WriteLine("it is default");
        break;
}



Console.WriteLine("enter a num");

    int x = Convert.ToInt32(Console.ReadLine());

switch (x)
{

    case 1:

        Console.WriteLine("jun");
        break;

    case 2:
        Console.WriteLine("feb");
        break;
    case 3:
        Console.WriteLine("mar");
        break;
    case 4:
        Console.WriteLine("abr");
        break;
    case 5:
        Console.WriteLine("may");
        break;
    case 6:

        Console.WriteLine("jon");
        break;



}


string input = Console.ReadLine();

string result = input == "yas" ? "the input = yas" : "the input is not = yas";

Console.WriteLine(result);

Console.WriteLine("Enter num 1");

int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter num 2");

int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the Operater");

char ope = Convert.ToChar(Console.ReadLine());




int r;

switch(ope)
{
    case '+':
         r = num1 + num2;
        Console.WriteLine($"thes is the result of {num1} {ope} {num2}  = {r}"); 
        break;

    case '-':
         r = num1 - num2;
        Console.WriteLine($"thes is the result of {num1} {ope} {num2}  = {r}");
        break;
    case '*':

        r = num1 * num2;
        Console.WriteLine($"thes is the result of {num1} {ope} {num2}  = {r}");
        break;

    case '/':
         r = num1 / num2;
        Console.WriteLine($"thes is the result of {num1} {ope} {num2}  = {r}");
        break;

    case '%':
         r = num1 % num2;
        Console.WriteLine($"thes is the result of {num1} {ope} {num2}  = {r}");
        break;

}
*/
/*
Console.WriteLine("Enter your input :");

string str = Console.ReadLine();



string str1 = str.ToLower();

string str2 = str.ToUpper()
    ;
string str3 = str.Replace("salah", "ammar");

int str4 = str.Length;

bool str5 = str.Contains("salah");

bool str6 = str.StartsWith("s");

bool str7 = str.EndsWith("h");

string str8 = str.Substring(2,5);

bool str9 = string.IsNullOrEmpty("");

bool str10 = string.IsNullOrWhiteSpace(" ");

string str11 = str.Trim();



Console.WriteLine($"str => {str}");

Console.WriteLine($"ToLower => {str1}");

Console.WriteLine($"ToUpper => {str2}");

Console.WriteLine($"Replace => {str3}");

Console.WriteLine($"Length => {str4}");

Console.WriteLine($"Contains => {str5}");

Console.WriteLine($"StartsWith => {str6}");

Console.WriteLine($"EndsWith => {str7}");

Console.WriteLine($"Substring => {str8}");

Console.WriteLine($"IsNullOrEmpty => {str9}");

Console.WriteLine($"IsNullOrWhiteSpace => {str10}");

Console.WriteLine($"Trim => {str11}");



Console.WriteLine("Enter the Length");

double length = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the width");

double width = Convert.ToDouble(Console.ReadLine());

double area= length *  width;

double rarea = Math.Round(area,1);

Console.WriteLine($" the area = {area}");

Console.WriteLine($" the rarea = {rarea}")

;

Console.WriteLine("Enter your grade");

double grade = Convert.ToDouble(Console.ReadLine());

if (grade >100)
{

    Console.WriteLine("Cant be > 100");
}

else if (grade >= 90 && grade <=100)
{

    Console.WriteLine("Exelent");

}

else if (grade >= 80 && grade < 90)
{

    Console.WriteLine("very good");

}

else if (grade >= 70 && grade < 80)
{

    Console.WriteLine("good");

}
else if (grade >= 0 && grade < 70)
{

    Console.WriteLine("Fail");

}
else
{
    Console.WriteLine("Tour grade shoud be greater than 0 and less than 100");
}
*/



/*

//________________________________________________________________________ Assigmint 1 _____________________________________________________________________
Console.WriteLine("Enter A Day Number ");

int DayNum = Convert.ToInt32(Console.ReadLine());

if (DayNum > 7 || DayNum < 1)
{
    Console.WriteLine("UnValiedInput!!");

}

else
{
    switch (DayNum)
    {

        case 1:
            Console.WriteLine("Sunday");
            break;

        case 2:
            Console.WriteLine("Monday");
            break;

        case 3:
            Console.WriteLine("Tuesday");
            break;

        case 4:
            Console.WriteLine("Wednesday");
            break;


        case 5:
            Console.WriteLine("Thursday");
            break;

        case 6:
            Console.WriteLine("Friday");
            break;

        case 7:
            Console.WriteLine("Saturday");
            break;
    }

}
    */
//________________________________________________________________________ Assigmint 2 _____________________________________________________________________


/*
Console.WriteLine("Enter A Month Number");

int monthNum = Convert.ToInt32(Console.ReadLine());


if (monthNum > 12 || monthNum < 1)
{
    Console.WriteLine("UnValiedInput!!");

}

else

{
    switch (monthNum)

    { case 1:
        Console.WriteLine($"Thes Is January => 31 days long");
        break;
    

      case 2:
        Console.WriteLine($"Thes Is February => 28 days long");
        break;

    case 3:
        Console.WriteLine($"Thes Is March => 31 days long");
        break;

    case 4:
        Console.WriteLine($"Thes Is April => 30 days long");
        break;

    case 5:
        Console.WriteLine($"Thes Is May => 31 days long");
        break;

    case 6:
        Console.WriteLine($"Thes Is June => 30 days long");
        break;

    case 7:
        Console.WriteLine($"Thes Is July => 31 days long");
        break;

    case 8:
        Console.WriteLine($"Thes Is August => 31 days long");
        break;

    case 9:
        Console.WriteLine($"Thes Is September => 30 days long");
        break;

    case 10:
        Console.WriteLine($"Thes Is October => 31 days long");
        break;

    case 11:
        Console.WriteLine($"Thes Is November => 30 days long");
        break;

    case 12:
        Console.WriteLine($"Thes Is December => 31 days long");
        break;
    }
 Console.WriteLine($"new");
}

        */







