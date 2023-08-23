using System.Security.Cryptography.X509Certificates;

string word = "Mano vardas Robertas";
//Substring
Console.WriteLine(word.Substring(5)); // vardas Robertas
Console.WriteLine(word.Substring(0, 4)); // Mano

//Replace
Console.WriteLine(word.Replace('M', 'T').Replace('n', 'v')); // kaip pakeisti dvi poras raidziu

//IndexOf
Console.WriteLine(word.IndexOf("v"));

//Trim
string word2 = "    Tarpas     ";
Console.BackgroundColor = ConsoleColor.Green;
Console.WriteLine(word2.Trim());
Console.BackgroundColor = ConsoleColor.Black;

//ToLowerInvariant()
Console.WriteLine(word2.ToLower());

//ToUpperInvariant()
Console.WriteLine(word2.ToUpper());