bool solution(string time) {
  var hourStr = time.Substring(0,2);
  var minuteStr = time.Substring(3,2);
  
  var hour = Convert.ToInt32(hourStr);
  var minute = Convert.ToInt32(minuteStr);
  
  var result = (hour >= 0) && (hour < 24) && (minute >= 0) && (minute < 60);
 
  return result;
}