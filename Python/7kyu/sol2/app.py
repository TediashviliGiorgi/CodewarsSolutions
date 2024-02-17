def high_and_low(numbers):
    arr = numbers.split(" ")
    numbers_arr = []
    for number in arr:
        num = int(number)
        numbers_arr.append(num)
    

    min_value = min(numbers_arr)
    max_value = max(numbers_arr)

    return f"{max_value} {min_value}"

result = high_and_low("8 3 -5 42 -1 0 0 -9 4 7 4 -4")

print(result)