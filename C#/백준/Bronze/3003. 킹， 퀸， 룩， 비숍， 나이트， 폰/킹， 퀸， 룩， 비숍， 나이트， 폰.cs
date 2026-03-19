int[] foundedPongs = { 1, 1, 2, 2, 2, 8 };
int[] inputPongs = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

for (int i = 0; i < 6; i++)
{
    Console.Write(foundedPongs[i] - inputPongs[i] + " ");
}