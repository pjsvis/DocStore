using System;
using System.IO;
using ServiceStack;
using ServiceStack.Text;

namespace DocStoreApi.BusinessLogic
{
    public class DocStoreIdent
    {
        public string DocStoreName { get; set; }
        public string DocStorePath { get; set; }
    }

    public class ManageDocStoreHelper
    {
        public bool CreateDocStore(string docStoreName, string docStoreRoot)
        {
            // Check path exists
            if (Directory.Exists(docStoreRoot))
                throw new Exception($@"Path already exists at {docStoreRoot}");

            // Create the docStoreRoot
            Directory.CreateDirectory(docStoreRoot);

            // Add an ident file
            var identFile = new DocStoreIdent
            {
                DocStoreName = docStoreName,
                DocStorePath = docStoreRoot
            };
            var identFileText = identFile.ToJson();
            var identFilePath = Constants.IdentFilePath(docStoreRoot);
            File.WriteAllText(identFilePath, identFileText);

            // TODO: Save the consts to web.config

            return File.Exists(identFilePath);
        }

        // TODO: Return an object with a list of errors
        public bool DocStoreExists(string docStoreName, string docStoreRoot)
        {
            var identJson = File.ReadAllText(Constants.IdentFilePath(docStoreRoot));
            var docStoreIdent = JsonSerializer.DeserializeFromString<DocStoreIdent>(identJson);
            var nameIsCorrect = docStoreIdent.DocStoreName == docStoreName;
            var pathIsCorrect = docStoreIdent.DocStorePath == docStoreRoot;
            return nameIsCorrect && pathIsCorrect;
        }


    }
}