namespace LightHTMLSharp.Models
{
    public class EventListener
    {
        public string EventType { get; }
        public Action Handler { get; }

        public EventListener(string eventType, Action handler)
        {
            EventType = eventType;
            Handler = handler;
        }

        public void HandleEvent()
        {
            Handler.Invoke();
        }
    }
}
