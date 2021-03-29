using Core.Utilities.Results;

namespace Core.Utilities.Business
{
    public class BusinessRules
    {
        public static IResult Run(params IResult[] logics)
        {
            foreach (var logic in logics)
            {
                if (logic.Success == false) // Gönderdiğimiz iş kuralları başarısız olursa, Business'e ilet.
                {
                    return logic;
                }
            }
            return null;
        }
    }
}