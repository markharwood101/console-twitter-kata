﻿using Application.Model;

namespace Application.Ports
{
    public interface IPostRepository
    {
        void Add(IPost_DTO post);
    }
}
