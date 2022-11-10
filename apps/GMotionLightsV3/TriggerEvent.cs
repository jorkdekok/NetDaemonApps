namespace GMotionLightsV3;

public class TriggerEvent
{
	public TriggerEvent(TriggerStates state, DateTimeOffset timestamp) => (State, Timestamp) = (state, timestamp);
	
	public TriggerEvent(TriggerStates state) => (State, Timestamp) = (state, DateTimeOffset.Now);
	
	public DateTimeOffset Timestamp;

	public TriggerStates State;
}
