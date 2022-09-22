function RemoveSpace(str) {
  var temp = "";
          
  for ( var i=0;i<str.length; i++)
  {
    if(str[i]!= ' ')
      temp = temp+str[i];
  }
    
      console.log(temp);
  }
      
  RemoveSpace("How are you");
