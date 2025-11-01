using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Paddle
    {
       public int x = 5;
       public int y = 5;
       public int size = 5;

        public Paddle(int x, int y, int size)
        {
            this.x = x;
            this.y = y;
            this.size = size;
        }

        public void Move(int yAmount)
        {
            //prevent paddle from moving outside screen
            var tempY = y + yAmount;
            if (tempY >= 25 || tempY <= -1) //kom ihåg att räkna in storleken nedåt här!!
                return;

            y += yAmount;
        }

        public void Draw()
        {
            //int i = 1;
            for(int i= 0; i < size; i++)
            {
                Console.SetCursorPosition(this.x, this.y +i);// + i );
                Console.Write("|");
            }


           
        }


          

          






        /*
         x av typen int som representerar spelarens x-position.
         y av typen int som representerar spelarens y-position.
         size av typen int som representerar spelarens storlek.
        
         
         */
    }
}
