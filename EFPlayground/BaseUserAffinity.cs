using System.ComponentModel.DataAnnotations.Schema;

namespace EFPlayground
{
    public abstract class BaseUserAffinity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int Vote { get; set; }
        public int UserId { get; set; }
    }
}