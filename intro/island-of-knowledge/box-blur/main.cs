int[][] solution(int[][] image) {
    var r = image.Length;
    var c = image[0].Length;

    var vShifts = r - 3;
    var hShifts = c -3;
    var sum = 0;
    int[][] averages = new int[vShifts][hShifts];
    //console.log(r);
    //console.log(c);
    for (var v = 0; v <= vShifts; v++) {
        for (var s = 0; s <= hShifts; s++) {
            sum=0;
            for (var i = 0; i < r; i++) {
                
                for (var j = s; j < s+3; j++) {
                    
                    sum+=image[i][j];
                    console.log(image[i][j]);
                }
            }
            //console.log(averages);
            averages[v].push(Math.floor(sum/9));
        }
        
    }
        //averages[0].push(Math.floor(sum/9));
        //averages.push(new Array())
        //averages[1].push(11);
    
   // console.log(averages);
    //var result = new Array(new Array());
    //result[0,0].push(1);
    return averages; 
}