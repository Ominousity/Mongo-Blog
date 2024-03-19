using Domain;

namespace Gateway_Application;

public class BlogService : IBlogService
{
    public Task<List<Blog>> GetBlogs()
    {
        throw new NotImplementedException();
    }

    public Task<Blog> GetBlog(int id)
    {
        throw new NotImplementedException();
    }

    public Task<Blog> CreateBlog(Blog blog)
    {
        throw new NotImplementedException();
    }

    public Task<Blog> UpdateBlog(Blog blog)
    {
        throw new NotImplementedException();
    }

    public Task DeleteBlog(int id)
    {
        throw new NotImplementedException();
    }
}
