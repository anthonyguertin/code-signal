int solution(int n) {
  var strN = Convert.ToString(n);
  var temp = strN;
  
  if (n < 10) return 0;
  
  var result = n;
  var counter =0;
  
  while (result >=10) {
    var sum = 0;
    for(var i =0; i< temp.Length;i++) {
      Console.WriteLine(temp);
      var num = Convert.ToInt32(Convert.ToString(temp[i])); 
      sum+=num;
    }
    Console.WriteLine("sum:" + sum);
    counter++;
    
    result = sum;
   // sum = 0;
    var newStr = Convert.ToString(sum);
    temp = newStr;
    
    if (result <10) {
     break; 
    }

  }
 return counter; 
}

// int solution(int n) {
//   var strN = Convert.ToString(n);
//   //Console.WriteLine("string after conversion: " +strN);
//   if (n < 10) return 0;
  
//   var result = recursion(strN,1);
     
//      return result;
//   }
   
  
//   int recursion(string str, int counter) {
   
//    var sum = 0;

//    for(var i =0; i< str.Length;i++) {
//     var num = Convert.ToInt32(Convert.ToString(str[i])); 
    
//     sum+=num;
//    }
  

//    var newStr = Convert.ToString(sum);
//    Console.WriteLine("new string: " + newStr);
   
//    if (sum >= 10){ 
//      counter++;
//      recursion(newStr,counter);
     
//    }
   
//    return counter;
//   }


