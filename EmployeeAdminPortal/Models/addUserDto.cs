namespace EmployeeAdminPortal.Models
{
    public class addUserDto
    {
        public required string Username { get; set; }

        public required string PasswordHash { get; set; }

        public required string Role { get; set; }
    }
}
