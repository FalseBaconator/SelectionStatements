using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionStatements
{
    internal class Program
    {
        static int health;
        static int weapon;              //0 = pistol, 1=Shot Gun, 2=Spreader, 3=Laser, 4=Sniper, 5=BFG
        static string healthStatus;
        static string weaponName;

        static void Main(string[] args)
        {
            health = 100;
            weapon = 0;
            weaponName = "Pistol";


            Console.WriteLine("Hey");
            Console.ReadKey(true);
        }

        static void TakeDamage(int dmg)
        {
            health -= dmg;
            if(health < 0)
            {
                health = 0;
            }
            DisplayHUD();
        }

        static string DetermineStatus()
        {
            if (health == 0)
            {
                healthStatus = "It says here you're definitely dead";
            }else if (health <= 10)
            {
                healthStatus = "On death's door";
            }
            else if (health <= 25)
            {
                healthStatus = "In need of immediate medical attention";
            }
            else if (health <= 50)
            {
                healthStatus = "Technically not dying";
            }
            else if (health <= 75)
            {
                healthStatus = "You should probably leave";
            }
            else if (health < 100)
            {
                healthStatus = "You'll probably be fine";
            }
            else if (health == 100)
            {
                healthStatus = "In perfect health";
            }

            return healthStatus;
        }

        static void SwapWeapon(int weap)
        {
            weapon = weap;
            switch (weapon)
            {
                case 0:
                    weaponName = "Pistol";
                    break;
                case 1:
                    weaponName = "Shot Gun";
                    break;
                case 2:
                    weaponName = "Spreader";
                    break;
                case 3:
                    weaponName = "Laser";
                    break;
                case 4:
                    weaponName = "Sniper";
                    break;
                case 5:
                    weaponName = "BFG (Big Friendly Gun)";
                    break;

            }
            DisplayHUD();
        }

        static void DisplayHUD()
        {
            Console.Clear();
            Console.WriteLine("Health: " + health + " | Status: " + DetermineStatus() + " | Weapon: " + weaponName);
            Console.ReadKey(true);
        }
    }
}
