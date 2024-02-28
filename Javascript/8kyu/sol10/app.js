function monkeyCount(n) {
    array = []
    for(let i = 0; i < n; i++){
        array.splice(i, 0, i + 1)
    }

    return array
}

console.log(monkeyCount(5))