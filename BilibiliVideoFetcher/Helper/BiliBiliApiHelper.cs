using BilibiliVideoFetcher.Data;
using System;

namespace BilibiliVideoFetcher.Helper
{
    public static class BiliBiliApiHelper
    {
        /// <summary>
        /// ��queryString ����ǩ���� AccessKey
        /// </summary>
        /// <param name="queryString">Ҫǩ���Ķ�queryString</param>
        /// <returns>ǩ�����queryString</returns>
        public static string SignQueryParams(string queryString)
        {
            string sign = (queryString + AdvanceSettings.AccessKey).CalculateMD5();
            return $"{queryString}&sign={sign}";
        }

        public static bool SignQueryParams(object p)
        {
            throw new NotImplementedException();
        }
    }

}
