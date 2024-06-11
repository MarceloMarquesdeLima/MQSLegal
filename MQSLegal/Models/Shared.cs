using System.ComponentModel.DataAnnotations;

namespace MQSLegal.Models
{
    public class Shared
    {
        public Shared() { }
        public Shared(Guid id) 
        {
            this.Id = id;
        }

        [Required]
        public Guid Id { get; set; }
    }
}
