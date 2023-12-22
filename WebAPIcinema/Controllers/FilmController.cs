using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebAPIcinema.Model.Context;
using WebAPIcinema.Model.Entity;

namespace WebAPIcinema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly FilmDbContext _filmDbContext;

        public FilmController(FilmDbContext filmDbContext)
        {
            _filmDbContext = filmDbContext;
        }
        [HttpGet]
        [Route("GetFilm")]
        public async Task<IEnumerable<Film>> GetFilms()
        {
            return await _filmDbContext.Film.ToListAsync();
        }

        [HttpPost]
        [Route("AddFilm")]
        public async Task<Film> AddFilm(Film objFilm)
        {
            _filmDbContext.Film.Add(objFilm);
            await _filmDbContext.SaveChangesAsync();
            return objFilm;
        }

        [HttpPatch]
        [Route("UpdateFilm/{id}")]
        public async Task<Film> UpdateFilm(Film objFilm)
        {
            _filmDbContext.Entry(objFilm).State = EntityState.Modified;
            await _filmDbContext.SaveChangesAsync();
            return objFilm;
        }

        [HttpDelete]
        [Route("DeleteFilm/{id}")]
        public bool DeleteFilm(int id)
        {
            bool a = false;
            var film = _filmDbContext.Film.Find(id);
            if (film != null)
            {
                a = true;
                _filmDbContext.Entry(film).State = EntityState.Deleted;
                _filmDbContext.SaveChanges();
            }
            else
            {
                a = false;
            }
            return a;

        }

    }
}
