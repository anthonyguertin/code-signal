int solution(int[][] matrix) {
    var sum = 0;
    bool[] isHaunted= new bool[matrix[0].Length];
    
    for (var i = 0; i < matrix.Length; i++) {

        for (var j = 0; j < matrix[i].Length; j++) {

           if ( matrix[i][j] == 0 )  { isHaunted[j] = true; }
           if (!isHaunted[j]) {
            sum += matrix[i][j];
           }
        }
    }
    
    return sum;
}