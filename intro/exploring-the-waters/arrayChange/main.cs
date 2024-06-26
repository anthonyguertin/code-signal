int solution(int[] inputArray) {
    var moves = 0;
    
    for(var i = 1; i < inputArray.Length; i++) {
        var c = inputArray[i];
        var l = inputArray[i-1];
        if (c <= l) {
            var val = l - c + 1;
            moves += val;
            inputArray[i] += val;
        }
    }
    return moves;
}