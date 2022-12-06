namespace State
{
    public class AudioPlayer
    {
        private State state;

        public AudioPlayer()
        {
            this.state = new ReadyState(this);
        }
        
        public void ChangeState(State state)
        {
            this.state = state;
        }

        public void ClickLock()
        {
            this.state.ClickLock();
        }
        
        public void ClickPlay()
        {
            this.state.ClickPlay();
        }
        
        public void ClickNext()
        {
            this.state.ClickNext();
        }
        
        public void ClickPrevious()
        {
            this.state.ClickPrevious();
        }
    }
}