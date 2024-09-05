namespace OfflineUserStorage.Models
{
    public class UserModel
    {
        public DateTime CreateDate { get; set; } = DateTime.UtcNow;
        public string Name { get; set; }
        public bool IsComplete { get; set; }
    }
}
