using System;
using System.Configuration;
using System.IO;

namespace DocStoreApi.BusinessLogic
{
    public static class Constants
    {
        public const string IdentFile = "DocStore.json";

        public static string DocStoreRoot => ConfigurationManager.AppSettings["DocStoreRoot"];
        public static string DocStoreName => ConfigurationManager.AppSettings["DocStoreName"];

        public static string IdentFilePath(string docStoreRoot)
        {
            return Path.Combine(DocStoreRoot, IdentFile);
        }

        public static string FilePath(long fileId)
        {
            var filePath = string.Empty;
            // 12345678 => 
            // MaxInt => 2147483647
            // MaxLong => 9223372036854775807           
            // MaxLongPath => 92/23/37/20/36/85/47/75/80/7
            // MaxLongPath => 92/23/37/20/36/85/47/75/9223372036854775.doc
            // MaxDocId => 9223372036854775
            throw new Exception("Not implemented");
        }
    }
}