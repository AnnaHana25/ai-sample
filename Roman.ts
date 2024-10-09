function romanToInt(s: string): number {
    const romanValues: { [key: string]: number } = {
        'I': 1,
        'V': 5,
        'X': 10,
        'L': 50,
        'C': 100,
        'D': 500,
        'M': 1000
    };

    let total = 0;
    let prevValue = 0;

    for (let i = s.length - 1; i >= 0; i--) {
        const currentValue = romanValues[s[i]];
        if (currentValue >= prevValue) {
            total += currentValue;
        } else {
            total -= currentValue;
        }
        prevValue = currentValue;
    }

    return total;
}

// Test cases
console.log(romanToInt("III"));       // Output: 3
console.log(romanToInt("LVIII"));     // Output: 58
console.log(romanToInt("MCMXCIV"));   // Output: 1994