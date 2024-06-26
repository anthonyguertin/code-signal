bool solution(string str) {
    if (str == "" || str == null) return false;
    var bytes = str.Split('.');
    var maxByteCount = 4;
    if (bytes.Length != maxByteCount) return false;
    var minIpv4CharCount = 7;
    
    
    List<int> resultList = new List<int>();
    Regex r = new Regex("^[0-9]+$");
    
    if(str[0] == '.') return false;
    foreach(var bite in bytes) {
       // if (!byte.TryParse(bite, out byte result)) return false;
        
        Console.WriteLine(bite);
        if (bite.Length > 3) return false;
        if (bite.Contains("00") && !bite.Contains("100")
             && !bite.Contains("200")) return false;
        if (bite.Length > 1 && bite[0] == '0') return false;
        if (!r.IsMatch(bite)) return false;
        if (bite != null) resultList.Add(Convert.ToInt32(bite)); else return false;
    }
    
    if (resultList.Max() >= 0 && resultList.Max() <= 255 && str.Length >= minIpv4CharCount) 
        return true;
    
    return false;
}