using System;

namespace Tower_Defense
{

    class Map
    {
        public readonly int Width; //instance variables
        public readonly int Height;

        public Map(int width, int height)      // initialization using constructors
        {
            Width = width;
            Height = height;
        }

        public bool OnMap(Point point) //method 
        {
            return point.xCord >= 0 && point.xCord < Width 
                   && point.yCord >= 0 && point.yCord <Height;


        }

    }


}