using Gym_TrackerAPI.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Json;

namespace Gym_Tracker.Pages
{
    public class SearchResultsModel : PageModel
    {
        private readonly HttpClient _httpClient;

        public SearchResultsModel(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public IList<Membership> MembershipList { get; set; } = new List<Membership>();

        public async Task<IActionResult> OnGetAsync(string membershipLevel, int? id)
        {
            try
            {
                string apiUrl = string.IsNullOrEmpty(membershipLevel) ?
                    $"https://localhost:7219/api/Memberships/{id}" :
                    $"https://localhost:7219/api/Memberships/{membershipLevel}";

                var response = await _httpClient.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    var jsonResponse = await response.Content.ReadAsStringAsync();
                    MembershipList = JsonSerializer.Deserialize<List<Membership>>(jsonResponse, new JsonSerializerOptions
                    {
                        PropertyNameCaseInsensitive = true
                    }) ?? new List<Membership>();
                }
                else
                {
                    MembershipList = new List<Membership>();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception: {ex.Message}");
                ModelState.AddModelError("", $"An error occurred: {ex.Message}");
            }

            return Page();
        }
    }
}