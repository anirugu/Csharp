namespace Csharp.Tests
{
    public class LongestCommonPrefixTest
    {
        [Fact]
        public void Test()
        {
            //var results = new string[] { "flower", "flow", "flight" };
            //var results = new string[] { "", "" };
            var results = new string[] { "ab", "a" };
            //var results = new string[] { "flower", "flower", "flower", "flower" };
            var response = LongestCommonPrefix(results);
            Console.WriteLine(response);
        }

        public string LongestCommonPrefix(string[] strs)
        {
            // WIP
            if (strs.Length == 0 || Array.IndexOf(strs, "") != -1)
            {
                return string.Empty;
            }

            string result = string.Empty;
            if (strs.Length == 0)
                return result; ;
            if (strs.Length == 1)
                return strs[0];
            else
            {
                for (int i = 0; i < strs.Length; i++)
                {
                    if (strs[i].Length == 0)
                        return string.Empty;

                }
                //var items = strs.OrderBy(x => x.Length);
                //var maxLength = items.First().Length;
                //if (maxLength == 0)
                //    return string.Empty;
                //int minLength = items.Last().Length;
                ////Length can be the worst possible answer (time complexity)
                //for (int i = 0; i < items.Count(); i++)
                //{
                //    for (int j = 0; j < minLength; i++)
                //    {
                //        if (items[])
                //    }
                //}

                //if (length != 0)
                //{
                //    for (int i = 1; i < length; i++)
                //    {
                //        for (int j = 0; j < strs.Length - 1; j++)
                //        {
                //            if (strs[j].Substring(0, i) == strs[j + 1].Substring(0, i))
                //            {
                //                if (j == strs.Length - 1)
                //                {
                //                    result = strs[j].Substring(0, i);
                //                }
                //            }
                //            else
                //            {
                //                break;
                //            }

                //        }
                //    }
                //}
                return result;
            }


            //if (strs.Length == 0)
            //    return string.Empty;
            //else if (strs.Length == 1)
            //    return strs[0];
            //int i = 0;
            //int substring = 1;
            //string result = string.Empty;
            //if (strs[i].Length < 1 || strs[i + 1].Length < 1)
            //    return result;
            //while (strs[i].Substring(0, substring) == strs[i + 1].Substring(0, substring))
            //{

            //    result = strs[i].Substring(0, substring);
            //    if (i + 1 < strs.Length - 1)
            //        i++;
            //    else
            //    {
            //        if (strs[i].Length >= substring + 1 && strs[i].Length > substring + 1)
            //            substring++;
            //        else
            //        {
            //            break;
            //        }
            //    }
            //}
            //return result;
        }
    }


}