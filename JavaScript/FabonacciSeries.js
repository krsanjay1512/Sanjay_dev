function printfebonacci()
{
    var a=0, n=10, b = 1,c;
               var t = n;
           for(var i=2;i<n;i++)
           {
            c=a+b;
            console.log(c);
            a=b;
            b=c;
            
           }
}
printfebonacci();
