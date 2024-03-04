function cubeChecker(volume, side){
    if(Math.cbrt(volume) === side && side != 0 && side > 0){
        return true
    }
    return false
  };

console.log(cubeChecker(8, 3))