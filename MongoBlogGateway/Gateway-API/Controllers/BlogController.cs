using Gateway_Application;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Blog_API;

[ApiController]
public class BlogController : ControllerBase
{
    private readonly IBlogService _blogService;

    public BlogController(IBlogService blogService)
    {
        _blogService = blogService;
    }

    [HttpGet("GetBlogs")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<List<Blog>>> GetBlogs()
    {
        var blogs = await _blogService.GetBlogs();

        return Ok(blogs);
    }

    [HttpGet("GetBlog/{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<Blog>> GetBlog(int id)
    {
        var blog = await _blogService.GetBlog(id);
        
        return Ok(blog);
    }

    [HttpPost("CreateBlog")]
    [ProducesResponseType(StatusCodes.Status201Created)]
    public async Task<ActionResult<Blog>> CreateBlog(Blog blog)
    {
        var newBlog = await _blogService.CreateBlog(blog);

        return CreatedAtAction(nameof(GetBlog), new { id = newBlog.BlogId }, newBlog);
    }

    [HttpPut("UpdateBlog")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    public async Task<ActionResult<Blog>> UpdateBlog(Blog blog)
    {
        var updatedBlog = await _blogService.UpdateBlog(blog);
        
        return Ok(updatedBlog);
    }

    [HttpDelete("DeleteBlog/{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public async Task<ActionResult> DeleteBlog(int id)
    {
        await _blogService.DeleteBlog(id);

        return NoContent();
    }
}
