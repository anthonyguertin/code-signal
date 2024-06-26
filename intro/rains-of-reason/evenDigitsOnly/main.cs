bool solution(int n) {
    var str = Convert.ToString(n);
    foreach(var c in str) {
       var i = Convert.ToInt32(c);
       if (i%2 ==1) return false;
    }
    
    return true;
}