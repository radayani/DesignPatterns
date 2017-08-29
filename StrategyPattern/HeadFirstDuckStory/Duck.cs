namespace HeadFirstDuckStory
{
    public abstract class Duck
    {
        internal ISoundBehavior sb;
        internal IFlyBehavior fb;

        public void setFlyBehavior(IFlyBehavior fb){
            this.fb = fb;
        }

        public void setSoundBehavior(ISoundBehavior sb){
            this.sb = sb;
        }

        public void performSound(){
            sb.makeSound();
        }

        public void performFly(){
            fb.fly();
        }

        void swim(){}

        public abstract void display();
    }
}
