string input = Console.ReadLine();
        int totalTime = 0;

        foreach (char c in input)
        {
            if (c >= 'A' && c <= 'C') totalTime += 3;
            else if (c >= 'D' && c <= 'F') totalTime += 4;
            else if (c >= 'G' && c <= 'I') totalTime += 5;
            else if (c >= 'J' && c <= 'L') totalTime += 6;
            else if (c >= 'M' && c <= 'O') totalTime += 7;
            else if (c >= 'P' && c <= 'S') totalTime += 8;
            else if (c >= 'T' && c <= 'V') totalTime += 9;
            else if (c >= 'W' && c <= 'Z') totalTime += 10;
        }

        Console.WriteLine(totalTime);