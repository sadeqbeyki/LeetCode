using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode;

internal class LongestCommon
{
    public string LongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        string prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                if (prefix.Length == 0)
                    return "";
                prefix = prefix.Substring(0, prefix.Length - 1);
            }
        }

        return prefix;
    }

    public string LongestCommonSuffix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return "";

        string suffix = strs[0];

        for (int j = 1; j < strs.Length; j++)
        {
            while (!strs[j].EndsWith(suffix))
            {
                if (suffix.Length == 0)
                    return "";
                suffix = suffix.Substring(1);
            }
        }

        return $"the longest common suffix is \"{suffix}\"";
    }

}
