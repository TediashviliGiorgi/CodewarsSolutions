function howMuchILoveYou(nbPetals) {
    loveLevel = ["I love you", "a little", "a lot", "passionately", "madly", "not at all"]
    if(nbPetals > 0 ){
        return loveLevel[(nbPetals - 1) % loveLevel.length]
    }
    return "invalid flower"
}

let result = howMuchILoveYou(408)
console.log(result) 