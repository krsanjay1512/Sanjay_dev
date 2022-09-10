function printCountDigit()
{
    var count = 0, n=12356;
    while (n>0)
    {
        n = parseInt(n / 10);
        count++;    
    }
    console.log(count);
    
         
}
printCountDigit();
