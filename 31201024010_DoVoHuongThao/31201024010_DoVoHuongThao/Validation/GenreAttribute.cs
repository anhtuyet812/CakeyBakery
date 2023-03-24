using _31201024010_DoVoHuongThao.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _31201024010_DoVoHuongThao.Validation
{
    public class GenreAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext
validationContext)
        {
            int genreID = int.Parse(value.ToString());
            var db = new ApplicationDbContext();
            if (db.Genres.Any(x => x.ID == genreID))
            {
                return ValidationResult.Success;
            }
            return new ValidationResult(
            ErrorMessage ?? "Genre khong ton tai");
        }
    }
}