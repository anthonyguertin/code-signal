string cleanWord(string word) {
  
  var cw = string.Empty;
  foreach(var l in word) {
    if (char.IsLetter(l)) {
      cw+=l;
    } 
  }
  
  return cw;
}

string solution(string text) {

var reg = new Regex("[^a-zA-Z]");
var words = reg.Replace(text, " ");

var newWords = words.Split(" ");

foreach(var w in newWords) Console.WriteLine(w);
var cleanWords = new string[newWords.Length];

for (var i = 0; i < newWords.Length; i++)
{
  cleanWords[i] = cleanWord(newWords[i]);
}
var longestWord = cleanWords.MaxBy(s => s.Length);


if(string.IsNullOrEmpty(longestWord)) {Console.WriteLine("result is null, returning empty"); return string.Empty; }

return longestWord;
// var start = 0;
// var end = 0;
// var wordlist = new List<string>();
// for ( var i =0 ; i < text.Length; i++) {
//  if (Char.IsLetter(text[i])){ 
   
//    start = i;
//    } else { }
//    else { end = i;    wordlist.Add(text.Substring(i,end-start));}
//    Console.WriteLine("start: " + start +"\n" + "end:" + end);
   
//    if (end == 0) end =1;

   
// }
// wordlist.ForEach(word => Console.WriteLine(word));

// return string.Empty;
}