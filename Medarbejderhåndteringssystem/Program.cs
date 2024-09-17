

string answer;
string name;
string lastName;
string age;
string eMail;

Console.WriteLine("Hej kære medarbejder\n");
getName();
getLastName();
getAge();
getEMail();
verify();



void getName()
{
    Console.WriteLine("indtast veligst fornavn");
    name = Console.ReadLine();
    Console.WriteLine("\nDit fornavn er: " + name + ". Hvis dette ikke er korrekt Skriv ''NEJ'', ellers fortsæt");
    answer = Console.ReadLine();
    if (answer == "Nej" || answer == "NEJ" || answer == "NEj" || answer == "nej" || answer == "nEJ" || answer == "nEj" || answer == "neJ" || answer == "NeJ")
    {
        getName();
    }
}

void getLastName()
{
    Console.WriteLine("indtast veligst efternavn");
    lastName = Console.ReadLine();
    Console.WriteLine("\nDit efternavn er: " + lastName + ". Hvis dette ikke er korrekt Skriv ''NEJ'', ellers fortsæt");
    answer = Console.ReadLine();
    if (answer == "Nej" || answer == "NEJ" || answer == "NEj" || answer == "nej" || answer == "nEJ" || answer == "nEj" || answer == "neJ" || answer == "NeJ")
    {
        getLastName();
    }
}
void getAge()
{
    Console.WriteLine("indtast veligst alder");
    age = Console.ReadLine();
    Console.WriteLine("\nDin alder er: " + age + ". Hvis dette ikke er korrekt Skriv ''NEJ'', ellers fortsæt");
    answer = Console.ReadLine();
    if (answer == "Nej" || answer == "NEJ" || answer == "NEj" || answer == "nej" || answer == "nEJ" || answer == "nEj" || answer == "neJ" || answer == "NeJ")
    {
        getAge();
    }
}
void getEMail()
{
    Console.WriteLine("indtast veligst E-Mail");
    eMail = Console.ReadLine();
    Console.WriteLine("\nDin E-Mail er: " + eMail + ". Hvis dette ikke er korrekt Skriv ''NEJ'', ellers fortsæt");
    answer = Console.ReadLine();
    if (answer == "Nej" || answer == "NEJ" || answer == "NEj" || answer == "nej" || answer == "nEJ" || answer == "nEj" || answer == "neJ" || answer == "NeJ")
    {
        getEMail();
    }
}
void verify()
{
    Console.WriteLine("Er alle oplysninger korrekt?\n" + "1. fornavn: " + name + "\n2. efternavn: " + lastName + "\n3. Alder: " + age + "\n4. E-Mail: " + eMail + "\n hvis en oplysning er forkert, indtast nummeret for at lave ændringer");
    answer = Console.ReadLine();
    
        if (answer == "1")
        {
            getName();
            verify();
        }
        else if (answer == "2")
        {
            getLastName();
            verify();
        }
        else if(answer == "3")
        {
            getAge();
            verify();
        }
        else if (answer == "4")
        {
            getEMail();
            verify();
        }
        else
        {
            Console.WriteLine("fornavn: " + name + "\nefternavn: " + lastName + "\nAlder: " + age + "\nE-Mail: " + eMail);
            return;
        }
}