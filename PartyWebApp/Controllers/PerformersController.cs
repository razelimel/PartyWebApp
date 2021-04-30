using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SpotifyAPI.Web;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PartyWebApp.Data;
using PartyWebApp.Models;
using PartyWebApp.Services;

namespace PartyWebApp.Controllers
{
    public class PerformersController : Controller
    {
        private readonly PartyWebAppContext _context;
        private readonly ISpotifyClientService _spotifyClientService;

        public PerformersController(PartyWebAppContext context, ISpotifyClientService spotifyClientService)
        {
            _context = context;
            _spotifyClientService = spotifyClientService;

        }

        // GET: Performers
        public async Task<IActionResult> Index()
        {
            var performersDTO = await _context.Performer.ToListAsync();
            var performers = await _spotifyClientService.GetArtists(performersDTO);
            return View(performers);
        }

        // GET: Performers/Details/5
        public async Task<IActionResult> Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var performer = await _spotifyClientService.GetArtist(new Performer { SpotifyId = id });

            if (performer == null)
            {
                return NotFound();
            }

            return View(performer);
        }

        // GET: Performers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Performers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,SpotifyId")] Performer performer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(performer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(performer);
        }

        // GET: Performers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var performer = await _context.Performer
                .FirstOrDefaultAsync(m => m.Id == id);
            if (performer == null)
            {
                return NotFound();
            }

            return View(performer);
        }

        // POST: Performers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var performer = await _context.Performer.FindAsync(id);
            _context.Performer.Remove(performer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PerformerExists(int id)
        {
            return _context.Performer.Any(e => e.Id == id);
        }
    }
}
