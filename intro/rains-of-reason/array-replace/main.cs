int[] solution(int[] inputArray, int elemToReplace, int substitutionElem) {
    var result = inputArray;
    for (var i = 0; i < inputArray.Length; i++) {
       
        if (elemToReplace == inputArray[i]) {
               result[i] = substitutionElem;
        }
    }
    
    return result;
}