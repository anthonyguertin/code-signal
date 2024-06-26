function solution(str) {
    
    var resArr = [];
    var str = sortString(str);
    console.log(str);
    for (var i = 0; i < str.length; i++) {
        if (resArr.includes(str[i])) {
            resArr.pop();
            continue;
        }
        resArr.push(str[i]);
    }
    
    console.log(resArr);
    
    return resArr.length <= 1;
}
function sortString(str){
  var arr = str.split('');
  var tmp;
  for(var i = 0; i < arr.length; i++){
    for(var j = i + 1; j < arr.length; j++){
      /* if ASCII code greater then swap the elements position*/
      if(arr[i] > arr[j]){
        tmp = arr[i];
        arr[i] = arr[j];
        arr[j] = tmp;
      }
    }
  }
  return arr.join('');
}
    
/*
function sortString(strArray) {
    var i = 0;
    var j =0;
    while (i < strArray.length) {
    j = i + 1;
    while (j < strArray.length) {
    if (strArray[j] < strArray[i]) {
        var tempStr = strArray[i];
        strArray[i] = strArray[j];
        strArray[j] = tempStr;
    }
    j++;
    }
    i++;
    }
}
function sortString(str) {
    var res = str;
    for (var i = 0; i < str.length-1; i++) {
        // get position of the string adjacent( --> )to the same char in selected position
        var cPos = substring(i+1, str.length).indexOf(str[i]);
        res+=str[i];
        if (cPos != -1) {
             res += str[cPos];
        }
    }
    
    
    
}*/