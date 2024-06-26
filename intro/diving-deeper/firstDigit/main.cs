char solution(string inputString) {
  var leftMost = string.Empty;

  foreach(char c in inputString) {

    if (Char.IsDigit(c)) { 
      leftMost = Convert.ToString(c);
      break;
    }
  }

  return Convert.ToChar(leftMost);
}