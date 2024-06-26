bool solution(string name) {
  var regEx = "^[a-zA-Z0-9_]*$";

  
  return Regex.IsMatch(name, regEx) && !Char.IsDigit(name[0]);
}