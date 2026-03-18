string str = Console.ReadLine();

string[] arry = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

string num1 = arry[0];
string num2 = arry[1];

num1 = $"{num1[2]}{num1[1]}{num1[0]}";
num2 = $"{num2[2]}{num2[1]}{num2[0]}";

string result = int.Parse(num1) > int.Parse(num2) ? num1 : num2;


Console.WriteLine(result);