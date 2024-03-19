using Domain;
using Blog_Application;
using MongoDB.Driver;

namespace Blog_Repository;

public class BlogRepository : IBlogRepository
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
        return await Task.Run(() => 
            collection.AsQueryable()
            .ToList()
        );
    }

    public async Task<Blog> GetBlog(int id)
    {
        return await Task.Run(() => 
            collection.Find(b => b.BlogId == id)
            .FirstOrDefault()
        );
    }

    public async Task<Blog> CreateBlog(Blog blog)
    {
        return await Task.Run(() => {
            collection.InsertOne(blog);
            return blog;
        });
    }

    public Task<Blog> UpdateBlog(Blog blog)
    {
        return Task.Run(() => {
            collection.ReplaceOne(b => b.BlogId == blog.BlogId, blog);
            return blog;
        });
    }

    public Task DeleteBlog(int id)
    {
        return Task.Run(() => {
            collection.DeleteOne(b => b.BlogId == id);
        });
    }
}
