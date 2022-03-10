static void Main(string[] args)
{
    Random mojaliczba = new Random();
    int min = 1;
    int max = 10;
    int losowa;
    int liczba;

    while ()
    {

        losowa = 0;
        liczba = mojaliczba.Next(min, max + 1);

        while (losowa != liczba)
        {
            Console.WriteLine("podaj liczbę pomiędzy 1- 10: ");
            losowa = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj:");
            if (losowa > liczba)
            {
                Console.WriteLine(losowa + "jest większa , sprobuj ponownie");
            }
            else if (losowa < liczba)
            {
                Console.WriteLine(losowa + " jest mniejsza , sprobuj ponownie");
            }

        }
        Console.WriteLine("liczba:" + liczba);
        Console.WriteLine("Wygrałeś gratulacje!Insert coin to play again");
    }
}