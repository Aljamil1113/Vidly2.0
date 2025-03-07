﻿using AutoMapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Vidly2_0.Dtos;
using Vidly2_0.Models;

namespace Vidly2_0.Controllers.Api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;
        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: api/Movies
        public IHttpActionResult GetMovies(string query = null)
        {
            var movieQuery = _context.Movies.Include(g => g.GenreType).Where(m => m.NumberAvailable > 0);

            if (!String.IsNullOrWhiteSpace(query))
                movieQuery = movieQuery.Where(m => m.Name.Contains(query));
                
            var movieDto = movieQuery.ToList().Select(Mapper.Map<Movie, MovieDto>);

            return Ok(movieDto);
        }

        // GET: api/Movies/5
        public IHttpActionResult GetMovieDto(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            return Ok(Mapper.Map<Movie, MovieDto>(movie));
        }

        // PUT: api/Movies/5
        [HttpPut]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult UpdateMovie(int id, MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if(movieInDb == null)
            {
                return NotFound();
            }

            Mapper.Map(movieDto, movieInDb);
            
            _context.SaveChanges();

            return Ok();
        }

        // POST: api/Movies
        
        [HttpPost]
        [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult PostMovieDto(MovieDto movieDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var movie = Mapper.Map<MovieDto, Movie>(movieDto);
            _context.Movies.Add(movie);
            _context.SaveChanges();

            movieDto.Id = movie.Id;

            return Created(new Uri(Request.RequestUri + "/" + movie.Id), movieDto);
        }

        // DELETE: api/Movies/5
       [HttpDelete]
       [Authorize(Roles = RoleName.CanManageMovies)]
        public IHttpActionResult DeleteMovieDto(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null)
            {
                return NotFound();
            }

            _context.Movies.Remove(movie);
            _context.SaveChanges();

            return Ok();
        }
    }
}