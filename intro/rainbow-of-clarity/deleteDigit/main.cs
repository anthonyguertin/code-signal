int solution(int n) {

  var str = Convert.ToString(n);
  var num = string.Empty;
  
  var l = new List<int>();
  for (var i = 0; i < str.Length; i++) {
    var integer = str[i];
    num = str.Remove(i, 1);
    l.Add(Convert.ToInt32(num));
  
  }
  
  var result = l.Max();
  
  return result;  
}