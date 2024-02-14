def str_count(string, letter):
    letters_arr = []

    if letter is not None:
        for symbol in string:
            if symbol.lower() == letter.lower():
                letters_arr.append(symbol)

    return len(letters_arr)