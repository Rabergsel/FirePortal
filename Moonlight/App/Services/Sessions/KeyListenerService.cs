using Microsoft.JSInterop;

namespace FirePortal.App.Services.Sessions;

public class KeyListenerService
{
    private readonly IJSRuntime _jsRuntime;
    private DotNetObjectReference<KeyListenerService> _objRef;

    public event EventHandler<string> KeyPressed;

    public KeyListenerService(IJSRuntime jsRuntime)
    {
        _jsRuntime = jsRuntime;
    }

    public async Task Initialize()
    {
        _objRef = DotNetObjectReference.Create(this);
        await _jsRuntime.InvokeVoidAsync("FirePortal.keyListener.register", _objRef);
    }

    [JSInvokable]
    public void OnKeyPress(string key)
    {
        KeyPressed?.Invoke(this, key);
    }

    public async ValueTask DisposeAsync()
    {
        try
        {
            await _jsRuntime.InvokeVoidAsync("FirePortal.keyListener.unregister", _objRef);
            _objRef.Dispose();
        }
        catch (Exception) { /* ignored */}
    }
}