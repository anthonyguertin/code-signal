int solution(int[] statues) {
    var sortedList = new List<int>();
    sortedList.AddRange(statues);
    sortedList.Sort();
    var neededStatueCount = 0;
    for (var i = 0; i < sortedList.Count; i++) {
        if (i==0)
            continue;
        var currentStatue = sortedList[i];
        var difference = sortedList[i] - sortedList[i-1];
        
        neededStatueCount +=difference -1;
    }
    
    return neededStatueCount;
}