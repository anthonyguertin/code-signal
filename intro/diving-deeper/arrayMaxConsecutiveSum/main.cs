///int solution(int[] inputArray, int k) {

//var result = new List<int>();
////var r = new int[1000000];

//for (var i = 0; i < inputArray.Length; i++) {
 // var sum = 0;
 // if (i+k > inputArray.Length) break;
//  r[i] = Enumerable.Range(i, i+k).Sum();
  //for (var j =i;j<i+k;j++) {
  //  sum += inputArray[j];
  //}
  //result.Add(sum);
  //r[i]=sum;
  
  //Console.WriteLine(sum);
 // if (i + k > 100000) break;
  //result.Add(inputArray[i] + inputArray[i+1]);
//}
//result = r.ToList();
//return r.Max();
//}
int solution(int[] inputArray, int k) {
    int sum = 0, r = 0;
    for (int i = 0; i < inputArray.Length ; i++)
    {
        sum += inputArray[i];
        if (i >= k - 1)
        {
            r = Math.Max(r, sum);
            sum -= inputArray[i - k + 1];
        }
    }
    return r;
}