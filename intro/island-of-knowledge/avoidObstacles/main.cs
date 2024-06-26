int solution(int[] inputArray) {
    for (var i = 2; i < inputArray.Max(); i++) {
        var divs = inputArray.Any(x => x % i == 0);
        if (!divs) // if not The Adversary 
            return i;
    }
    
    return inputArray.Max() + 1;
}