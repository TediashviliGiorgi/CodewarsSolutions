function flipNumber(input) {
    let result = input.split('').reverse().join('');
    for (let i = 1; i < input.length; i++) {
      result = result.slice(0, i) + result.slice(i).split('').reverse().join('');
    }
    return result;
  }

console.log(flipNumber("012345"))