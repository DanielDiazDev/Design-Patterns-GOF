using System;

namespace Observer
{
    class EmailAlertsListener : IEventListeners
    {
        string email;
        string message;

        public EmailAlertsListener(string email, string message)
        {
            this.email = email;
            this.message = message;
        }

        public void update(string filename)
        {
            
        }

    }
}