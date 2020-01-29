using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCMyApplication.Models
{
    public class UserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string FavoriteMusicArtist { get; set; }

        public string FavoriteSong { get; set; }
    }
}