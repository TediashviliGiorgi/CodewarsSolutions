function strCount(str, letter) {
    lettersArr = []

    if (letter != null) {

        for (symbol of str) {
            if (symbol.toLowerCase() == letter.toLowerCase()) {
                lettersArr.push(symbol)
            }
        }
    }

    return lettersArr.length
}

let count = strCount("Hello", "l")

console.log(count)