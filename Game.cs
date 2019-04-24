using System;

namespace Tower_Defense
{
    class Game
    {
        static void Main(string[] args)
        {
    
           Map map = new Map(8 , 5);  // map object

            try
            {
                Path path = new Path (
                    new [] {
                        new MapLocation(0,2,map),
                        new MapLocation(1,2,map),
                        new MapLocation(2,2,map),
                        new MapLocation(3,2,map),
                        new MapLocation(4,2,map),
                        new MapLocation(5,2,map),
                        new MapLocation(6,2,map),
                        new MapLocation(7,2,map)
                    }
                ); 
                //invaders that will attack
                Invader[] invaders = 
                {
                    new Invader (path),
                    new Invader (path),
                    new Invader (path),
                    new Invader (path)
                };
                // setting towers with locations due to lack of gui
                Tower [] towers = 
                {
                    new Tower (new MapLocation(1, 3, map)),
                    new Tower (new MapLocation(3, 3, map)),
                    new Tower (new MapLocation(5, 3, map))
                };

                Level level = new Level (invaders)
                {
                    Towers = towers  // setting tower property right after object is created
                };

                bool playerWon = level.Play();

                Console.WriteLine("Player" + (playerWon? "won" : "lost"));
                

 
            }
            catch (OutOfBoundsException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (TowerDefenseException)
            {
                Console.WriteLine("Unhandled tower defense Exception");
            } 
            catch (Exception ex)
            {
                
                Console.WriteLine("Unhandled Exception" + ex);
            }
          
        }
    }
}
