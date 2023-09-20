﻿using Microsoft.AspNetCore.Components;
using Microsoft.Fast.Components.FluentUI.Utilities;


namespace Microsoft.Fast.Components.FluentUI;

public partial class FluentFooter : FluentComponentBase
{
    protected string? ClassValue => new CssBuilder(Class)
        .AddClass("footer")
        .Build();

    protected string? StyleValue => new StyleBuilder(Style).Build();

    /// <summary>
    /// Gets or sets the content to be rendered inside the component.
    /// </summary>
    [Parameter]
    public RenderFragment? ChildContent { get; set; }
}