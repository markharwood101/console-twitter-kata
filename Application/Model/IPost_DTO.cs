using System;

namespace Application.Model
{
    public interface IPost_DTO
    {
        string Detail { get; set; }
        string CreatedBy { get; set; }
        DateTime CreatedDateStamp { get; set; }
    }
}
