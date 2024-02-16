def sum_array(arr):
    
    if arr is None or len(arr) < 2:
        return 0
    else:
        max_value = max(arr)
        min_value = min(arr)

        array_sum = sum(arr) - (max_value + min_value)

    return array_sum


   

