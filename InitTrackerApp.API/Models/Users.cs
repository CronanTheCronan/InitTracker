using System;
using System.Collections.Generic;

namespace InitTrackerApp.API.Models
{
    public partial class Users
    {
        public Users()
        {
            Heroes = new HashSet<Heroes>();
            HeroesGroupXref = new HashSet<HeroesGroupXref>();
            Monsters = new HashSet<Monsters>();
        }

        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }

        public virtual ICollection<Heroes> Heroes { get; set; }
        public virtual ICollection<HeroesGroupXref> HeroesGroupXref { get; set; }
        public virtual ICollection<Monsters> Monsters { get; set; }
    }
}
