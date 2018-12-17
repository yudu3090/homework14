using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstGame
{
    class Player : Unit
    {

        public Player(int x, int y, string name) : base(x, y, name)
        {

        }
        
        public void StartGame(int p, int t)
        {
            Random rnd = new Random();
            int r; 
            int sum = 0;
            int com = 0;
            int[] count = new int[7];
            int player = 0;
            for (int i = 1; i < p+1; i++)
            {
                for (int j = 1; j < t+1; j++)
                {
                    r = rnd.Next(1, 6);
                    sum += r;
                    Console.WriteLine("Meta zaidejas " + i + ". Liko " + (t - j) + " kartu. Mete: " + r + ". Viso: " + sum);
                }

                if (com < sum)
                {
                   
                    com = sum;
                    player = i;
                    count[player - 1] = com;
                }
                sum = 0;
                
            }
          
            Console.WriteLine("Laimejo " + player + " zaidejas. Jis gavo " + com + " tasku.");
            Console.WriteLine("R - replay, Q - quit, Esc - quit.");

        }


    }
}
