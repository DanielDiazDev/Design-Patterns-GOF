using System.Collections.Generic;

namespace Observer
{
    class EventManager
    {
        Dictionary<IEventListeners, string> listeners = new Dictionary<IEventListeners, string>();

        public void subscribe(IEventListeners subscriber, string type)
        {
            this.listeners.Add(subscriber, type);
        }
        public void remove(IEventListeners subscriber)
        {
            this.listeners.Remove(subscriber);
        }
        public void notify(string type, string data)
        {
            foreach(KeyValuePair<IEventListeners, string> keyValue in this.listeners)
            {
                keyValue.Key.update(data);
            }
        }
    }
}