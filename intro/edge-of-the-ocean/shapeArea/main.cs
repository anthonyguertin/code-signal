int solution(int n) {
    var offSet = n - 1;
    var height = n + offSet;
    
    if (n == 1) return 1;
    return height * n - offSet;
}