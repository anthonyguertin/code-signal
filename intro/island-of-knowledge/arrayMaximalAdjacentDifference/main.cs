int solution(int[] inputArray) {
    var distinction = 0;
    List<int> distinctions = new List<int>();
    for (var i = 1; i < inputArray.Length; i++) {
        distinction = inputArray[i] - inputArray[i-1];
        distinction = distinction < 0 ? distinction*-1:distinction;
        distinctions.Add(distinction);
    }
    foreach(var i in distinctions) {
        Console.WriteLine(i);
    }
    return distinctions.Max();
}