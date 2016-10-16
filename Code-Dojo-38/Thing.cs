namespace Code_Dojo_38
{
    public abstract class Thing
    {
        public abstract bool? Beats(Paper other);
        public abstract bool? Beats(Scissors other);
        public abstract bool? Beats(Rock other);
    }     
}
