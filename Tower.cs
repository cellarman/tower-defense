using System;

namespace TowerDefense 
{
  class Tower
  {
    
    
    private const int _range = 1;
    private const int _power = 1; 
    private const double _accuracy = .75;
    
    private static readonly Random _random = new Random();                    //only tower class will use it
    
    
    
    private readonly MapLocation _location;
    
    public Tower(MapLocation location)
    {
       _location = location;
    }
    
    public bool IsSuccessfulShot()
    {
        return _random.NextDouble() < _accuracy;      
    }
    
    public void FireOnInvaders(Invader[] invaders)
    {
          
      for(int index = 0; index < invaders.Length; index++)
      {
        Invader invader = invaders[index];
        // Do stuff with invader
      }
      
      foreach(Invader invader in invaders)
      {
        
        
        if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
        {
          
          if(IsSuccessfulShot())
          {
              invader.DecreaseHealth(_power); 
            
            if(invader.IsNeutralized)
            {
             Console.WriteLine("Neutralized an invader!");  
              
            }
          }
          else
          {
           Console.WriteLine("Shot at and missed an invader.");
            
          }
          
          
          break;
          
        }
      }
      
      
    }
    
    
  }
}