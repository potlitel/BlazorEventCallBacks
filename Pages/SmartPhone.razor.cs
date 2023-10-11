using BlazorEventCallBacks.Models;
using Microsoft.AspNetCore.Components;

namespace BlazorEventCallBacks.Pages
{
    public partial class SmartPhone
    {
        [Parameter]
        public SmartPhoneEntity smartPhone { get; set; } = null!;

        [Parameter]
        public EventCallback<bool> OnFavouritePhoneSelection { get; set; }

        private async Task FavouritePhoneUpdated(ChangeEventArgs e)
        {
            await OnFavouritePhoneSelection.InvokeAsync((bool)e.Value!);
        }
    }
}