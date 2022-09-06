function printPrime()
{
    var n=7;
    var count = 0;
    for (var i=1;i<=n;i++)
    {
        if (n%i ==0)
        {
            count++;
        }
    }
    if (count==2)
    {
        console.log("{0} is prime Number",n);
    }
    else
    {
        console.log("{0} is Not Prime Number",n);
    }
         
}
printPrime();
