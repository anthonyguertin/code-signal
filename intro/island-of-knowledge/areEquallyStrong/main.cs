bool solution(int yourLeft, int yourRight, int friendsLeft, int friendsRight) {
var lSum = (yourLeft+yourRight)/2.00 ;
var rSum = (friendsLeft+friendsRight)/2.00;
    if (lSum == rSum) {
        if (yourLeft == friendsLeft || yourLeft == friendsRight) return true;
        if (yourRight == friendsLeft || yourRight == friendsRight) return true;
    }
return false;
}