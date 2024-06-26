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
  
  public int GetAvailableMoves() {

    const int boardLength = 8;

    var x = this.x;
    var y = this.y;
    
    var edge = Convert.ToString(x)+":"+Convert.ToString(y);
    
    var mirrorX =x;
    var mirrorY =y;
    if (x > 4) {
        Console.WriteLine("x is:" + x);
        mirrorX = (x - boardLength)*-1;
        if (x != 5) mirrorX+=1;
        if (x == 4) mirrorX-=1;
        edge = mirrorX+":"+mirrorY;
    }
    if (y > 4) {
        mirrorY = (y - boardLength)*-1;
        if (y != 5) mirrorY+=1;
        if (y == 4) mirrorY-=1;
        edge = Convert.ToString(mirrorX+":"+ mirrorY);
    }
    Console.WriteLine(edge);
    switch (edge)
    {
        case "1:1":
            return 2;
        case "2:1":
        case "1:2":
            return 3;
        case "1:3":
        case "3:1":
        case "2:2":
            return 4;
        case "4:2":
        case "2:4":
        case "3:2":
        case "2:3":
            return 6;
        case "1:4":
        case "4:1":
            return 4;
        default:
            return 8;
    }
  }
}

int solution(string cell) {
    var knight = new Pos(cell);

    return knight.GetAvailableMoves();
}