using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_lesson_3_2
{
    class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public UserProfile Profile { get; set; }
    }
}
