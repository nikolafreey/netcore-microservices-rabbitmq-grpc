using System.ComponentModel.DataAnnotations;

namespace CommandsService.Dtos
{
    public class PlatformCreateDto
    {
        [Required]
        public int ExternalId { get; set; }
        [Required]
        public string Name { get; set; }
    }
}