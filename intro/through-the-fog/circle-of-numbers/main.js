function solution(n, firstNumber) {
    
    var r = n/2;
    
    var circ = (2 * Math.PI * r);
    var quadDividen = circ/(firstNumber+r);
    var newNum=quadDividen*7;
    
    console.log("newNum (quadDividen*7) : " + newNum);
    console.log("quadDividen :" + quadDividen);
    console.log("radius: "+ r);
    console.log("circ: " + circ);
    
    //var quadDividen =  
    var numberAtAdjacentLocation = firstNumber + r;
    for (var i = 0; i < n+1; i++)
    {
         var numberGap = quadDividen;
         var numberAtLocation = i*quadDividen;
         
         console.log(`number at location ${i}: ` + numberAtLocation); 
    }
    var result = numberAtAdjacentLocation;
    if (numberAtAdjacentLocation>=n) {
        var result = numberAtAdjacentLocation - (n);
        console.log("result: " + result);   
        return result;
    }
    
    return result;
}