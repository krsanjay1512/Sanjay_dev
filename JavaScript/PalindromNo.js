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
            Console.WriteLine("Palindrome Number");
            else
                Console.WriteLine("Not Palindrome Number");
}
    printPalindrom();
