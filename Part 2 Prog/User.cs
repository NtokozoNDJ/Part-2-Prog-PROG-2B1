﻿namespace Part_2_Prog.Models
{
    public class User
    {
        public int UserID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }  // "Lecturer", "Coordinator", "Manager"
    }
}