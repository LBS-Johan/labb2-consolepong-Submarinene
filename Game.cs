
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

        public void StartGame()
        {
            // Setup konsol-fönstret
            width = Console.WindowWidth;
            height = Console.WindowHeight;
            Console.CursorVisible = false;

            
        }

        public Paddle p1 = new Paddle();
        public Paddle p2 = new Paddle();



        public bool Run()
        {
            //Töm hela skärmen i början av varje uppdatering.
            Console.Clear();

            p1.Draw(110,5);
            p2.Draw(10,5); 

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
