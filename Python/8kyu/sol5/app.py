def fix_the_meerkat(arr):
    realTail = arr[0]
    realHead = arr[len(arr) - 1]
    arr[len(arr) - 1] = realTail
    arr[0] = realHead
    return arr

print(fix_the_meerkat(["tail", "body", "head"]))