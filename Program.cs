// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
Console.Clear();

// instructions for the user
Console.Write("This is a challenge to show how proficiently you type words per minute. Errors will appear in red.");

string phrase1 = "Come with me and you'll see a World with pure imagination.";
string phrase2 = "Run to eat? Or eat to run?";
string phrase3 = "Procrastination is like a credit card: it's a lot of fun until you get the bill.";
string phrase4 = "People can't drive you crazy if you don't give them keys.";
string phrase5 = "When I was a kid my parents moved a lot, but I always found them.";

// random number for the line
Random rand2 = new Random();
string[] copingPhrases = new string[] { phrase1, phrase2, phrase3, phrase4, phrase5 };
string desiredPhrase = copingPhrases[rand2.Next(copingPhrases.Length)];
string[] words = desiredPhrase.Split(' ');

// display the chosen phrase
Console.WriteLine($"\n{desiredPhrase}\n");

int i = 0, correct = 0, incorrect = 0;
Stopwatch stopwatch2 = new Stopwatch();
stopwatch2.Start(); // Start stopwatch before loop

// User types the phrase
while (i < desiredPhrase.Length)
{
    char keyPressed = Console.ReadKey(true).KeyChar;
    Console.BackgroundColor = keyPressed == desiredPhrase[i] ? ConsoleColor.Green : ConsoleColor.Red;
    
    if (keyPressed == desiredPhrase[i]) correct++;
    else incorrect++;

    Console.Write(desiredPhrase[i]);
    Console.ResetColor();
    i++;
}

stopwatch2.Stop();
double elapsedSeconds = stopwatch2.ElapsedMilliseconds / 1000.0;
int seconds = Convert.ToInt32(elapsedSeconds);

// Summary of results
Console.WriteLine();
Console.WriteLine($"Your phrase had {words.Length} words. It took you {seconds} seconds. You made {incorrect} mistakes.");

// WPM Calculation
double minutes = elapsedSeconds / 60;
int wpm = Convert.ToInt32(words.Length / minutes);
int accurateWPM = Math.Max(0, wpm - incorrect); // Ensure no negative WPM

// Accuracy calculation
float accuracy = (float)correct / i * 100;
int trueAccuracy = Convert.ToInt32(accuracy);
Console.WriteLine($"Your words per minute was {accurateWPM} WPM.");
Console.WriteLine($"You had {trueAccuracy}% accuracy");

if (trueAccuracy < 50) Console.WriteLine("Your typing needs improvement.");
