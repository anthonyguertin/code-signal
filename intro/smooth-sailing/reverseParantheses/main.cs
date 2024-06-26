string solution(string inputString)
{
    var lPList = new List<int>();

    for (var i = 0; i < inputString.Length; i++)
    {
        if (inputString[i] == ')') lPList.Add(i); 
    }

    var removalCount = 0;
    for (var i = 0; i < lPList.Count; i++)
    {
        var idx = lPList[i];
        var rString = string.Empty;

        for(var j = idx; j >= 0; j--)
        {
            var jdx = j - removalCount;
            rString += inputString[jdx];

            if (inputString[jdx]=='(')
            {
                rString = rString.Remove(0, 1);
                rString = rString.Remove(rString.Length - 1, 1);

                inputString = inputString.Remove(jdx, idx+1-j);
                inputString = inputString.Insert(jdx, rString);
                removalCount += 2;
                break;
            }
        }
    }

    return inputString;
}

string ReverseString(string str)
{
    char[] cStr = str.ToCharArray();
    Array.Reverse(cStr);
    return new string(cStr);
}