int solution(string s) {

var charList = new List<string>();

for (var i = 0; i < s.Length; i++) {
 if (charList.Contains(s[i].ToString())) continue;
  
  charList.Add(s[i].ToString());
}

return charList.Count();
}