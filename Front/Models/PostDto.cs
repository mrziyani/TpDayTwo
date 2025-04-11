﻿namespace Front.Models
{
    public class PostDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreatedAt { get; set; }
        public int UserId { get; set; }
        public List<CommentWithUser> Comments { get; set; }
        public User? User { get; set; }
    }
}
