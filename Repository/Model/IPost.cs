using System;

namespace Repository.Model
{
    public interface IPost
    {
        string Detail { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDateStamp { get; set; }
    }
}
