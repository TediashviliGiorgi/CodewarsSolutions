function multiply(number) {
    let numLength = Math.abs(number).toString().length;

    if (number === 0) {
        return 0;
    } else {
        let result = Math.pow(5, numLength) * Math.abs(number);
        return number < 0 ? -result : result;
    }
}

console.log(multiply(10))