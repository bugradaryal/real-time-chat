using Microsoft.AspNetCore.Identity;
using System.Collections;
using System.Collections.Generic;

namespace real_time_chat.Models
{
    public class AppUser : IdentityUser
    {
        public AppUser()
        {
            Messages = new HashSet<Message>();
        }
        public virtual ICollection<Message> Messages { get; set; }
    }
}
