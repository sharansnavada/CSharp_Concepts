public class Publisher {
    // Using the built-in EventHandler delegate
    public event EventHandler DataAvailable;

    public void ProduceData() {
        Console.WriteLine("Data produced.");
        // Raise the event: sender=this, no data (EventArgs.Empty)
        DataAvailable?.Invoke(this, EventArgs.Empty);
    }
}
