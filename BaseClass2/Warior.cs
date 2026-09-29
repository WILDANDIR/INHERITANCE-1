namespace GameInheritanceDemo
{
    public class Warrior : Character
    {
        public int bonus;
        public Warrior() : base()
        {
            Console.WriteLine("----> Konstruktor default warrior <----");
        }

        public Warrior(int bonus, String id, String name, int basePower, String address)
        : base(id, name, basePower, address)
        {
            Console.WriteLine("----> Konstruktor berparameter warrior <----");
            this.bonus = bonus;
        }

        public void DisplayData()
        {
            base.DisplayBaseData();
            Console.WriteLine("BONUS         = " + bonus);
            Console.WriteLine("TOTAL POWER   = " + (GetBasePower() + bonus));
            Console.WriteLine("=====================");
        }

       
    }
}       