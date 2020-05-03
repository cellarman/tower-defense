namespace TowerDefense 
{
  class Path
  {
    
    private readonly MapLocation [] _path;  //user underscore for private field, helpful distingushing between instance and method variable
    
    public int Length => _path.Length;
    
    //constructor  bare minimum
    public Path(MapLocation[] path)
    {
      _path = path;
      //Above is the same as this.path = path
    }
    
    public MapLocation GetLocationAt(int pathStep)
    {
      return (pathStep < _path.Length) ? _path[pathStep] : null;   
    }
  }     
  
}                         