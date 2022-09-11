function printReverseNo()
{
    var sum = 0,r, n=12356;
    while (n>0)
    {

        r = n%10;
        n = parseInt(n / 10);
       sum=sum*10+r;
            
    }
    console.log(sum);
            
}
printReverseNo();
