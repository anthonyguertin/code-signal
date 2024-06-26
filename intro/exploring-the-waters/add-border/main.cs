string[] solution(string[] picture) {
    var val = new string[picture.Length + 2];
    var parallelia = "**";
    
    foreach (var l in picture[0]) parallelia+="*";

    for (var i = 0; i < picture.Length; i++) val[i+1] = $"*{picture[i]}*";

    val[0] = parallelia;
    val[picture.Length+1] = parallelia;
    
    return val;
}