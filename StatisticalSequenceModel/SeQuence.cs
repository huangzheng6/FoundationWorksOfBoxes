
using System;
using System.Collections.Generic;
using System.Linq;
//统计序列模型
namespace StatisticalSequenceModel
{
    public interface IWdWord
    {
        List<string> WdGetWord(string[] keymodel, string input, int leve);
    }
    public class WdWord:IWdWord
    {
        /// <summary>
        /// 匹配模型方法
        /// </summary>
        /// <param name="keymodel">模型</param>
        /// <param name="input">输入文本</param>
        /// <param name="leve">等级-1-KEY[1];0-KEY[2];1-KEY[1,2];2-KEY[4];3[2,4];4[2,3,4]</param>
        /// <returns></returns>
        public List<string> WdGetWord(string[] keymodel,string input,int leve)
        {
           
            List<string> results = new List<string>();
            string[] arrys = keymodel;
            char[] data = input.ToArray();
            for (int i = 0; i < data.Length; i++)
            {
                string keys = "";
                if (leve==-1)
                {
                    if (arrys.Contains(data[i].ToString()))
                    {
                        results.Add(data[i].ToString());
                    }
                }
                else
                {
                    if (leve==0)
                    {
                        if ((i + 1) < data.Length)
                        {
                            keys = data[i].ToString() + data[i + 1].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                        if ((i - 1) > 0)
                        {
                            keys = data[i].ToString() + data[i - 1].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                    }
                    if (leve == 1)
                    {

                        if ((i + 1) < data.Length)
                        {
                            keys = data[i].ToString() + data[i + 1].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                        if ((i - 1) > 0)
                        {
                            keys = data[i].ToString() + data[i - 1].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }

                    }
                    if (leve==2)
                    {
                        if ((i - 3) > 0)
                        {
                            string keysc = data[i].ToString() + data[i - 1].ToString() + data[i - 2].ToString() + data[i - 3].ToString();
                            if (arrys.Contains(keysc))
                            {
                                Console.WriteLine(keysc);
                            }
                        }
                        if ((i + 3) < data.Length)
                        {
                            string keysc = data[i].ToString() + data[i + 1].ToString() + data[i + 2].ToString() + data[i + 3].ToString();
                            if (arrys.Contains(keysc))
                            {
                                Console.WriteLine(keysc);
                            }
                        }
                    }
                    if (leve==3)
                    {
                        if ((i + 1) < data.Length)
                        {
                            keys = data[i].ToString() + data[i + 1].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                        if ((i - 1) > 0)
                        {
                            keys = data[i].ToString() + data[i - 1].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                        if ((i - 3) > 0)
                        {
                             keys = data[i].ToString() + data[i - 1].ToString() + data[i - 2].ToString() + data[i - 3].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                        if ((i + 3) < data.Length)
                        {
                             keys = data[i].ToString() + data[i + 1].ToString() + data[i + 2].ToString() + data[i + 3].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                    }
                    if (leve == 4)
                    {
                        if ((i + 1) < data.Length)
                        {
                            keys = data[i].ToString() + data[i + 1].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                        if ((i - 1) > 0)
                        {
                            keys = data[i].ToString() + data[i - 1].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                        if ((i - 3) > 0)
                        {
                            keys = data[i].ToString() + data[i - 1].ToString() + data[i - 2].ToString() + data[i - 3].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                        if ((i + 3) < data.Length)
                        {
                            keys = data[i].ToString() + data[i + 1].ToString() + data[i + 2].ToString() + data[i + 3].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                        if ((i - 2) > 0)
                        {
                            keys = data[i].ToString() + data[i - 1].ToString() + data[i - 2].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                        if ((i + 2) < data.Length)
                        {
                            keys = data[i].ToString() + data[i + 1].ToString() + data[i + 2].ToString();
                            if (arrys.Contains(keys))
                            {
                                results.Add(keys);
                            }
                        }
                    }

                } 
            }
            return results.Distinct().ToList();
        }
    }
}
