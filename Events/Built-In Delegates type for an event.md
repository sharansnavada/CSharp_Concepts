Built-in delegate types used for events
C# provides several built-in delegates commonly used with events:
Action and Action<T>: These are generic delegates in System for methods that return void

. For example, public event Action OnProcessed; or public event Action<int> ThresholdReached;. You can use Action for simple events, but it has no built-in convention for sender or data.
EventHandler: A predefined delegate void EventHandler(object sender, EventArgs e)

. Use this for events that do not need to send extra data. By convention, the sender is the publisher object, and EventArgs.Empty is passed as e if there’s no data

EventHandler<TEventArgs>: A generic delegate void EventHandler<T>(object sender, T e)
, where T is a class derived from EventArgs. Use this when you want to send custom data with the event. For example, if your event needs to pass an integer, you might define an IntEventArgs : EventArgs and use event EventHandler<IntEventArgs> SomethingChanged;.
.NET guidelines recommend using EventHandler or EventHandler<T> for most events, because it standardizes the pattern of including the sender and data


. (You can use event Action or a custom delegate for internal or simple cases, but for public APIs the EventHandler pattern is preferred


Real-world analogy: the publish–subscribe pattern
Events can be understood with everyday examples of a notification system:
Doorbell: When someone presses the doorbell (event published), a person inside the house (subscriber) hears it and answers the door

. The doorbell (publisher) doesn’t need to know who is listening – any occupant can respond.
Fire alarm: If a smoke detector raises a fire alarm event, many parties respond: the fire department, building security, and occupants all react in their own way

. The detector just signals “Fire detected!” and lets the subscribers decide what to do.
Newsletter subscription: A publisher sends out a monthly newsletter (publishes an event); each subscriber (reader) receives and processes it (reading the news). When the publisher issues a new edition, all subscribers get notified.
Such scenarios illustrate publish–subscribe: one broadcaster emits a signal, and any interested parties handle it. C# events implement this pattern
, allowing loose coupling between the broadcaster and listeners.
