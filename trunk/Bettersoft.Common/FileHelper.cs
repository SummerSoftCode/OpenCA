using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Bettersoft.Common
{
    public class FileHelper
    {
        /// <summary>
        /// 生成一个不重复的文件路径
        /// </summary>
        /// <param name="filePath">文件路径</param>
        /// <returns>不重复的文件路径</returns>
        public static string GetUniqueFilePath(string filePath)
        {
            var newFilePath = filePath;
            int i = 2;
            while (File.Exists(newFilePath))//解决文件重名问题
            {
                newFilePath = filePath.Insert(filePath.LastIndexOf('.'), i.ToString());
            }

            return newFilePath;
        }
    }
}
