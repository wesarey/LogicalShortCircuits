namespace LogicalShortCircuits
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TruthHolder skyIsBlue = new TruthHolder() { IsTrue = false, Description = "Sometimes, it is gray"  };
            TruthHolder grassIsGreener = new TruthHolder() { IsTrue = true, Description = "On the other side" };
            TruthHolder thirdTruth = null;

            // Be aware of short-circuiting within logical expressions

            // Logical AND operations will short-circuit when the first false value is found, it no longer needs to evaluate any further
            if(skyIsBlue.IsTrue && grassIsGreener.IsTrue && thirdTruth.IsTrue) {     
                // The only way we get here is if...
                Console.WriteLine("All truths are true");
            } else
            {
                // exceptionThrower is null and would have thrown an error accessing the "IsTrue" property
                Console.WriteLine("At least one truth is false");
            }

            // Logical OR operations will short-circuit when the first true value is found
            if (skyIsBlue.IsTrue || grassIsGreener.IsTrue || thirdTruth.IsTrue)
            {
                // exceptionThrower is null and would have thrown an error accessing the "IsTrue" property
                Console.WriteLine("At least one truth is true");

                // Because we made it inside this code block, we may think it is safe to access the properties of "thirdTruth"
                // uncomment the line below and run to see results...

                // Console.WriteLine(thirdTruth.Description);

            } else
            {
                // The only way we get here is if...
                Console.WriteLine("All truths are false");
            }
        }
    }

    public class TruthHolder
    {
        public bool IsTrue { get; set; }
        public string Description { get; set; }
    }
}
