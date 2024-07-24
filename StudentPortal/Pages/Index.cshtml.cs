using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using StudentPortal.Model;

namespace StudentPortal.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;
    private readonly IHttpClientFactory _httpClientFactory;

    public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory)
    {
        _logger = logger;
        _httpClientFactory = httpClientFactory;
    }

    public void OnGet()
    {

    }

    [HttpGet]
    [ActionName("GetStudentRecord")]
    public async Task<IActionResult> GetStudentRecord(Student Student)
    {
        if(ModelState.IsValid && Student != null)
        {
            var client = _httpClientFactory.CreateClient("school.api");

            using HttpResponseMessage response = await client.GetAsync("api/Students");
            
            if(response.IsSuccessStatusCode)
            {
                var content = response.Content;
                 
            }
            else
            {
                //TODO: Throw Error
            }
        }
        else
        {
             
        }
    }
}
