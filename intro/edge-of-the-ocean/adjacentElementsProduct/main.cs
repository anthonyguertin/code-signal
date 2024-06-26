int solution(int[] inputArray) {
    var productList = new List<int>();
    
    int product;
    for (var i = 0; i < inputArray.Length - 1; i++) {
        
        var currentValue = inputArray[i];
        // end
        if (i == inputArray.Length - 1) { // We are at the end
            break;
        }
        var nextValue = inputArray[i+1];
        
        // middle
        product = nextValue * currentValue;
        productList.Add(product);
    }
    return productList.Max();
}
