function fixTheMeerkat(arr){
    if (arr.length == 3){
        let realHead = arr[arr.length - 1]
        let realTail = arr[0]

        arr.splice(arr.length - 1, 1, realTail)
        arr.splice(arr[0], 1, realHead)
        
        return arr
    }
}