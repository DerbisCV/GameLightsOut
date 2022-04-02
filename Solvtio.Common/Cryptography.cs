using System.Text;

namespace Solvtio.Common
{
    public static class Cryptography
    {

        public static string SimpleEncrypt(this string textDecrypt)
        {
            return Convert.ToBase64String(Encoding.Unicode.GetBytes(textDecrypt));
        }

        public static string SimpleDecrypt(this string textEncrypted)
        {
            return Encoding.Unicode.GetString(Convert.FromBase64String(textEncrypted));
        }

    }
}
