function sum (numbersArr){
    if(numbersArr == null || numbersArr.length < 2){
        return 0
    }
    else{
        maxValue = Math.max(...numbersArr)
        minValue = Math.min(...numbersArr)
    
        let sum = numbersArr.reduce((sum, num) => sum + num, 0);
        sum -= (minValue + maxValue)
    
        return sum
    }
}

let Sum = sum([1, 1, 11, 2, 3])
console.log(Sum)