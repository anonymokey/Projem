using System.ComponentModel.DataAnnotations;

namespace Projem.Entities
{
    public class Slider : IEntity
    {
        public int Id { get; set; }
        [StringLength(200)]
        public string? Baslik {  get; set; }
        [StringLength(400)]
        public string? Aciklama { get; set; }
        [StringLength(200)]
        public string? Gorsel { get; set; }
        [StringLength(200)]
        public string? Link { get; set; }
    }
}