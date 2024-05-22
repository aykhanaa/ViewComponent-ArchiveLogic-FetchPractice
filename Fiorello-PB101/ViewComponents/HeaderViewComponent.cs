using Fiorello_PB101.Services;
using Fiorello_PB101.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Fiorello_PB101.ViewComponents
{
    public class HeaderViewComponent : ViewComponent
    {
        private readonly ISettingsService _settingsService;
        public HeaderViewComponent(ISettingsService settingsService)
        {
            _settingsService = settingsService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View(await _settingsService.GetAllAsync()));
        }
    }
}
