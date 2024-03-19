using System.Net.Http.Json;
using Domain;

namespace Gateway_Application;

public class BlogRepository : IBlogRepository
{
    public BlogRepository()
    {
    }

    public async Task<List<Blog>> GetBlogs()
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://localhost:5001");
            var response = await client.GetAsync("/api/blogs");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<List<Blog>>();
        }
    }

    public async Task<Blog> GetBlog(int id)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://localhost:5001");
            var response = await client.GetAsync($"/api/blogs/{id}");
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Blog>();
        }
    }

    public async Task<Blog> CreateBlog(Blog blog)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://localhost:5001");
            var response = await client.PostAsJsonAsync("/api/blogs", blog);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Blog>();
        }
    }

    public async Task<Blog> UpdateBlog(Blog blog)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://localhost:5001");
            var response = await client.PutAsJsonAsync($"/api/blogs/{blog.BlogId}", blog);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<Blog>();
        }
    }

    public async Task DeleteBlog(int id)
    {
        using (var client = new HttpClient())
        {
            client.BaseAddress = new Uri("https://localhost:5001");
            var response = await client.DeleteAsync($"/api/blogs/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
