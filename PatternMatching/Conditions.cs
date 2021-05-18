namespace PatternMatching
{
    public class Conditions
    {
        public void Example(string? s, int x)
        {
            if (s is not null)
            {
                var z = 1;
            }

            if (x is >=1 or <=3 and >7)
            {
            }
        }
    }
}