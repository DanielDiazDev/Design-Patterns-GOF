namespace State
{
    public class PlayingState : State
    {
        public PlayingState(AudioPlayer audioPlayer) : base(audioPlayer)
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