namespace TowerDefense 
{
  class Map
  {
    //declare width and height inside the class
    public readonly int Width;
    public readonly int Height;
    
    public  Map (int width, int height)        //constructor
    {
         Width = width;           //attributes
         Height = height;
    }
    
    public bool OnMap(Point point)   //method
    {
      return point.X >= 0 && point.X < Width &&
             point.Y >= 0 && point.Y < Height;
        
      
    }
      
    
  }
}