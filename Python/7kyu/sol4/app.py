def rounders(value):
    digits = [int(digit) for digit in str(value)]
    for i in range(len(digits) - 1, 0, -1):
        if digits[i] < 5:
            digits[i] = 0
        elif(digits[i] >= 5):
            digits[i] = 0
            digits[i - 1] = digits[i - 1] + 1

    number = 0
    for digit in digits:
        number = number * 10 + digit

    return number

digits = rounders(15)

print(digits)