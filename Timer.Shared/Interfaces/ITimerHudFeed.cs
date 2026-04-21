namespace Source2Surf.Timer.Shared.Interfaces;

public enum TimerWidgetType
{
    Time,           // "12.34" - current time
    Speed,          // "XXX" - current velocity
    Sync,           // "85%" - sync percentage  
    Jumps,          // "7" - jump count
    Strafes,        // "42" - strafe count
    Checkpoint,     // "3/5" - checkpoint progress
    Status,         // "RUN", "PAUSE", "---" - timer status
    Track,          // "T1" - track number
    PbTime,         // "PB: 12.34" - personal best time
    WrTime,         // "WR: 10.00" - world record time
}

public interface ITimerHudFeed
{
    static readonly string Identity = typeof(ITimerHudFeed).FullName!;

    /// <summary>
    /// Gets formatted text for a specific widget type for a player slot.
    /// </summary>
    /// <param name="slot">Player slot (0-63)</param>
    /// <param name="widgetType">The type of widget to get data for</param>
    /// <param name="text">The formatted text to display</param>
    /// <returns>True if the widget data was available, false otherwise</returns>
    bool TryGetWidgetText(int slot, TimerWidgetType widgetType, out string text);
}
