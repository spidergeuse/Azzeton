using System.IO;
using System;
namespace Azzeton.Shared
{
    public class SizeManager
    {
        public static string ToSizeString(long bytes, uint places)
        {
            string format = "N" + places.ToString();
            if (bytes >= 1073741824)
            {
                return ((decimal)bytes / 1024M / 1024M / 1024M).ToString(format) + " GB";
            }
            else if (bytes >= 1048576)
            {
                return ((decimal)bytes / 1024M / 1024M).ToString(format) + " MB";
            }
            else if (bytes >= 1024)
            {
                return ((decimal)bytes / 1024M).ToString(format) + " KB";
            }
            else if (bytes >= 0 & bytes < 1024)
            {
                return ((decimal)bytes).ToString(format) + " Bytes";
            }
            else
            {
                return "0 Bytes";
            }
        }
        public static long GetFolderSize(string folderpath, bool includesubfolders)
        {
            long fileSize = 0;
            DirectoryInfo directory = new DirectoryInfo(folderpath);

            foreach (System.IO.FileInfo fileInfo in directory.GetFiles())
                fileSize += fileInfo.Length;

            if (includesubfolders)
            {
                foreach (System.IO.DirectoryInfo subFolder in directory.GetDirectories())
                    fileSize += (long)GetFolderSize(subFolder.FullName, includesubfolders);
            }
            return fileSize;
        }
        public static long GetFileCount(string folderpath, bool includesubfolders)
        {
            long filecount = 0;
            DirectoryInfo directory = new DirectoryInfo(folderpath);

            foreach (System.IO.FileInfo fileInfo in directory.GetFiles())
                filecount++;

            if (includesubfolders)
            {
                foreach (System.IO.DirectoryInfo subFolder in directory.GetDirectories())
                    filecount += (long)GetFileCount(subFolder.FullName, includesubfolders);
            }
            return filecount;
        }
        public static long GetFileCount(string folderpath, bool includesubfolders,DateTime datefrom, DateTime dateto)
        {
            long filecount = 0;
            DirectoryInfo directory = new DirectoryInfo(folderpath);

            foreach (System.IO.FileInfo fileInfo in directory.GetFiles())
            {
                if(fileInfo.CreationTime >=datefrom && fileInfo.CreationTime <= dateto)
                    filecount++;
            }

            if (includesubfolders)
            {
                foreach (System.IO.DirectoryInfo subFolder in directory.GetDirectories())
                    filecount += (long)GetFileCount(subFolder.FullName, includesubfolders,datefrom,dateto);
            }
            return filecount;
        }
        public static long GetFolderSizeAndCount(string folderpath, bool includesubfolders, out long count)
        {
            long fileSize = 0;
            long filecount = 0;
            DirectoryInfo directory = new DirectoryInfo(folderpath);

            foreach (System.IO.FileInfo fileInfo in directory.GetFiles())
            {
                fileSize += fileInfo.Length;
                filecount++;
            }

            if (includesubfolders)
            {
                foreach (System.IO.DirectoryInfo subFolder in directory.GetDirectories())
                {
                    fileSize += (long)GetFolderSize(subFolder.FullName, includesubfolders);
                    filecount += (long)GetFileCount(subFolder.FullName, includesubfolders);
                }
            }
            count = filecount;
            return fileSize;
        }
    }
}
