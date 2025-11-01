using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Ball
    {
        int x = 55; //x-position.
        int y = 5; //y-position.
        int xVelocity = 1; //hastighet i x-led.
        int yVelocity = 1; //hastighet i y-led.

        public Ball(int x, int y, int xVelocity, int yVelocity)
        {
            this.x = x;
            this.y = y;
            this.xVelocity = xVelocity;
            this.yVelocity = yVelocity;
        }


        public void Move()
        {
            x += xVelocity;
            y += yVelocity;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write("o");
        }  

        public void CheckCollisions(Paddle p1, Paddle p2, int width, int height)
        {
            //istället för att hårdkoda limits på vart bollen får vara
            //så bör man ju använda konsolens width och height

            if (y >= height-1 || y <= 1)
            {
                yVelocity *= -1;
            }


               //x == p1.x && y == p1.y
            if ((x == p1.x && (y >= p1.y && y <= p1.y + p1.size)) || 
                (x == p2.x && (y >= p2.y && y <= p2.y + p2.size)))
            {
                Debug.WriteLine("träff");
                xVelocity *= -1;
            }

            if (x >= width-1 || x <= 1)
            {
                x = 55;
                y = 5;
            }

        }

    }
}
