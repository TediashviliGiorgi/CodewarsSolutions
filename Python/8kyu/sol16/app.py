def pillars(num_pill, dist, width):
    if num_pill >= 1:
        distance_between_pillars_SM = dist * 100
        total_dist = (num_pill - 1) * distance_between_pillars_SM
        if num_pill == 1:
            return 0 
        total_width = num_pill * width - (2 * width)
    return total_dist + total_width
    
print(pillars(1,10,10))