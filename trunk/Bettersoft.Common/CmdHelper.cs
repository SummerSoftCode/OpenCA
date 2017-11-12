using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Bettersoft.Common
{
    public class CmdHelper
    {
        /// <summary>
        /// 执行命令行命令,获取输出结果（夏春涛20140309）
        /// </summary>
        /// <param name="cmd_filename">应用程序文件名，如 ipconfig</param>
        /// <param name="arguments">命令行参数，如 /all</param>
        /// <returns>获取命令输出结果（文本内容）</returns>
        public static string Execute(string cmd_filename, string arguments)
        {
            string error = "";
            return Execute(cmd_filename, arguments, out error);
        }

        /// <summary>
        /// 执行命令行命令,获取输出结果（夏春涛20140316）
        /// </summary>
        /// <param name="cmd_filename">DOS程序文件名，如 ipconfig</param>
        /// <param name="arguments">命令行参数，如 /all</param>
        /// <param name="error">错误信息</param>
        /// <returns>获取命令输出结果（文本内容）</returns>
        public static string Execute(string cmd_filename, string arguments, out string error)
        {
            var processStartInfo = new ProcessStartInfo(cmd_filename, arguments);//如：调用ipconfig ,并传入参数: /all 
            processStartInfo.CreateNoWindow = true; //若为false，则会出现cmd的黑窗体 
            processStartInfo.RedirectStandardOutput = true;
            processStartInfo.UseShellExecute = false;//设为false-只用于启动可执行文件
            processStartInfo.RedirectStandardError = true;//接收错误输出流

            var process = Process.Start(processStartInfo);
            var resultText = process.StandardOutput.ReadToEnd();            
            error = process.StandardError.ReadToEnd();
            
            return resultText;
        }
    }
}
