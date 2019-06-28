using AutoMapper;
using Application.Model;
using Application.Ports;
using Repository.Contexts;
using Repository.Model;

namespace Repository.Repositories
{
    public class PostRepository : IPostRepository
    {
        // PRIVATE FIELDS:
        private readonly IContext _context;
        private readonly IMapper _mapper;

        // CONSTRUCTOR:
        public PostRepository(IContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // PUBLIC METHODS:
        public void Add(IPost_DTO post)
        {
            _context.Posts.Add(_mapper.Map<Post>(post));
        }
    }
}
