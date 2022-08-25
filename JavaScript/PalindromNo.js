function printPalindrom()
{
    var r, n=121, sum = 0;
               var t = n;
            while (n>0)
            {
                 r = n % 10;
                sum = sum * 10 + r;
                n = parseInt(n/10);
                    
            }
            if(t==sum)
            console.log("Palindrome Number");
            else
                console.log("Not Palindrome Number");
}
    printPalindrom();
