namespace Code_Dojo_38
{
    public class Paper : Thing
    {
        public override bool? Beats(Paper other)
        {
          return null;
        }

        public override bool? Beats(Rock other)
        {
            return true;
        }

        public override bool? Beats(Scissors other)
        {
            return false;
        }

    }
}
