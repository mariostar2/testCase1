using System;

enum WEAPON
{
    Melee,          //근접 공격
    Long,           //원거리 공격
    Throw,
}


class Weapon
{

}
namespace Program_test1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WEAPON weapon = 0;
            bool isMelee = true;
            while (true)
            {

                ConsoleKeyInfo keyInfo = Console.ReadKey(true);
                if(keyInfo.Key == ConsoleKey.F1)
                {
                    weapon = WEAPON.Melee;
                }
            }
            
        }
    }
}
