function minMax(arr){
    let minValue = Math.min(...arr)
    let maxValue = Math.max(...arr)

    return [minValue, maxValue]
  }

  let result = minMax([1,2,3,4,5])
  console.log(result)