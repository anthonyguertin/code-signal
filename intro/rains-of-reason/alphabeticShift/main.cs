string solution(string inputString) {
  var key = "abcdefghijklmnopqrstuvwxyz";
  var key2 = "abcdefghijklmnopqrstuvwxyz";
  var result = string.Empty;
 /*
  for ( var i = 0; i < inputString.Length; i++) {
      var k = key.IndexOf(inputString[i]);
      var replacement = k == 25 ? 'a' : key[k+1];

      result+= Convert.ToString(replacement);
      Console.WriteLine(result);
  }*/
    for ( var i = 0; i < inputString.Length; i++) {
      var k = key2.IndexOf(inputString[i]);
      var replacement = k == 25 ? 'a' : key2[k+1];

      result+= Convert.ToString(replacement);
      
  }
  Console.WriteLine(result);
  return result;
}