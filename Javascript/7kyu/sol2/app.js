function highAndLow(numbers){
    let numbersArr = numbers.split(' ').map(Number)

    let minValue = Math.min(...numbersArr)
    let maxValue = Math.max(...numbersArr)
    
    return `${maxValue} ${minValue}`
}

let result = highAndLow("1 2 3 4 5")

console.log(result)