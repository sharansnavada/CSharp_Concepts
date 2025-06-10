public delegate int PerformCalculation(int x, int y);

int Add(int a, int b) { return a + b; }

// Create a delegate instance referencing Add
PerformCalculation calc = Add;
// Invoke the delegate; this calls Add(3, 4)
int result = calc(3, 4);
Console.WriteLine(result);  // Outputs: 7
