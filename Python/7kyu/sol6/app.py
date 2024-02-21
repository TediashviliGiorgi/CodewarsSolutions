def reverse_fun(n):
    chars = list(n)
    length = len(chars)

    for i in range(length):
        chars[i:] = reversed(chars[i:])

    result = "".join(chars)
    return result

# Example usage
n = "012345"
result = reverse_fun(n)
print(result)
