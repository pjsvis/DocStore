using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace DocStoreApi.BusinessLogic
{
    public static class Constants
    {
        public const string IdentFile = "DocStore.json";

        public static string IdentFilePath(string docStoreRoot)
        {
            // TODO: Make this a constant shared through out the app
            return Path.Combine(docStoreRoot, Constants.IdentFile);
        }

    }
}