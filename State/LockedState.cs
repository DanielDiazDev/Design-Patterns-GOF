namespace State
{
    public class LockedState : State
    {
        public LockedState(AudioPlayer audioPlayer) : base(audioPlayer)
        {
            
        }

        public override void ClickLock()
        {
            if (true /*audioPlayer.playing*/)
                audioPlayer.ChangeState(new PlayingState(audioPlayer));
            else
                audioPlayer.ChangeState(new ReadyState(audioPlayer));
        }

        public override void ClickPlay()
        {
           
        }

        public override void ClickNext()
        {
            
        }

        public override void ClickPrevious()
        {
          
        }
    }
}