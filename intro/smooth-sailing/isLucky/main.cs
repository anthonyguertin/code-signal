bool solution(int n) {
    var strN = n.ToString();
    
    var mid = strN.Length / 2;
    var sum1 = 0;
    var sum2 = 0;

    if (strN.Length % 2 == 1 ||strN.Length == 0) { return false; }

    for ( var i = 0; i < mid; i++) {
        sum1+=(int) strN[i];
        sum2+=(int) strN[mid+i];
    }

    return sum1 == sum2;
}