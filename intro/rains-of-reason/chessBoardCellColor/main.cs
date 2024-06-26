// The board starts at "a1" - bottom left hand corner
// The first colored square on the board is black
// On the y-axis (going up), the checker pattern alternates to white
// On the x-axis (going up), the checker pattern alternates to white

bool isOdd(int num) {
 return num%2 == 0 ?false : true;    
}
bool GetCellColor(int x, int y){
    
    bool cellColor = false;
    if (!isOdd(x)){
        cellColor = false;
        if (isOdd(y)) cellColor = false;
    }
    if(isOdd(x)){
        cellColor = true;
        if(!isOdd(y)) { cellColor=false;}
    }
    
    if (!isOdd(x)) {
        if(!isOdd(y)) {
            cellColor=true;   
        }
    }
    return cellColor;
}
bool solution(string cell1, string cell2) {
    var y = 0;
    var x = GetPos(cell1, ref y);
    Console.WriteLine("cell1 position x = "+ x);
    Console.WriteLine("cell1 position y = " + y);
    var cellColor = GetCellColor(x,y);
    
    Console.WriteLine("The cell's color:"+cellColor);
    
    y = 0;
    x = GetPos(cell2, ref y);
    
    Console.WriteLine("cell2 position x= "+ x);
    Console.WriteLine("cell2 position y= "+ y);
    var cellColor2 = GetCellColor(x,y);
    Console.WriteLine("The cell's color:"+cellColor2);
    
    return cellColor == cellColor2;
}

int GetPos(string letter, ref int y) {
   
    var c = letter.Remove(0,1);
    var x = letter.Remove(1,1);
    Console.WriteLine("the cell " + letter);
    Console.WriteLine("y after stripping string : " + c);
    y=Convert.ToInt32(c);
    var result = 0;
    
    switch(x) {
     case  "A":
     result = 1;
     break;
     
     case "B":
     result = 2;
     break;
     
     case "C":
     result=3;
     break;
     
     case "D":
     result=4;
     break;
          
     case "E":
     result=5;
     break;
     
     case "F":
     result = 6;
     break;
     
     case "G":
     result = 7;
     break;

     case "H":
     result=8;
     break;        
    }   
    
    return result;
}


    // bool[,] board = new bool[8,8];
    // var w = false;
    // var b = true;
    
    // for (var i = 0; i < board.Length -1;i++) {
    //     if (i%2 == 0 ) {
    //     for (var z =0; z < board.Length -1; z++) {
    //         if (z % 2 == 0 ) {
    //             board[i,z] = w;
                
    //         } else {
    //             board[i,z] = b;   
    //         }
    //     }
    //     } else {
    //         for (var z =0; z < board.Length -1; z++) {
    //         if (z % 2 == 1 ) {
    //             board[i,z] = b;
                
    //         } else {
    //             board[i,z] = w;   
    //         }
    //     }
            
    //     }
    //     var v  = GetPos(cell1);
    //     var h = GetPos(cell2);
        
    //     var x = v % 2 == 0 ? 0 : 1;
        
    // }