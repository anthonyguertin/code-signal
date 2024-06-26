int solution(int value1, int weight1, int value2, int weight2, int maxW) {
  var total = weight1 + weight2;
  
  if (value1 == value2) {
   return weight1<weight2 ? value1 : value2; 
  }
  if (weight1 > maxW && weight2 > maxW) return 0;
  
  if (total <= maxW) return value1+value2; 
  
    // CHECK IF EITHER IS OVER MAX WEIGHT
  if (weight1 > maxW || weight2 > maxW) {
    // TAKE ITEM 2 
    if (weight1> maxW) {
      return value2;
    }
        // TAKE ITEM 1
    if (weight2> maxW) {
     return value1; 
    }
  }
  
  if (total > maxW) {
    if (value1>value2)
      return value1;
      
    if (value2>value1) {
        return value2; 
    }
  } 

  return 0;    
  }