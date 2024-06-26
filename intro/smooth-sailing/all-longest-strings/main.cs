string[] solution(string[] inputArray) {
    var longestStrings = new List<string>();
    
    var longestStringSize = inputArray[0].Length;
    Console.WriteLine(longestStringSize);
    for (var i = 0; i < inputArray.Length; i++) {
        if (i > 0)
            if (inputArray[i].Length > inputArray[i-1].Length)
                longestStringSize = longestStringSize > inputArray[i].Length ? longestStringSize : inputArray[i].Length;
    }
    
    for (var i = 0; i < inputArray.Length; i++) {
        if (inputArray[i].Length == longestStringSize) {
            longestStrings.Add(inputArray[i]);
            Console.WriteLine(longestStringSize);
        }
    }
    return inputArray.Length == 1 ?  inputArray : longestStrings.ToArray();
    //return longestStrings.ToArray();
}