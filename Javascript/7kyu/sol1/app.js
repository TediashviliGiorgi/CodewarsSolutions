function toTime(seconds) {
    let secondsAfterdivide = seconds % 3600
    let hours = (seconds - secondsAfterdivide) / 3600
    let minutes = Math.floor(secondsAfterdivide / 60)

    return `${hours} hour(s) and ${minutes} minute(s)`
}

let result = toTime(7100)
console.log(result)


