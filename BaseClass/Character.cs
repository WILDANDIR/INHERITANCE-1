using System;

namespace GameInheritanceDemo
{
    public class Character
    {
        private String characterID;
        private String name;
        private int basePower;
        private String address;

        public Character()
        {
            Console.WriteLine("----> Konstruktor default Character <----");
        }
        public Character(String id, String name, int basePower, String address)
        {
            Console.WriteLine("----> Konstruktor berparameter Character <----");
            this.characterID = id;
            this.name = name;
            this.basePower = basePower;
            this.address = address;
        }
        public void DisplayBaseData()
        {
            Console.WriteLine("CHARACTER ID   = " + characterID);
            Console.WriteLine("NAME           = " + name);
            Console.WriteLine("BASE POWER     = " + basePower);
            Console.WriteLine("ADDRESS        = " + address);
        }

        public int GetBasePower()
        {
            return basePower;
        }
    }
}
