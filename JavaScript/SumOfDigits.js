function SumOfDigit(){
   var sum=0;
   var r, num=1253;

   while(num>0)
   { 
      r=num%10;
      sum=sum+r;
      num=parseInt(num/10);

   }
   console.log(sum);
}
SumOfDigit();
