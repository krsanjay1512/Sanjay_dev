function printPalindrom()
{
    var r, sum = 0,n=123;
              var temp = n;
            while (n>0)
            {
                 r = n % 10;
                sum = sum * 10 + r;
                n = n / 10;
                    
            }
            if(temp==sum)
            console.log("Palindrome Number");
            else
                console.log("Not Palindrome Number");
}
    printPalindrom();
