using System;
using static System.Math;


namespace TowerDefense
{
  
  class Point
  {
    public readonly int X;
    public readonly int Y;
    
      public Point(int x, int y)
      {
        X = x;  //attributes
        Y = y;
        
      }
    
    
    
      public int DistanceTo(int x, int y)
      {
       /* int xDiff = X - x;
        int yDiff = Y - y;
        
        int xDiffSquared = xDiff * xDiff;
        int yDiffSquared = yDiff * yDiff;
        
        return (int)Math.Sqrt(xDiffSquared + yDiffSquared); */
        
        return (int)Math.Sqrt(Math.Pow(X-x,2) + Math.Pow(Y-y, 2));
        
      }
    
       // Overloaded methods
        public int DistanceTo(Point point)
        {
            return DistanceTo(point.X, point.Y);
        }
    
    
    
  }
  
}