using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using WebAppStarter9.DTO;
using WebAppStarter9.Model;

namespace WebAppStarter9.Pages.Students
{
    public class InsertModel : PageModel
    {
        [BindProperty]
        public StudentInsertDTO? StudentInsertDTO { get; set; }

        public StudentReadOnlyDTO? StudentReadOnlyDTO { get; set; }

        public SelectList? Cities { get; set; }
        public void OnGet()
        {
            StudentInsertDTO = new StudentInsertDTO();
            LoadCites();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                LoadCites();
                return Page();
            }

            // Service
            StudentReadOnlyDTO = new StudentReadOnlyDTO(1, StudentInsertDTO?.Firstname, StudentInsertDTO?.Lastname);

            TempData["StudentName"] = $"{StudentInsertDTO?.Firstname}, {StudentInsertDTO?.Lastname}";

            return RedirectToPage("/Students/Success");
        }

        private void LoadCites()
        {
            Cities = new SelectList(new List<City>()
            {
                new City { Id = 1, Name = "Athens" },
                new City { Id = 2, Name = "Thessaloniki" },
                new City { Id = 3, Name = "Patra" },
                new City { Id = 4, Name = "Lamia" },
            }.OrderBy(c => c.Name), nameof(City.Id), nameof(City.Name));
        }
    }
}
