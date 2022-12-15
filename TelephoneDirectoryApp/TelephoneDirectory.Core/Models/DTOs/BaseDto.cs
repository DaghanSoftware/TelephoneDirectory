namespace TelephoneDirectory.Core.Models.DTOs
{
    public abstract class BaseDto
    {
        public int Id { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
