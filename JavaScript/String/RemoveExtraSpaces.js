function RemoveExtraSpace(str) {
  var reverse = "";
           
  for ( var i=0;i<str.length; i++)
  {
    if(!(str[i]==' '))
    {
        reverse = reverse+str[i];
    }     
    else if (str[i]==' '&& str[i+1]!=' ')
    {
       reverse = reverse + " ";
    }
  }
    
      console.log(reverse);
  }   
   
  RemoveExtraSpace("How    are   you ");
