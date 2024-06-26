bool solution(int[] a, int[] b) {
    
    var idx = compare(a, b);
    if (idx == -1) return true;
    else swap(idx, ref a, ref b);
    return compare(a, b) == -1;
    
}

void swap(int idx, ref int[] a, ref int[] b)
{
    for (var i = idx; i < a.Length; i++)
    {
        for (var j = a.Length - 1; j > 0; j--)
        {
            var val = b[idx];

            if (a[idx] == b[j] && b[j] != a[j])
            {
                b[idx] = b[j];
                b[j] = val;

                return;
            }
        }
    }
}

int compare(int[] a, int[] b)
{
    for (var i = 0; i < a.Length; i++)
    {
        if (a[i] != b[i])
        {
            return i;
        }
    }
    return -1;
}