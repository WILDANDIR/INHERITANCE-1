namespace GameInheritanceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DEMO INHERITANCE");

            Console.WriteLine("Karakter ini dibuat dengan konstruktor berparameter");
            Warrior Wildan = new Warrior(1010, "WOW", "Guntur", 7070, "Reco");
            Wildan.DisplayData();

            Bowo Revi = new Bowo(2000, "5UN4RD1", "Reddit", 6600, "Kalibawo");
            Revi.DisplayData2();

            Bowo archMage = new Bowo(80, "AM-001", "Khadgar", 110, "Karazhan");
            archMage.DisplayData2();

            Console.WriteLine("\n4. Membuat objek Warrior dengan konstruktor default");
            Warrior defaultWarrior = new Warrior();
            defaultWarrior.DisplayData(); 
            

            Console.ReadKey();
        }
    }
}
