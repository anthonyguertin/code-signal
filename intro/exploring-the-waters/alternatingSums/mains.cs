int[] solution(int[] a) {
    var oddSum = 0;
    var evenSum = 0;
    
    for (var i = 0; i < a.Length; i++) {
        if (i % 2 == 1) {
            oddSum+=a[i];
            continue;
        }
        evenSum+=a[i];
    }
    return new int[] {evenSum, oddSum};
}