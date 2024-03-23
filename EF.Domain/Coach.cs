namespace EF.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class Coach : BaseDomainModel
    {
        
        // public int Id { get; set; }
        
        [MaxLength(100)]
        [Required]
        public string Name { get; set; } 
        
        // public virtual Team? Team { get; set; }
    
    }
}