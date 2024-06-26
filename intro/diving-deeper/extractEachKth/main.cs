int[] solution(int[] inputArray, int k) {
    var kth = k;

    var result = new List<int>();
    var kList = new List<int>();

    do
    {
        kList.Add(kth);

        kth = kth +k;
        if (kth > inputArray.Length) { break; }
    } while (kth <= inputArray.Length);

    if (kList.Max() > inputArray.Length) return inputArray;
    var inputArrayList = inputArray.ToList();

    foreach (var j in kList) inputArrayList[j-1] = 21;
    
    inputArrayList.RemoveAll(p => p == 21);

    return inputArrayList.ToArray();
}