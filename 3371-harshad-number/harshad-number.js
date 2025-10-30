/**
 * @param {number} x
 * @return {number}
 */
var sumOfTheDigitsOfHarshadNumber = function(x) {
    let add=0;
    let minus=-1;
    let str=String(x)
    for(let i=0;i<str.length;i++){
        add+=Number(str[i])
    }
    
    if(x%add==0){
        return add;
    }
    else{
        return minus;
    }
};