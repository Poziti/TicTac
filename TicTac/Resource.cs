using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTac
{
    class Resource
    {
        private int state = 1;

        public int getState() { return state; }

        public void Tic(int i){
            Console.Write((i+1).ToString() + " Tic-");
            state = 2;
        }
        public void Tuc()
        {
            Console.Write("Tuc-");
            state = 3;
        }
        public void Tak(){
            Console.WriteLine("Tak");
            state = 1;
        }
    }
}
