def invert(list):
    inverted_nubers = []
    for num in list:
        inverted_num = -num if num > 0 else abs(num)
        inverted_nubers.append(inverted_num)
    return inverted_nubers

print(invert([1,-2,3,-4,5]))