bool solution(int[] sequence) 
{
    
    int leftMax = sequence[0];
    int leftMaxIndex = 0;
    int removed = 0;
    
    for(int i=1; i<sequence.Length; i++)
    {
        if(sequence[i]<=leftMax)
        {
            //need to remove leftMax
            if(removed >= 1)
                return false;
            //no items has been removed before
            if(leftMaxIndex > 0)
            {
                if (sequence[i] > sequence[leftMaxIndex-1])
                {
                    leftMax = sequence[i];
                    leftMaxIndex = i;
                }
            }
            else
            {
                leftMaxIndex = i;
                leftMax = sequence[i];
            }
            removed += 1;
        } 
        else
        {
            leftMaxIndex = i;
            leftMax = sequence[i];
        }
    }
    return true;
}