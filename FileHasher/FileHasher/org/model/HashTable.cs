using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FileHasher.org.model
{
    public class HashTable
    {
        /// <summary>
        /// Файлы и хеши файлов в корневом каталоге
        /// </summary>
        public List<PathAndMD5> FilePathAndHash { get; set; }

        public HashTable()
        {
            this.FilePathAndHash = new List<PathAndMD5>();
        }
    }

    public class PathAndMD5
    {
        public string File { get; set; }
        public string MD5 { get; set; }

        public PathAndMD5(string path, string md5)
        {
            this.File = path;
            this.MD5 = md5;
        }
    }
}
