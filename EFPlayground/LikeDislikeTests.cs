using System;
using System.Data.Entity;
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
            var affinities = _context.UserAffinities.OfType<ContentUserAffinity>();
            Assert.IsTrue(affinities.Count()==2);
        }

        [TestMethod]
        public void CanGetPreviewContentUserAffinity()
        {
            var affinities = _context.UserAffinities.OfType<PreviewContentUserAffinity>();
            Assert.IsTrue(affinities.Count() == 2);
        }

        [TestMethod]
        public void CanGetEventContentUserAffinityByEventId()
        {
            var affinity = _context.UserAffinities.OfType<EventUserAffinity>().Include(eu=>eu.Event).SingleOrDefault(e => e.Event.Id == 1);
            Assert.IsTrue(affinity.Event.Id == 1);
        }
    }
}
