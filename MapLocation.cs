using System;

namespace Tower_Defense{

    class MapLocation : Point

    {

        public MapLocation(int x, int y, Map map) : base(x , y)
        {

            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + "," + y + "is outside the boudaries of the map.");
            }
        }

        public bool InRangeOf(MapLocation location, int range)
        {
            return DistTo(location) <= range;

        }
    }



}