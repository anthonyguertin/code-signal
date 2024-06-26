int solution(string s1, string s2) {
    int cnt = 0;
    string largeContainer = string.Empty;
    string smallContainer = string.Empty;
    int val = 0;
    
    if ( s1.Length > s2.Length) { 
        largeContainer = s1;
        smallContainer = s2;
        cnt = s1.Length;
    } else {
        largeContainer = s2;
        smallContainer = s1;
        cnt = s2.Length;
    }
    
    for (var i = 0; i < largeContainer.Length; i++)
    {
        if (smallContainer.Length == 0 ) break;
        
        int idx = smallContainer.IndexOf(largeContainer[i]);
        if (idx != -1) { smallContainer = smallContainer.Remove(idx, 1); val++; }
        
    }
    return val;
}

/*
  var shortestString = s2.Length > s1.Length ? s1 : s2;
    var longestString = s2.Length > s1.Length ? s2 : s1;
    
    var commonChars1 = new List<string>();
    var commonChars2 = new List<string>();
    
    var end = 1;
    
    for (var i = 0; i < shortestString.Length; i++) {
        if (i > 0) {
            
            if (shortestString[i] == shortestString[i-1]) {
                end++;
                continue;
            } else {
                commonChars1.Add(shortestString.Substring(i-end, end));
                end = 0;
            }
        }
    }
    
    for (var i = 0; i < commonChars1.Count; i++) {
       Console.WriteLine(commonChars1[i]); 
    }
    var commonChars = 0;
    
             
    return commonChars;
    */