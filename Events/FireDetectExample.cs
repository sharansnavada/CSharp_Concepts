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

AlarmSystem alarm = new AlarmSystem();

// Define a handler method
void RespondToAlarm() {
    Console.WriteLine("Alarm responded.");
}

// Subscribe to the event
alarm.FireAlarm += RespondToAlarm;

// Trigger the event
alarm.DetectFire();  // -> prints "Fire detected!" then "Alarm responded."

// Unsubscribe when done
alarm.FireAlarm -= RespondToAlarm;
