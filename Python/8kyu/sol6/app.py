def to_csv_text(array):
    formatted_rows = []  

    for row in array:
        formatted_row = []
        for num in row:
            formatted_row.append(str(num))  
        formatted_rows.append(",".join(formatted_row))  
    
    csv_text = "\n".join(formatted_rows)  
    
    return csv_text


input_array = [
    [0, 1, 2, 3, 4],
    [10, 11, 12, 13, 14],
    [20, 21, 22, 23, 24],
    [30, 31, 32, 33, 34]
]
output = to_csv_text(input_array)
print(output)