function rounders(value) {
    let digits = Array.from(String(value), Number)

    for (let i = digits.length; i > 0; i--) {
        if (digits[i] < 5) {
            digits[i] = 0
        }
        else if (digits[i] >= 5) {
            digits[i] = 0
            digits[i - 1] = digits[i - 1] + 1
        }
    }

    let number = 0
    for (let digit of digits) {
        number = number * 10 + digit
    }

    return number
}

let number = rounders(15)
console.log(number)