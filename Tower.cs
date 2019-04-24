using System;

namespace Tower_Defense
{

    class Tower 
    {
        
        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;
        private static readonly System.Random _random = new System.Random();
        private readonly MapLocation _location;

        public Tower(MapLocation location, Path path)
        {
            for (int i = 0; i < path.Length; i++)
            {
                MapLocation towerPath = path.GetLocationAt(i);

                if (location.xCord == towerPath.xCord && location.yCord == towerPath.yCord)
                {
                    throw new OutOfBoundsException("towers cannot be placed on the path");
                }
                else
                {
                    _location = location;        
                    
                }
               
            }
        }

        public Tower (MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return _random.NextDouble() < _accuracy;
        }
        public void FireOnInvaders(Invader[] invaders)
        {
            
           
            for (int index = 0 ; index < invaders.Length; index++)
            {
                Invader invader = invaders[index];
                //do stuff with invader here
            }

            foreach (Invader invader in invaders)
            {
                if(invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);
                        Console.WriteLine("Shot at, hit an invader");
                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("invader dead");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Shot at, hit an invader");
                    }
                    break;
                }
            }
        }
        

    }


}