
Console.WriteLine("Application qui determine si un mot est un palindrome");

string? chaineATester = Console.ReadLine();

while ( chaineATester == "" || !chaineATester.All(char.IsLetter))
{
    Console.WriteLine("Veuillez entrer un mot valide");
    chaineATester = Console.ReadLine();
}

//Valeur utilisés pour prendre la partie de la chaine a tester
//Permet d'ignorer la lettre du millieu si le nombre de lettre est impair
float moitie = MathF.Floor(chaineATester.Length / 2);

bool estPalindrome = true;
int i = 0;
do 
{
    estPalindrome = chaineATester[i] == chaineATester[chaineATester.Length - 1 - i];
    i++;
} 
while (i < moitie && estPalindrome);


if (estPalindrome)
{
    Console.WriteLine($"{chaineATester} est un palindrome");
}
else
{
    Console.WriteLine($"{chaineATester} n'est pas un palindrome");
}