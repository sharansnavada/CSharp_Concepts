class MathOps {
    public int Multiply(int a, int b) => a * b;
}

// Assigning an instance method
MathOps ops = new MathOps();
PerformCalculation calcMul = ops.Multiply;  
Console.WriteLine(calcMul(3, 4));  // Calls ops.Multiply(3,4), outputs 12
