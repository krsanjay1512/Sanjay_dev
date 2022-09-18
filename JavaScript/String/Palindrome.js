function Palindrome (str) {
  var reverse = "";
   //var str  = "mam";         
  for ( var i=str.length-1; i >= 0; i--)
  {
      reverse = reverse+str[i];
  }
  
  if (str === reverse)
  {
      console.log("string is Palindrome.");
  }
  else
  {
      console.log("string is not Palindrome");
  }
   }  
   
   Palindrome("mam");
