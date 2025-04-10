﻿namespace Front.Models
{
    public class CommentWithUser
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int PostId { get; set; }
        public int UserId { get; set; }

        // 🔥 Cette propriété est requise pour accéder aux infos de l'utilisateur
        public User User { get; set; }
    }

}
