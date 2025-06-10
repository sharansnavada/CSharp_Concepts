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
