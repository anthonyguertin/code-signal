  public class Pos {
  public int x {get; set;}
  public int y {get; set;  }
  public bool onBlack =false;
  private static Dictionary<char, int> letterMap = new Dictionary<char, int>() {
  {'a', 1},{'b', 2},{'c', 3},{'d', 4},{'e', 5},{'f', 6},{'g', 7},{'h', 8} };
  
   public Pos(string piece) {
     var letter = piece[0];
     Console.WriteLine("LETTER:" + letter);
     if (letterMap.ContainsKey(letter)) 
      x = letterMap[letter];
     y = Convert.ToInt32(Convert.ToString(piece[1]));
  }
  
  public void SetSpotColor() {
    
    if (this.x % 2 == 1) 
      if (this.y % 2 == 1) this.onBlack = true;
    
    if (this.x % 2 == 1)
      if (this.y % 2 == 0) this.onBlack = false;
    
    if (this.x % 2 == 0)
      if (this.y % 2 == 1) this.onBlack = false;
    
    if (this.x % 2 == 0)
      if(this.y % 2 == 0) this.onBlack = true;
    
    if (this.y % 2 == 1) 
      if (this.x % 2 == 0) this.onBlack = false;
    
    if (this.y % 2 == 1)
      if (this.x %  2 == 1) this.onBlack = true;
      
    if (this.y % 2 == 0)
      if (this.x % 2 == 1) this.onBlack = false;
      
    if (this.y % 2 == 0)
      if(this.x % 2 == 0) this.onBlack = true;
  }
}

bool solution(string bishop, string pawn) {

  var b = new Pos(bishop);
  var p = new Pos(pawn);
  
  b.SetSpotColor();
  p.SetSpotColor();
  
  if (b.x == p.x) return false;

  if (b.y == p.y) return false;


  if ((b.onBlack && !p.onBlack) || (!b.onBlack && p.onBlack)) return false;

  if (b.onBlack && p.onBlack) {
    
    Console.WriteLine("b.x :" + b.x);
    Console.WriteLine("p.x :" + p.x);
    
    Console.WriteLine("b.y :" + b.y);
    Console.WriteLine("p.y :" + p.y);

   return true;
  }
  
  if (!b.onBlack && !p.onBlack) return true;

  return false;
}