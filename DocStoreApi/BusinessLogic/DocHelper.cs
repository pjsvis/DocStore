using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DocStoreApi.BusinessLogic
{
    public class DocHelper
    {
        public  byte[] GetIdentFileBytes()
        {
            // // TODO: If docId is zero then get the ident file
            var filePath = Constants.IdentFilePath()
            var fileBytes = System.IO.File.ReadAllBytes()
           return new byte[0];
        }
    }
}