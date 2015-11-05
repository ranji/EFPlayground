using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFPlayground
{
    public class AffinityDataInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<Affinity>
    {
        protected override void Seed(Affinity context)
        {
            var contents = new List<Content>()
            {
                new Content {Id = 1},
                new Content {Id = 2}
            };

            contents.ForEach(c=>context.Contents.Add(c));
            context.SaveChanges();

            var previewContents  = new List<PreviewContent>()
            {
                new PreviewContent{Id = 1},
                new PreviewContent{Id = 2}
            };

            var contentUserAffinities = new List<ContentUserAffinity>
            {
                new ContentUserAffinity {Content = contents[0], Vote = 1, UserId = 1},
                new ContentUserAffinity {Content = contents[1], Vote = 1, UserId = 1}
            };

            contentUserAffinities.ForEach(c=> context.UserAffinities.Add(c));

            var previewContentUserAffinities = new List<PreviewContentUserAffinity>
            {
                new PreviewContentUserAffinity() {PreviewContent = previewContents[0], Vote = 1, UserId = 1},
                new PreviewContentUserAffinity() {PreviewContent = previewContents[1], Vote = 1, UserId = 1}
            };

            previewContentUserAffinities.ForEach(p=>context.UserAffinities.Add(p));

            context.SaveChanges();
            
        }
    }
}
