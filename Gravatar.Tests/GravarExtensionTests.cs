using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravarExtensionTests { 
    
        [TestCategory("Gravatar Test")]
        [TestMethod("Should validate Gravatar extension")]
        [DataRow(null,null,false)]
        [DataRow(" ",null,false)]
        [DataRow("",200,false)]
        [DataRow("andre@balta.io",200,true)]
        [DataRow("abnerm80@gmail.com",200, false)]

        public void ShouldValidateGravatar(string email,int? size, bool status)
        {
            var imageSize = size.HasValue ? size.Value.ToString() : "80";
            var result = $"https://www.gravatar.com/avatar/8d9f6b0ffc9150878f1ae9e3ae9bfb07?s={imageSize}";
            Assert.AreEqual( (email.ToGravatar(size ??80) == result),status);
        }
    }
}
