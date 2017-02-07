using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DocStoreApi.BusinessLogic;
using NUnit.Framework;

namespace DocStoreTests
{
    [TestFixture]
    public class DocStoreHelperTests
    {
        [Test]
        public void CreateDocStore()
        {
            var dsh = new ManageDocStoreHelper();
            // TODO: Get this from web.config
            string docStoreName = Constants.DocStoreName;
            string docStoreRoot = Constants.DocStoreRoot;
            bool isCreated = dsh.CreateDocStore(docStoreName, docStoreRoot);

        }
    }
}
