using Numberguesser_ILA2_1300;
using System;

namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
            Highscore highscore = new Highscore();
            StartGame(highscore);
        }

        static void StartGame(Highscore highscore)
        {
            do
            {
                int secretNumber = new Random().Next(1, 101);
                int attempts = 0;
                bool hasGuessedCorrectly = false;

                Console.WriteLine("Willkommen beim Numberguesser");
                Console.WriteLine("Es wurde eine Geheimezahl zwischen 1 und 100 generiert, versuche sie zu erraten :)");

                while (!hasGuessedCorrectly)
                {
                    Console.Write("Gib eine Zahl ein: ");
                    string input = Console.ReadLine();

                    if (!int.TryParse(input, out int guessedNumber))
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte gib eine gültige Zahl ein.");
                        continue;
                    }

                    attempts++;

                    if (guessedNumber < secretNumber)
                    {
                        Console.WriteLine("Die Geheimzahl ist größer als deine Eingabe.");
                    }
                    else if (guessedNumber > secretNumber)
                    {
                        Console.WriteLine("Die Geheimzahl ist kleiner als deine Eingabe.");
                    }
                    else
                    {
                        hasGuessedCorrectly = true;
                        Console.WriteLine($"Glückwunsch! Du hast die Geheimzahl {secretNumber} in {attempts} Versuchen erraten.");
                        highscore.AddScore(attempts);
                        highscore.DisplayHighscores();
                    }
                }

                string playAgain;
                do
                {
                    Console.Write("Möchtest du nochmal spielen? (ja/nein): ");
                    playAgain = Console.ReadLine()?.ToLower(); // Chat GPT
                } while (playAgain != "ja" && playAgain != "nein");

                if (playAgain == "nein")
                {
                    Console.WriteLine("Danke fürs Spielen!");
                    break;
                }


            } while (true);
        }
    }
}
