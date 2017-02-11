using System.Text;
using System.Security.Cryptography;

namespace BilibiliVideoFetcher.Helper
{
    public static class MD5Helper
    {
        /// <summary>
        /// ��ȡ/���� ���ַ������н���ʱʹ�õ� ��/��������Ĭ��Ϊ Encoding.UTF8
        /// </summary>        
        public static Encoding Encoding { get; set; }

        /// <summary>
        /// ��ȡ/���� ���ڼ���MD5ֵ��MD5����
        /// </summary>
        public static MD5 MD5Cryptor { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static byte[] CalculateMD5(this byte[] data)
        {
            return MD5Helper.MD5Cryptor.ComputeHash(data);
        }

        /// <summary>
        /// �����ַ�����MD5ֵ������ Сд��32λ�����ַ���
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public static string CalculateMD5(this string data)
        {
            byte[] result = MD5Helper.Encoding.GetBytes(data);
            byte[] output = result.CalculateMD5();
            StringBuilder sb = new StringBuilder(32);
            foreach (var byt in output)
            {
                sb.AppendFormat("{0:x2}", byt);
            }
            return sb.ToString();
        }

        static MD5Helper()
        {
            MD5Helper.MD5Cryptor = new MD5CryptoServiceProvider();
            MD5Helper.Encoding = Encoding.UTF8;
        }
    }

}