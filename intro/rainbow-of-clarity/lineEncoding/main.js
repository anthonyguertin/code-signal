const { forEach } = require("lodash");

function solution(s) {
var disjoint = []

var current = ""
var last = ""
var index = 0

  for (var i = 0; i < s.length; i++) {
    current = s[i]

    if (last != "" && last != current) {
      
      disjoint.push(s.substring(index, i))
      index = i
      
    }
    if (i == s.length-1) {
      disjoint.push(s.substring(index, s.length))
    }
    last = current
  }
  
  if (disjoint.length == 1 && s.length > 1) { return s.length+s[0] }
  var result = ""
  disjoint.forEach(strnValue => result += strnValue.length==1? strnValue : strnValue.length+strnValue[0])
  disjoint.forEach(strnValue => console.log(strnValue))
  return result;
}