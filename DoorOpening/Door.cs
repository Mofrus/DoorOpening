namespace DoorOpening
{
    public class Door
    {

        private bool opened;

        public Door(bool opened = false)
        {
            this.opened = opened;
        }

        public bool Opened
        {
            get => opened;
            set => opened = value;
        }
    }
}