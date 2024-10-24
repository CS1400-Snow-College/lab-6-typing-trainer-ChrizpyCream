// See https://aka.ms/new-console-template for more information
using System.Diagnostics;
Console.Clear();

// Brief instructions
Console.Write("This is a typing challenge you can not use backspace and mistakes will be shown with red.");

// puts a space in between the explanation and the typing phrase
Console.WriteLine();

string phrase1 = "The quick brown fox jumps over the lazy dog.";
string phrase2 = "Bob the builder can he build it yes he can.";
string phrase3 = "Some say the point to life is happiness what do you think the point of life is?";
string phrase4 = "Music is a wonderful thing it can sooth the mind, hype someone up, or even tell a story!";
string phrase5 = "Literature; you either love it or hate it, but communication is one thing that makes humans advanced.";

//random number for a random line
Random rand = new Random();
int randomNum = rand.Next(0,5);

//array that stores the phrases
string[] typingPhrases = new string [5] {phrase1, phrase2, phrase3, phrase4, phrase5};
string chosenPhrase = typingPhrases[randomNum];
string[] words = chosenPhrase.Split(' ');

//writes the chosen phrase
Console.Write($"{chosenPhrase}");
Console.WriteLine();

int i = 0;
int correct = 0;
int incorrect = 0;
int j = 0;

Stopwatch stopwatch = new Stopwatch();

//Now the user will type the chosen phrase that was chosen does not need to move the cursor
while(i<chosenPhrase.Length)
    {

    char keyPressed = Console.ReadKey(true).KeyChar;
    // uses background color so that spaces can be shown as mistakes as well
    if(keyPressed == chosenPhrase[i])
    {
        Console.BackgroundColor = ConsoleColor.Green;
        correct ++;
    }else
    {
        Console.BackgroundColor = ConsoleColor.Red;
        incorrect ++;
    }
    Console.Write(chosenPhrase[i]);
    stopwatch.Start();
    i ++;
    }
    Console.BackgroundColor = ConsoleColor.Black;

    //to calculate how many words there is.
    for(j = 0; j<words.Length; j++)
{
}
    stopwatch.Stop();
    double elapsedSeconds = stopwatch.ElapsedMilliseconds / 1000.0;
    int seconds = Convert.ToInt32(elapsedSeconds);

    Console.WriteLine();
    Console.Write($"Your phrase had {j} words in it. It took you {seconds} seconds. You had {incorrect} mistakes.");

    //minutes is just seconds divided by 60 because there is 60 seconds in a word.
    double minutes = (double) elapsedSeconds/60;

    // words per minute is totalWords divided by total minutes
    double decimalWPM = (double) j/minutes;
    // convert it to just a number for better looks
    int WPM = Convert.ToInt32(decimalWPM);

    // subtract mistakes for true WPM
    int trueWPM = WPM - incorrect;
    Console.WriteLine();
    Console.Write($"Your words per minute was {trueWPM}WPM");

float accuracy = (float) 0;

    if (correct == 0)
    {
        Console.WriteLine("Wow your bad at typing");
    }else
    {
        accuracy =  (float)correct/ i * 100;
    }

    //converting accuracy to a int for better looks
    int trueAccuracy =Convert.ToInt32(accuracy);
    
    //for de-bugging later if needed.
    //Console.WriteLine($"{correct} {incorrect} {i}");

Console.WriteLine();
Console.WriteLine($"You had {trueAccuracy}% accuracy");