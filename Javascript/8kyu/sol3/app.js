function closeCompare(a, b, margin = 0) {
    let result;
    let distance = a - b;
    if (Math.abs(distance) <= Math.abs(margin)) {
        result = 0;
    } else if (distance < 0) {
        result = -1;
    } else {
        result = 1;
    }
    return result;
}

closeCompare()
