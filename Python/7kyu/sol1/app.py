import math

def to_time(seconds):
    
    secondsAfterDovode = seconds % 3600
    hours = (seconds - secondsAfterDovode) / 3600
    minutes = math.floor(secondsAfterDovode / 60)
    
    return f'{math.floor(hours)} hour(s) and {math.floor(minutes)} minute(s)'