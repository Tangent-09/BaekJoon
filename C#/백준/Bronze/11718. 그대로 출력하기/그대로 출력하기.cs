string[] arry = new string[100];
int count = 0;
string input;

while ((input = Console.ReadLine()) != null)
{
    arry[count] = input;
    count++;
}

for (int i = 0; i < count; i++)
{
    Console.WriteLine(arry[i]);
}