using System;

namespace Calc_DependencyInjection
{
    public class Calculator : ICalculator
    {
        private readonly ILogger logger;

        public Calculator(ILogger logger)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public float Addition(float value1, float value2)
        {
            logger.Event("Calculation started");
            float result = value1 + value2;
            logger.Event("Calculation completed");
            return result;
        }
    }
}
