function printMax(arr)
{
    var maximum= arr[0];
    for(var i = 0;i<arr.length;i++){
    //console.log(arr[i]);
    //temp=temp+arr[i];
    if(arr[i]>=maximum){
     maximum= arr[i];
    }
    }

    return maximum;
}
   var res= printMax([10,20,30,35,50]);
   console.log(res);
