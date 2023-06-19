using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorOkta.Shared
{
    public partial class LoginDisplay : ComponentBase
    {
        [Inject] public NavigationManager Navigation { get; set; }
        [Parameter] public string ReturnUrl { get; set; }

        protected override async Task OnInitializedAsync()
        {
            ReturnUrl = Navigation.ToBaseRelativePath(Navigation.Uri);
        }
    }
}
