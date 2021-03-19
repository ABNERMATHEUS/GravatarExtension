using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Gravatar.Tests
{
    [TestClass]
    public class GravarExtensionTests { 
    
        [TestCategory("Gravatar Test")]
        [TestMethod("Should validate Gravatar extension")]
        [DataRow(null,false)]
        [DataRow(" ",false)]
        [DataRow("",false)]
        [DataRow("andre@balta.io",true)]
        [DataRow("abnerm80@gmail.com", false)]

        public void ShouldValidateGravatar(string email, bool status)
        {
            var result = $"https://www.gravatar.com/avatar/8d9f6b0ffc9150878f1ae9e3ae9bfb07";
            Assert.AreEqual( (email.ToGravatar() == result),status);
        }
    }
}
