function pillars(numPill, dist, width) {
    if(numPill > 1 && dist >= 10 && dist <= 30 && width >= 10 && width <= 50){
        let onlyWidth_SM = (numPill - 2) * width
        let onlyDist_SM = ((numPill - 1) * dist) * 100
        let totalDist_SM = onlyDist_SM + onlyWidth_SM
        return  totalDist_SM
    }
    return 0
}

console.log(pillars(1, 10, 10))
