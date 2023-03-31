using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ParksDirectory.Models;

namespace ParksDirectory.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  
  public class ParksController : ControllerBase
  {
    private readonly ParksDirectoryContext _db;

    public ParksController(ParksDirectoryContext db)
    {
      _db = db;
    }

    // GET api/parks
    [HttpGet]
    public async Task<List<Park>> Get(string name, string classification, string location, string majorLandmarks, int yearFounded, int foundedBefore, int foundedAfter)
    {
      IQueryable<Park> query = _db.Parks.AsQueryable();

      if(name != null)
      {
        query = query.Where(entry => entry.Name == name);
      }

      if(classification != null)
      {
        query = query.Where(entry => entry.Classification == classification);
      }

      if(location != null)
      {
        query = query.Where(entry => entry.Location == location);
      }

      if(majorLandmarks != null)
      {
        query = query.Where(entry => entry.MajorLandmarks == majorLandmarks);
      }

      if(yearFounded != 0)
      {
        query = query.Where(entry => entry.YearFounded == yearFounded);
      }

      // add search parameters for finding parks founded before/after certain year
      if(foundedAfter > 0)
      {
        query = query.Where(entry => entry.YearFounded >= foundedAfter);
      }

      if(foundedBefore > 0)
      {
        query = query.Where(entry => entry.YearFounded <= foundedBefore);
      }

      return await query.ToListAsync();
    }

    // GET api/parks/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Park>> GetPark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);

      if(park == null)
      {
        return NotFound();
      }
      return park;
    }

    // POST api/parks
    [HttpPost]
    public async Task<ActionResult<Park>> Post(Park park)
    {
      _db.Parks.Add(park);
      await _db.SaveChangesAsync();
      return CreatedAtAction(nameof(GetPark), new { id = park.ParkId }, park);
    }

    // PUT api/parks/5
    [HttpPut("{id}")]
    public async Task<IActionResult> Put(int id, Park park)
    {
      if (id != park.ParkId)
      {
        return BadRequest();
      }
      _db.Parks.Update(park);

      try
      {
        await _db.SaveChangesAsync();
      }
      catch (DbUpdateConcurrencyException)
      {
        if (!ParkExists(id))
        {
          return NotFound();
        }
        else
        {
          throw;
        }
      }
      return NoContent();
    }

    private bool ParkExists(int id)
    {
      return _db.Parks.Any(e => e.ParkId == id);
    }

    // DELETE api/parks/5
    [HttpDelete("{id}")]
    public async Task<IActionResult> DeletePark(int id)
    {
      Park park = await _db.Parks.FindAsync(id);
      if (park == null)
      {
        return NotFound();
      }

      _db.Parks.Remove(park);
      await _db.SaveChangesAsync();

      return NoContent();
    }

    // GET api/parks/page/2
    [HttpGet("page/{page}")]
    public async Task<ActionResult<List<Park>>> GetParks(int page)
    {
      if (_db.Parks == null)
        return NotFound();

      var pageResults = 2f;
      var pageCount = Math.Ceiling(_db.Parks.Count() / pageResults);

      var parks = await _db.Parks
                      .Skip((page - 1) * (int)pageResults)
                      .Take((int)pageResults)
                      .ToListAsync();
      
      var response = new ParkResponse
      {
        Parks = parks,
        CurrentPage = page,
        Pages = (int)pageCount,
      };

      return Ok(response);
    }
  }
}