public delegate void Notify(string message);

void SayHello(string name) { Console.WriteLine("Hello, " + name); }
void SayGoodbye(string name) { Console.WriteLine("Goodbye, " + name); }

Notify notify = SayHello;
notify += SayGoodbye;   // attach SayGoodbye as well
notify("Alice");
// Output:
// Hello, Alice
// Goodbye, Alice
