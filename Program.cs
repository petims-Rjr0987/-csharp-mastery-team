/*<<<<<<< HEAD
﻿string teamName ="Elite C# team";
int Members= 3;

Console.WriteLine($"Welcome to the {teamName}!");
Console.WriteLine("bien vennue dans notre programme");
Console.WriteLine($"We have {Members} members in our team.");

*/
/*=======*/
﻿string teamName ="Elite c# team";
int members  =3;
Console.WriteLine("");
Console.WriteLine("Bienvenue dans notre programme");
Console.WriteLine($"Nom de l'equpe {teamName} ");
Console.WriteLine($"Nombre du membres {members}");
/*mode de conception :
Un professionnel pense :

pourquoi int ?
combien de mémoire ?
et si l’âge dépasse la limite ?
sécurité ?
validation ?
*/
string username = "Alex";
/*Validation : longuer , sécurité(vide ou nom), caractère ,

pourqoui string: chainne de caratère, */

int age = 20;
double height = 1.75;
/*pourqouio ?? : nombre(entier)

nombre avec vurgil. deux chiffre après virgul
sécurité??? : nombre vide(entrer vide )
validation ?? sans virgul innacceptable 
*/
char grade = 'A';
bool isStudent = true;
/*
Un professionnel pense :

pourquoi int ?
combien de mémoire ?
et si l’âge dépasse la limite ?
sécurité ?
validation ?

*/

Console.WriteLine(username);
Console.WriteLine(age);
Console.WriteLine(height);
Console.WriteLine(grade);
Console.WriteLine(isStudent);


/*

string username = "Alex";
int age = 20;
double height = 1.75;
char grade = 'A';
bool isStudent = true;

Console.WriteLine(username);
Console.WriteLine(age);
Console.WriteLine(height);
Console.WriteLine(grade);
Console.WriteLine(isStudent);

*/


/*git add .
git commit -m "Fetra: Ajout des questions Nom et Pays"
git push origin main*/
/*>>>>>>> 50aa1db0e577d95522d251a74c450976f44c843f*/

/*day 2 : variable et entrés user */

Console.Write("entrer votre nom :");
name = Console.ReadLine();


Console.Write("Votre age :");
ageDay2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Votre origin:");
city = Console.ReadLine();

Console.Write("Votre competance proffisionelle :");
profession = Console.ReadLine();