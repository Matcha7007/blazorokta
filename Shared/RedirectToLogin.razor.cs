using Microsoft.AspNetCore.Components;

using System;
using System.Collections.Generic;
using System.Linq;

namespace BlazorOkta.Shared
{
    public partial class RedirectToLogin : ComponentBase
    {
        [Inject] public NavigationManager Navigation { get; set; }

        protected override async Task OnInitializedAsync()
        {
            var returnUrl = Navigation.ToBaseRelativePath(Navigation.Uri);

            Navigation.NavigateTo($"Login?returnUrl={returnUrl}", true);
        }
    }
}
