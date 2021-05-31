using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;

namespace TaoBao.Common
{
    public class PhotoHelper
    {
        /// <summary>
        /// 下载图片
        /// </summary>
        /// <param name="picUrl">图片Http地址</param>
        /// <param name="basePath">保存路径（本地）</param>
        /// <param name="timeOut">Request最大请求时间，如果为-1则无限制</param>
        /// <returns></returns>
        public static bool DownloadPicture(List<string> picUrl, string basePath, int timeOut = -1)
        {
            string savePath = basePath + DateTime.Now.ToString("yyyyMMdd") + "/" + DateTime.Now.ToString("HHmmss");
            bool value = false;
            try
            {
                // 目录不存在，则创建
                if (!Directory.Exists(savePath))
                {
                    Directory.CreateDirectory(savePath);
                }
                int i = 0;
                foreach (var url in picUrl)
                {
                    DownloadOneFileByURLWithWebClient((++i) + ".jpg", url, savePath+"/");
                }

            }
            finally
            {
            }
            return value;
        }
        private static void DownloadOneFileByURLWithWebClient(string fileName, string url, string localPath)
        {
            System.Net.WebClient wc = new System.Net.WebClient();
            if (File.Exists(localPath + fileName)) { File.Delete(localPath + fileName); }
            if (Directory.Exists(localPath) == false) { Directory.CreateDirectory(localPath); }
            wc.DownloadFile(url, localPath + fileName);
        }
        

    }
}
