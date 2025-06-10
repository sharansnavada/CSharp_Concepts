private EventHandler MyEvent; // backing field

public event EventHandler MyEvent {
    add {
        // Combine the new handler into the delegate list
        MyEvent = (EventHandler)Delegate.Combine(MyEvent, value);
    }
    remove {
        // Remove the handler from the delegate list
        MyEvent = (EventHandler)Delegate.Remove(MyEvent, value);
    }
}
