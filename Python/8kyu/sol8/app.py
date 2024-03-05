def how_much_i_love_you(nb_petals):
    love_level = ["I love you", "a little", "a lot", "passionately", "madly", "not at all"]
    if(nb_petals >= 1):
        return love_level[nb_petals % len(love_level) - 1]
    return "invalid flower"

print(how_much_i_love_you(11))