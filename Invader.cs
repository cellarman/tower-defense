namespace TowerDefense 
{
  class Invader
  {
    
    private readonly Path _path;
    private int _pathStep = 0;   //will change over time, so not to make it read-only
    
    public MapLocation Location => _path.GetLocationAt(_pathStep);
    
    public int Health {get; private set; } = 2;
    
    //True if the invarded has reached the end of the path
    
    
    public bool HasScored  { get {return _pathStep >= _path.Length; } }
    
    public bool IsNeutralized => Health <=0;
    
    public bool IsActive => !(IsNeutralized || HasScored);
    
      
       public Invader(Path path)      //add constructor
    {
       _path = path;
    }
                   
    public void Move() => _pathStep +=1;       //move function should only advance it one step
   
    public void DecreaseHealth(int factor)
    {
        Health -= factor; 
     
    }
    
  }
}