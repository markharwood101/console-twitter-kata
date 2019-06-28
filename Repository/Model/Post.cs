using System;

namespace Repository.Model
{
    public class Post : IPost
    {
        public string Detail { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDateStamp { get; set; }
    }
}
