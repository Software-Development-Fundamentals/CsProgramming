using System;


class Program
{
    static void Main()
    {
        ShowGameInstructions();
        ShowStartMessage();

        int compNumber = 0;
        int userNumber = 0;

        while(compNumber != 1 && userNumber != 1)
        {
            compNumber = CompMove(compNumber, userNumber);
            if (compNumber == 1) continue;

            userNumber = UserMove(compNumber);
        }

        ChooseWinner(compNumber, userNumber);
        Stop();
    }


    static void ShowGameInstructions()
    {
        WriteOutput("\t\t\t\t Oyuna xos gelmisiniz.\n");
        WriteOutput("\t Oyunun qaydalari:\n");

        WriteOutput("\t\t 1. ", ConsoleColor.Green);
        WriteOutput("Eded teyin edilir.\n");

        WriteOutput("\t\t 2. ", ConsoleColor.Green);
        WriteOutput("Sira ile ededden 1 ve ya 2 cixilir.\n");

        WriteOutput("\t\t 3. ", ConsoleColor.Green);
        WriteOutput("Ilk bir(1) reqemine catan oyunu qazanir.\n");


        WriteOutput("\t\t QEYD: ", ConsoleColor.Red);
        WriteOutput("Yanlis eded daxil etdikde yeniden daxil etmelisiniz.\n\n");
    }
    static void ShowStartMessage()
    {
        WriteOutput("Oyuna baslamaq ucun ");
        WriteOutput("ENTER ", ConsoleColor.Green);
        WriteOutput("klik edin.");
        Stop();
        WriteOutput("\n\n");
    }


    static int CreateRandomNumber()
    {
        int randomNumber = 0;
        Random rnd = new Random();

        randomNumber = rnd.Next(1, 2);

        return randomNumber;
    }
    static int CreateMagicNumber()
    {
        int randomNumber = 0;
        int randomMagicNumber = 0;
        Random rnd = new Random();

        randomNumber = rnd.Next(10, 50);

        if (IsMagicNumber(randomNumber))
        {
            randomMagicNumber = randomNumber;
        }
        else
        {
            for (int i = 1; i <= 3; i++)
            {
                if (IsMagicNumber(randomNumber + i))
                {
                    randomMagicNumber = randomNumber + i;
                    break;
                }
            }
        }

        return randomMagicNumber;
    }
    static int CreateMagicNumber(int userNumber)
    {
        int magicNumber = 0;

        if (IsMagicNumber(userNumber - 1))
            magicNumber = userNumber - 1;
        else
            magicNumber = userNumber - 2;

        return magicNumber;
    }


    static bool IsMagicNumber(int number)
    {
        bool isMagic = false;

        if ((number - 1) % 3 == 0)
        {
            isMagic = true;
        }

        return isMagic;
    }
    static bool IsCorrectNumber(int compNumber, int userNumber)
    {
        bool isCorrect = false;

        if ((compNumber - 1) == userNumber)
            isCorrect = true;
        else if ((compNumber - 2) == userNumber)
            isCorrect = true;

        return isCorrect;
    }


    static int CompMove(int compNumber, int userNumber)
    {
        int newCompNumber = 0;

        newCompNumber = compNumber == 0 ? CreateMagicNumber() : CreateMagicNumber(userNumber);

        WriteOutput($"Men: {newCompNumber}\n", ConsoleColor.Yellow);

        return newCompNumber;
    }
    static int UserMove(int compNumber)
    {
        int userNumber = 0;
        string input = null;

        user:
        WriteOutput("Sen: ", ConsoleColor.Cyan);
        input = ReadInput();
        userNumber = StringToInt(input);

        if (!IsCorrectNumber(compNumber, userNumber))
            goto user;

        return userNumber;
    }


    static void ChooseWinner(int compNumber, int userNumber)
    {
        if(compNumber == 1)
            WriteOutput("\n\nMen qalib geldim :-P", ConsoleColor.Green);
        else if(userNumber == 1)
            WriteOutput("\n\nSen qalib geldin :(", ConsoleColor.Green);
    }


    static void Stop()
    {
        Console.ReadKey();
    }

    static string ReadInput()
    {
        return Console.ReadLine();
    }

    static void WriteOutput(string output, ConsoleColor color = ConsoleColor.White)
    {
        Console.ForegroundColor = color;
        Console.Write(output);
    }

    static int StringToInt(string value)
    {
        int result = 0;

        try
        {
            result = Convert.ToInt32(value);
        }
        catch { }

        return result;
    }
}
