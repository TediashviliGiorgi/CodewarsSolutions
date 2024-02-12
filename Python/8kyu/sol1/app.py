def summation(num):
    sum = 0
    increment = 1

    while(increment != num + 1):
        sum += increment
        increment +=1

    return sum

sum = summation(8)

print(sum)

