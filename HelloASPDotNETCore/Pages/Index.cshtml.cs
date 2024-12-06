using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HelloASPDotNETCore.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    // 用于存储要在页面上显示的消息
    public string Message { get; private set; } = string.Empty;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        // 设置消息为当前时间
        Message = $"The current server time is {DateTime.Now}.";
    }
}
