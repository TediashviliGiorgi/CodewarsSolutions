def monkey_count(n):
    if n > 0:
        monkeys = []
        for i in range(n):
            monkeys.append(i + 1)
        return monkeys
    return []

print(monkey_count(0))