using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace HeroMonster
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Character hero = new Character ();
            hero.Name = "Hero";
            hero.Health = 35;
            hero.DamageMaximum = 20;
            hero.AttackBonus = false;

            Character monster = new Character ();
            monster.Name = "Monster";
            monster.Health = 21;
            monster.DamageMaximum = 25;
            monster.AttackBonus = true;

            Dice a = new Dice ();

            if(hero.AttackBonus)
            {
                monster.Defend (hero.Attack (a));

            }
            else if(monster.AttackBonus)
            {
                hero.Defend (monster.Attack (a));

            }
            
            while(hero.Health > 0 || monster.Health > 0)
            {
                int damage = hero.Attack (a);
                monster.Defend (damage);

                damage = monster.Attack (a);
                hero.Defend (damage);


                printStats (hero);
                printStats (monster);
            }
            displayMesage (hero, monster);

        }

        private void displayMesage(Character a,Character b)
        {
            if(a.Health <= 0)
                Label1.Text += string.Format ("The winner is {0}.", b.Name);
            else if(b.Health <= 0)
                Label1.Text += string.Format ("The winner is {0}.", a.Name);
        }

        private void printStats(Character a)
        {
            Label1.Text += String.Format ("<p>Name: {0} - Health: {1} - DamageMaximum: {2} - AttackBonus: {3}</p>",
                   a.Name,
                   a.Health,
                   a.DamageMaximum.ToString (),
                   a.AttackBonus.ToString ());
        }

        class Character
        {
            public string Name { get; set; }
            public int Health { get; set; }
            public int DamageMaximum { get; set; }
            public bool AttackBonus { get; set; }

            public int Attack(Dice a)
            {
                
                a.sides=this.DamageMaximum;
                int damage = a.Roll();
                return damage;
            }

            public void Defend(int damage)
            {
                this.Health -= damage;
            }
        }

        
        class Dice
        {
            public int sides{get;set;}
            Random rand = new Random ();
            public int Roll()
            {
               return  rand.Next (0, this.sides);
                
            }
        }
    }
}