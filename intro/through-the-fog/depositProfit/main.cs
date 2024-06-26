int solution(int deposit, int rate, int threshold) {
    double f = deposit;
    double r = rate * 0.01;
    
    int years = 0;
    do {
        var interest = f * r;
        f = interest + f;

        years++;
        
    } while(threshold > f);

    return years;
}