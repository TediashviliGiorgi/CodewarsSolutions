def close_compare (a, b, margin):
    result = 0
    distance = a - b
    if abs(distance) <= abs(margin):
        result = 0
    elif distance < 0:
        result = -1
    else:
        result = 1

    return result;