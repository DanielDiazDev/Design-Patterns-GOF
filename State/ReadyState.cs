namespace State
{
    public class ReadyState : State
    {
        public ReadyState(AudioPlayer audioPlayer) : base(audioPlayer)
        {
            
        }

        public override void ClickLock()
        {
            audioPlayer.ChangeState(new LockedState(audioPlayer));
        }

        public override void ClickPlay()
        {
            audioPlayer.ChangeState(new PlayingState(audioPlayer));
        }

        public override void ClickNext()
        {
            
        }

        public override void ClickPrevious()
        {
            
        }
    }
}