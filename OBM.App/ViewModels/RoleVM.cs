using System.Collections.Generic;

namespace OBM.App.ViewModels
{
    public class RoleVM
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AccountVM> Accounts { get; set; }
    }
}