function ReverseString(val) {
   var op = "",
     iCount = 0;
   for (let i = 0; i <= val.length; i++) {
     if (val[i] != " " && i != val.length)
       continue;
     for (let j = i - 1; j >=iCount; j--)
       op += val[j];
     if (i != val.length)
       op += " ";
     iCount = i;
   }
   return op;
 }
 
 console.log(ReverseString("Hi how are you"));
