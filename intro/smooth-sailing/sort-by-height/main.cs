int[] solution(int[] a) {
    var aList = a.ToList();
    
    var treeIdx = new List<int>();
  
    for (var i = 0; i < aList.Count(); i++) {
        if (aList[i] == -1) 
        {
            treeIdx.Add(i + treeIdx.Count());
            aList.RemoveAt(i);
            i--;
        }
    }

    var sortedAscending = aList.ToArray();
    Array.Sort(sortedAscending);
    aList = sortedAscending.ToList();
    
    for (var i = 0; i < treeIdx.Count(); i++) {
        aList.Insert(treeIdx[i], -1);
    }
    
    return aList.ToArray();
}