using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TcpIpDemo
{
    class Monster
    {
        private int _HP;
        private int _MP;
        private string _NAME;

        public int HP { get { return _HP; } }
        public int MP { get { return _MP; } }
        public string Name { get { return _NAME; } }

        public Monster(string name,int hp,int mp)
        {
            _HP = hp;
            _MP = mp;
            _NAME = name;
        }

        public void BeAttacked(int hp)
        {
            _HP -= hp;
        }

        public void Attack(int mp)
        {
            _MP -= mp;
        }

        
    }
}
