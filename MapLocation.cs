namespace TowerDefense
{
    class MapLocation : Point
    {
      
       // calling protected constructor
        protected MapLocation(int x, int y) : base(x, y)
        {}
      
      
        // Input validation / contract verification
        public MapLocation(int x, int y, Map map) : this(x, y)   //calling base class
        {
            if (!map.OnMap(this))
            {
                throw new OutOfBoundsException(x + "," + y + " is out of bounds of the map.");
            }
        }
      
      public bool InRangeOf (MapLocation location, int range)
      {
        
        return DistanceTo(location) <= range;
        
      }
      
    }
  
}