using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp
{
    public class Player
    {
        private readonly int id;
        private readonly string name;
        private readonly int age;

        public Player(int id, string name, int age)
        {
            this.id = id;
            this.name = name;
            this.age = age;
        }

        public Player(int id, string name)
        {
            this.id = id;
            this.name = name;
            this.age = 0;
        }

        public int GetId()
        {
            return id;
        }

        public string GetName()
        {
            return name;
        }

        public int GetAge()
        {
            return age;
        }

        public Player WhoisElder(Player player)
        {
            if (this.age > player.GetAge())
            {
                return this;
            }
            else
            {
                return player;
            }
        }
    }
}
