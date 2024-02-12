var summation = function(num){
    let sum = 0
    let increment = 1

    while(increment != num + 1){
        sum += increment
        increment ++
    }

    return sum
}

let sum = summation(8)
console.log(sum)