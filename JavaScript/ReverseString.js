function printReversStr(str)
{
    var test="";
    for(var i =str.length-1;i>=0;i--)
    {
     test=test+str[i];
    }   
    return test;
}
   var res= printReversStr("Hello ");
   console.log(res);
