namespace OBM.App.ViewModels
{
    public class AccountVM
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string DisplayName { get; set; }
        public string Email { get; set; }
        public int RoleID { get; set; }
        public virtual RoleVM Role { get; set; }
    }
}