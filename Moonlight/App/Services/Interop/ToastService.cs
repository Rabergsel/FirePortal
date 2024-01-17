using Microsoft.JSInterop;

namespace FirePortal.App.Services.Interop;

public class ToastService
{
    private readonly IJSRuntime JsRuntime;

    public ToastService(IJSRuntime jsRuntime)
    {
        JsRuntime = jsRuntime;
    }
    
    public async Task Info(string message)
    {
        await JsRuntime.InvokeVoidAsync("FirePortal.toasts.info", message);
    }
    
    public async Task Error(string message)
    {
        await JsRuntime.InvokeVoidAsync("FirePortal.toasts.error", message);
    }
    
    public async Task Warning(string message)
    {
        await JsRuntime.InvokeVoidAsync("FirePortal.toasts.warning", message);
    }
    
    public async Task Success(string message)
    {
        await JsRuntime.InvokeVoidAsync("FirePortal.toasts.success", message);
    }

    public async Task CreateProcessToast(string id, string text)
    {
        await JsRuntime.InvokeVoidAsync("FirePortal.toasts.create", id, text);
    }

    public async Task UpdateProcessToast(string id, string text)
    {
        await JsRuntime.InvokeVoidAsync("FirePortal.toasts.modify", id, text);
    }
    
    public async Task RemoveProcessToast(string id)
    {
        await JsRuntime.InvokeVoidAsync("FirePortal.toasts.remove", id);
    }
}