string str = Console.ReadLine();

string[] arry = str.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);

Console.WriteLine(arry.Length);