using System;

namespace MeuTwitter.Domain
{
    public class Post
    {
        public long Id { get; set; }
        public string Message { get; private set; }
        public DateTime PostDate { get; private set; }
        public string DisplayPostDate { get; set; }

        public void SetMessage(string message, DateTime postDate)
        {
            Message = message;
            PostDate = postDate;
        }

        public bool Validate()
        {
            return !string.IsNullOrEmpty(Message)
                   && Message.Length <= 140
                   && PostDate < DateTime.Now;
        }
    }
}