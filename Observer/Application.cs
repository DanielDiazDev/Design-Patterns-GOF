namespace Observer
{
    class Application
    {
        public void config()
        {
            TextEditor editor = new TextEditor();
            LoggingListener logger = new LoggingListener( "/path/to/log.txt", "Archivo encontrado");
            editor.events.subscribe(logger, "Open");

            EmailAlertsListener emailAlerts = new EmailAlertsListener("admin@example.com", "Cambiado");
            editor.events.subscribe(emailAlerts, "Save");

        }
    }
}