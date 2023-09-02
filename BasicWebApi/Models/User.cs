namespace BasicWebApi.Models
{
    public partial class User
    {
        public int Id { get; set; }

        public string? FullName { get; set; }

        public string EmailId { get; set; } = null!;

        public string? Password { get; set; }

        public string? Designation { get; set; }
    }
}
