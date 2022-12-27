using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RazorPagesUI.Data;
using RazorPagesUI.Models;

namespace RazorPagesUI.Pages.Forms
{
    public class AddressFormModel : PageModel
    {
        private readonly RazorPagesUI.Data.RazorPagesUIContext _context;

        public AddressFormModel(RazorPagesUI.Data.RazorPagesUIContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public AddressModel AddressModel { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            //_context.AddressModel.Add(AddressModel);
            //await _context.SaveChangesAsync();

            return RedirectToPage("/Index", new {City = AddressModel.City});
        }
    }
}
