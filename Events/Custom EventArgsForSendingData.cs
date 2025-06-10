// Custom data class
public class ThresholdReachedEventArgs : EventArgs {
    public int Threshold { get; }
    public DateTime TimeReached { get; }

    public ThresholdReachedEventArgs(int threshold, DateTime time) {
        Threshold = threshold;
        TimeReached = time;
    }
}

// Publisher with a generic event
public class Counter {
    public event EventHandler<ThresholdReachedEventArgs> ThresholdReached;

    protected virtual void OnThresholdReached(ThresholdReachedEventArgs e) {
        ThresholdReached?.Invoke(this, e);
    }
}
