using System;

namespace SuperExtensions
{
    public static class ByteArrayExtensions
    {
        #region Convert

        public static string ToBase64String(this byte[] inArray) => Convert.ToBase64String(inArray);

        #endregion
    }
}
