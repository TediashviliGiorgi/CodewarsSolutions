function invert(array){
    array.map((number, index)=>{
        if(number == 0){
            array[index] = 0
        }
        else if(number > 0){
            array[index] = -Math.abs(number)
        }
        else{
            array[index] = Math.abs(number)
        }
    })
    
    return array
}

console.log(invert([1,-2,3,4,5]))