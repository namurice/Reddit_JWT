﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Reddit.Models
{
    public class User : IdentityUser<int>
    {

        public string RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }
        public virtual ICollection<Post> Posts { get; set; } = new List<Post>();

        public virtual ICollection<Community>? SubscribedCommunities { get; set; } = new List<Community>();

        public virtual ICollection<Community>? OwnedCommunities { get; set; } = new List<Community>();

    }
}