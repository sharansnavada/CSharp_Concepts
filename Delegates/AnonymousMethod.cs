Func<int,int> squareDel = delegate(int x) { return x * x; };
Console.WriteLine(squareDel(5));  // Outputs 25


// Sometimes you need a quick, one-off method without formally declaring a named function.
// C# lets you create anonymous methods or lambda expressions for this purpose.
// An anonymous method uses the delegate keyword inline. For example:

// Here squareDel is a delegate (of type Func<int,int>) assigned an anonymous method that squares its input.
// The code delegate(int x) { return x * x; } creates a nameless function that matches the signature of Func<int,int>
