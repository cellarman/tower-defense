
namespace TowerDefense
{
    class TowerDefenseException : System.Exception
    {
      
      
        public TowerDefenseException()
        {
        }
      
        public TowerDefenseException(string message) : base(message)
        {
          
        }
    }
  
  class OutOfBoundsException: TowerDefenseException  //inherits from above
  {
    
      public OutOfBoundsException()
      {
      }
      
    
      public OutOfBoundsException(string message) : base(message)
      {
      }
  }
  
}