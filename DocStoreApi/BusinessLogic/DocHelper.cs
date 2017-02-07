using System.IO;
using System.Web;

namespace DocStoreApi.BusinessLogic
{
    public class DocHelper
    {
        public byte[] GetIdentFileBytes()
        {
            // // TODO: If docId is zero then get the ident file
            var filePath = VirtualPathUtility.Combine(Constants.DocStoreRoot, Constants.IdentFile);
            var fileBytes = File.ReadAllBytes(filePath);
            return fileBytes;
        }
    }
}