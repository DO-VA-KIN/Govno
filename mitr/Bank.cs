using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mitr
{
    internal static class Bank
    {
        static long Count = 50000;

        /// <summary>
        /// ф-ия изменения счёта
        /// </summary>
        /// <param name="count"></param>
        public static void ChangeCount(long count)
        {
            Count += count;
        }

        /// <summary>
        /// получить текущие кол-во на счёте
        /// </summary>
        /// <returns></returns>
        public static long GetCount() { return Count; }
    }
}
