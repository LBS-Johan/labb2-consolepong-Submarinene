
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Labb2_ConsolePong
{
    internal class Game
    {
        int width;
        int height;

        Paddle p1;// = new Paddle();
        Paddle p2;// = new Paddle();
        Ball ball;
        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;
            p1 = new Paddle(110, 5, 5);
            p2 = new Paddle(5, 5, 5);
            ball = new Ball(55, 5, 1, 1);

        }





        public bool Run()
        {
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();

            p1.Draw();
            p2.Draw();
            ball.CheckCollisions(p1, p2, width, height);
            ball.Move();
            ball.Draw();


            if (Input.IsPressed(ConsoleKey.UpArrow))
            {
                p1.Move(-1);  //Flytta spelare 1 uppåt
            }
            if (Input.IsPressed(ConsoleKey.DownArrow))
            {
                p1.Move(+1);  
                //Flytta spelare 1 nedåt
            }

            if (Input.IsPressed(ConsoleKey.W))
            {

                p2.Move(-1);
                //Flytta spelare 2 uppåt
            }
            if (Input.IsPressed(ConsoleKey.S))
            {
                p2.Move(+1);
               
                //Flytta spelare 2 nedåt
            }



            //Return true om spelet ska fortsätta
            return true;

        }
    }
}
