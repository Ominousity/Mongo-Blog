using Domain;

namespace Blog_Application;

public interface IBlogService
{
    /// <summary>
    /// Retrieves a list of all blogs.
    /// </summary>
    /// <returns>A task that represents the asynchronous operation. The task result contains the list of blogs.</returns>
    public Task<List<Blog>> GetBlogs();

    /// <summary>
    /// Retrieves a specific blog by its ID.
    /// </summary>
    /// <param name="id">The ID of the blog to retrieve.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the retrieved blog.</returns>
    public Task<Blog> GetBlog(int id);

    /// <summary>
    /// Creates a new blog.
    /// </summary>
    /// <param name="blog">The blog object to create.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the created blog.</returns>
    public Task<Blog> CreateBlog(Blog blog);

    /// <summary>
    /// Updates an existing blog.
    /// </summary>
    /// <param name="blog">The updated blog object.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the updated blog.</returns>
    public Task<Blog> UpdateBlog(Blog blog);

    /// <summary>
    /// Deletes a blog by its ID.
    /// </summary>
    /// <param name="id">The ID of the blog to delete.</param>
    /// <returns>A task that represents the asynchronous operation.</returns>
    public Task DeleteBlog(int id);
}
