using System.Collections.Generic;
using System.Linq;

namespace AtCoder.ABC106.D
{
    public class Takahashi
    {
        public IEnumerable<int> Answer(IEnumerable<Train> trains, IEnumerable<Problem> problems)
        {
            return problems.Select(problem =>
            {
                return trains
                    .Where(train => problem.P <= train.L && train.R <= problem.Q)
                    .Count();
            });
        }
    }
}
