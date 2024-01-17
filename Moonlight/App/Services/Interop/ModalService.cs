using Microsoft.JSInterop;

namespace FirePortal.App.Services.Interop;

public class ModalService
{
    private readonly IJSRuntime JsRuntime;

    public ModalService(IJSRuntime jsRuntime)
    {
        JsRuntime = jsRuntime;
    }

    public async Task Show(string name)
    {
        await JsRuntime.InvokeVoidAsync("FirePortal.modals.show", name);
    }

    public async Task Hide(string name)
    {
        await JsRuntime.InvokeVoidAsync("FirePortal.modals.hide", name);
    }
}