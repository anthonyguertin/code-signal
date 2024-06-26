int solution(int upSpeed, int downSpeed, int desiredHeight) {
  
  if (upSpeed >= desiredHeight) return 1;
  
  
  var d = 0;
  var r = 0;
  while(r <= desiredHeight) {
   d++; 
   r = d*upSpeed;
   Console.WriteLine(d);
   r -= (d*downSpeed);
   Console.WriteLine(d+ 1);
   if (r + upSpeed >= desiredHeight) break; 
   
  }
  if(r<=desiredHeight) d++;
  
  return d;
  
  /*
  var d = (upSpeed*desiredHeight-downSpeed*desiredHeight)/upSpeed;
  d-=d%1;
  do {
    if (d < desiredHeight)
    d++;
  } while (d/upSpeed <= desiredHeight);
  
  return d;*/
  
  return 0;
}