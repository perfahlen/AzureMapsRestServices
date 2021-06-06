using System;
using System.Text;

namespace AzureMapsToolkit.Common
{
    public static class Extensions
    {
        public static string ToCamelCase(this string val)
        {
            char prevChar = val[0];

            var sb = new StringBuilder();

            for (int i = 0; i < val.Length; i++)
            {
                if (i > 0)
                {
                    if (val[i] == ' ')
                        continue;

                    if (prevChar != ',')
                    {
                        sb.Append(val[i]);
                    }
                    else
                    {
                        sb.Append(char.ToLowerInvariant(val[i]));
                    }
                    prevChar = val[i];
                }
                else
                {
                    sb.Append(char.ToLowerInvariant(val[0]));
                }
            }

            return sb.ToString();

        }
    }
}
