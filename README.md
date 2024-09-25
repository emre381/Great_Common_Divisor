
---

# EBOB Calculator

### Overview

This is a simple console-based application that calculates the Greatest Common Divisor (GCD), known as **EBOB** (En Büyük Ortak Bölen) in Turkish, between two integers. The program uses the **Euclidean Algorithm** to efficiently compute the GCD of two numbers. It accepts both positive and negative numbers and handles edge cases such as when both numbers are zero.

### How It Works

1. The user is prompted to enter two numbers.
2. The program then calculates the GCD using the **Euclidean Algorithm**.
3. If both numbers are zero, the program informs the user that the GCD is undefined.
4. The result is displayed as `Ebob(sayi1, sayi2) = result`.

### Example Run:

```
Please enter the first number: 
18
Please enter the second number: 
24
Ebob(18, 24) = 6
```

If both numbers are zero:

```
Please enter the first number: 
0
Please enter the second number: 
0
EBOB is undefined for both numbers being zero.
```

### Algorithm Explanation:

- The Euclidean Algorithm works by repeatedly replacing the larger of the two numbers with the remainder of dividing the larger by the smaller until one of the numbers becomes zero. The remaining number is the GCD.
- For negative numbers, the absolute values are taken before performing the calculation.

### Code Structure:

- **Main Program**: Prompts the user for input and handles the GCD calculation using a helper method.
- **FindGCD Method**: Implements the Euclidean Algorithm to calculate the GCD.

### Example Edge Cases:

- **Input: (0, 0)** → Undefined GCD.
- **Input: (-18, 24)** → Treats negative numbers as positive and returns GCD as `6`.
  
### Error Handling:
- The program assumes that valid integers are entered. Additional error handling for non-integer inputs can be added for robustness.

### How to Run:

1. Compile and run the `ebob` C# console application.
2. Enter two integer numbers when prompted.
3. The program will display the GCD (EBOB) of the two numbers.

---

