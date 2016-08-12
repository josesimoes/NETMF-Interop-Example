using System.Runtime.CompilerServices;

namespace Eclo.STM32F4
{
    public class Math
    {
        /// <summary>
        /// Crunches value through a super complicated and secret calculation algorithm .
        /// </summary>
        /// <param name="value">Value to crunch.</param>
        /// <returns></returns>
        public double SuperComplicatedCalculation(double value)
        {
            return NativeSuperComplicatedCalculation(value);
        }

        #region Stubs

        [MethodImplAttribute(MethodImplOptions.InternalCall)]
        private static extern double NativeSuperComplicatedCalculation(double value);

        #endregion stubs
    }
}
