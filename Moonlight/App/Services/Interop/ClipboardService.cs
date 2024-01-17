using Microsoft.JSInterop;

namespace FirePortal.App.Services.Interop;

public class ClipboardService
{
    private readonly IJSRuntime JsRuntime;

    public ClipboardService(IJSRuntime jsRuntime)
    {
        JsRuntime = jsRuntime;
    }
    
    public async Task Copy(string data)
    {
        await JsRuntime.InvokeVoidAsync("FirePortal.clipboard.copy", data);
    }
}