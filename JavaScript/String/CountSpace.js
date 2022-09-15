function printCountSpace()
{
    var count = 0;
    var str = "hello how are you";
    for (var i=0;i<str.length; i++)
    {
        if (str[i] == ' ')
        {
            count++;           
        }
    }
            
    console.log("No of Space in the given string is : "+count);
    console.log("No of word in the given string is : "+(count+1));
}
printCountSpace();
