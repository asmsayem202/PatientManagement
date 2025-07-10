using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PatientManagement.Data;
using PatientManagement.Models;

namespace PatientManagement.Controllers
{
    [Authorize]
    public class MedicineController : Controller
    {
        private readonly ApplicationDbContext _context;

        public MedicineController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<IActionResult> Create(int PatientId, string Description)
        {
            if (string.IsNullOrWhiteSpace(Description))
                return RedirectToAction("Details", "Patient", new { id = PatientId });

            var medicine = new Medicine
            {
                PatientId = PatientId,
                Description = Description,
                Date = DateTime.Now
            };

            _context.Medicines.Add(medicine);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Patient", new { id = PatientId });
        }

        // GET: Medicine/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null) return NotFound();

            var medicine = await _context.Medicines.FindAsync(id);
            if (medicine == null) return NotFound();

            return View(medicine);
        }

        // POST: Medicine/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Description,Date,PatientId")] Medicine medicine)
        {
            if (id != medicine.Id) return NotFound();

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medicine);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_context.Medicines.Any(m => m.Id == id))
                        return NotFound();
                    throw;
                }
                return RedirectToAction("Details", "Patient", new { id = medicine.PatientId });
            }

            return View(medicine);
        }

        [HttpDelete("Medicine/DeleteAjax/{id}")]
        public async Task<IActionResult> DeleteAjax(int id)
        {
            var medicine = await _context.Medicines.FindAsync(id);
            if (medicine == null)
                return NotFound();

            _context.Medicines.Remove(medicine);
            await _context.SaveChangesAsync();

            return Ok();
        }


    }
}
