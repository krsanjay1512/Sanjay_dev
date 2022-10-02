function DeleteAllNumericValue(s) 
{
   var t = "";
   for (var i=0;i<s.length;i++)
   {
       if (!(s[i]>='0' && s[i]<='9'))
       {
           t = t + s[i];
       }
   }
console.log(t);
 }
 
 DeleteAllNumericValue("he343l3lo");
