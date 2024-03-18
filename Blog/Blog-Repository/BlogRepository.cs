using Domain;
using MongoDB.Bson;
using MongoDB.Driver;

namespace Blog_Repository;

public class BlogRepository
{
    public IMongoCollection<Blog> collection;


    public BlogRepository()
    {
        var client = new MongoClient("mongodb://localhost:27017");
        var db = client.GetDatabase("blog");
        collection = db.GetCollection<Blog>("blogs");
    }

    public async Task<List<Blog>> GetBlogs()
    {
        List<Blog> blogs = await Task.Run(() => collection.AsQueryable().ToList());

        return blogs;
    }

    public Task<Blog> GetBlog(int id)
    {
        Blog blog = collection.Find(b => b.BlogId == id).FirstOrDefault();

        return Task.FromResult(blog);
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
