using Microsoft.AspNetCore.Components;

namespace FirePortal.App.Helpers;

public class ComponentHelper
{
    public static RenderFragment FromType(Type type) => builder =>
    {
        builder.OpenComponent(0, type);
        builder.CloseComponent();
    };
}