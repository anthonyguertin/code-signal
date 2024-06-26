string clean(string w) {
  var result = string.Empty;  
  foreach(char c in w) {
    if (!char.IsDigit(c)) continue;
    result+=c; 
  }
  return result;
}

int solution(string input) {
  var sum = 0;

  var reg = new Regex("[^0-9]");
  var regExp = reg.Replace(input, " ");
  
  var split = regExp.Split(" ");
  
  foreach(var s in split) {
    var cw = clean(s);
   int result;
   if (int.TryParse(cw, out result)) {
    sum+=result;     
   }
  }
  
  return sum;
}