
using System;

namespace PlannerAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public User(string name)
        {
            Name = name;
        }

        public string Role { get; set; }
        public DateTime RegisterDate { get; set; }
        public bool Active { get; set; }
    }
}
