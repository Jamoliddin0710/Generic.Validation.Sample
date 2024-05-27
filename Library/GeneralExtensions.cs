using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public static class GeneralExtensions
    {
        #region  Generic
        public static bool Between<T>(this T value, T pLowerValue, T pUpperValue) =>
            Comparer<T>.Default.Compare(value, pLowerValue) >= 0 &&
            Comparer<T>.Default.Compare(value, pUpperValue) <= 0;
        #endregion

        #region NonGeneric
        public static bool Between(this int value ,  int pLowerValue, int pUpperValue , bool pInclusive = false)
        {
            return pInclusive ?
                pLowerValue <= value && pUpperValue >= value
                : pLowerValue < value && pUpperValue > value;
        }

        #endregion
    }
}
