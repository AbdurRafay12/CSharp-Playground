using System;

namespace Tower_Defense
{

    class Point
    {
        public readonly int xCord ;
        public readonly int yCord;

    public Point(int x, int y)
    {

        xCord = x;
        yCord = y;
    }



        public int DistTo (int x , int y)
        {

            int xDiff = xCord - x;
            int yDiff = yCord - y;

            int xDiffSquare = xDiff * xDiff;
            int yDiffSquare = yDiff * yDiff;

            return(int) Math.Sqrt(xDiffSquare + yDiffSquare);

            //return (int)Math.Sqrt(Math.Pow(xCord-x, 2) + Math.Pow(yCord-y,2)); does same as above code
            // break the problem into smaller problems that are easier to test and fix
            //refactor it later into something that is easier to read

        }

        public int DistTo(Point point){  // this is caled overloading

            return DistTo(point.xCord, point.yCord);
        }

    }


}