namespace GameInheritanceDemo
{
    public class Bowo : Character
    {
        public int mana;
        public Bowo()
        {
            Console.WriteLine("----> Konstruktor default warrior <----");
        }

        public Bowo(int mn, String id, String name, int basePower, String address)
        : base(id, name, basePower, address)
        {
            Console.WriteLine("----> Konstruktor berparameter warrior <----");
            this.mana = mn;
        }

        public void DisplayData2()
        {
            base.DisplayBaseData();
            Console.WriteLine("BONUS         = " + mana);
            Console.WriteLine("TOTAL POWER   = " + (GetBasePower() + mana));
            Console.WriteLine("=====================");
        }

    }
}