using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace EFPlayground
{
    [TestClass]
    public class LikeDislikeTests
    {
        private Affinity _context;

        [TestInitialize]
        public void BeforeEach()
        {
            _context = new Affinity();
            
        }

        [TestMethod]
        public void CanGetContentUserAffinity()
        {
            var affinities = _context.UserAffinities.Where(u=>u is ContentUserAffinity);
            Assert.IsTrue(affinities.Count()==2);
        }

        [TestMethod]
        public void CanGetPreviewContentUserAffinity()
        {
            var affinities = _context.UserAffinities.Where(u => u is PreviewContentUserAffinity);
            Assert.IsTrue(affinities.Count() == 2);
        }
    }
}
