using AutoMapper;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;
using Vidly2_0.Dtos;
using Vidly2_0.Models;

namespace Vidly2_0.Controllers.Api
{
    public class NewRentalController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalController()
        {
            _context = new ApplicationDbContext();
        }
        public IHttpActionResult CreateRental(NewRentalDto newRentalDto)
        {
            if (newRentalDto.MovieIds.Count == 0)
                return BadRequest("No Movie Ids have been given.");

            var customer = _context.Customers.Single(c => c.Id == newRentalDto.CustomerId);

            if (customer == null)
                return BadRequest("Customer ID is not valid");

            var movies = _context.Movies.Where(m => newRentalDto.MovieIds.Contains(m.Id)).ToList();

            if (movies.Count != newRentalDto.MovieIds.Count)
                return BadRequest("One or more MovieIds are invalid.");

            foreach (var movie in movies)
            {
                if(movie.NumberAvailable == 0)
                {
                    return BadRequest("Movie is not available.");
                }
                movie.NumberAvailable--;

                var rental = new NewRental
                {
                    Customer = customer,
                    Movie = movie,
                    DateRented = DateTime.Now
                };
                _context.Rentals.Add(rental);
            };

            _context.SaveChanges();


            return Ok();
        }


        
    }
}
