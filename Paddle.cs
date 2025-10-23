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

        public void Move(int yAmount)
        {
            y += yAmount;
        }

        public void Draw(int x, int y)
        {
                 int i = 1;
                Console.SetCursorPosition(x, this.y + i );
                Console.Write("|");
           
        }


        /*  public Paddle(int x, int y, int size)
          {
              this.x = x;
              this.y = y;
              this.size = size;
          }

          */






        /*
         x av typen int som representerar spelarens x-position.
         y av typen int som representerar spelarens y-position.
         size av typen int som representerar spelarens storlek.
        
         
         */
    }
}
