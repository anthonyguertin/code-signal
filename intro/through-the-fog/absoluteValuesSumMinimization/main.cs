int solution(int[] a) {
    var absList = new List<int>();
    for (var i =0;i<a.Length; i++) {
        var x = a[i];
        int sum = 0;
        for (var j = 0; j < a.Length; j++) {
            var abs = a[j] - x;
            if ( abs < 0) abs = abs * -1;
            sum+=abs;
            
            
        }
        absList.Add(sum);
    }
    
    var minValue = absList.Min();
    var index = absList.IndexOf(minValue);
    
    return a[index];
}


// sorted array of integers

// 1 , 3, 7, 9

// unsorted array of integers

// 3, 1, 9, 7


//absolute value is a positive number because it is the distance away from zero