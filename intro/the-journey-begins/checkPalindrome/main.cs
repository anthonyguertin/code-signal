bool solution(string inputString) {
    // Odd
    if (inputString.Length == 1) return true;

        var indexOfEnd = inputString.Length -1;
        for (var i = 0; i < inputString.Length -1; i++) {
            var letter1 = inputString[i];
            var letter2 = inputString[indexOfEnd];
            
            indexOfEnd = indexOfEnd -1;
            if (inputString.Length % 2 == 1 && i == inputString.Length /2 -1) {
                Console.Write(inputString[inputString.Length/2 -1]);
                return true;
            }
            if (letter1 != letter2)
                return false;
        }   
    
    return true;
}
