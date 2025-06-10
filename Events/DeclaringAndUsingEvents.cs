// Define a delegate (signature of the event handler)
public delegate void AlarmHandler();

// Declare the event of that delegate type
public class AlarmSystem {
    public event AlarmHandler FireAlarm;

    public void DetectFire() {
        Console.WriteLine("Fire detected!");
        // Raise the event (notify all subscribers)
        FireAlarm?.Invoke();
    }
}


