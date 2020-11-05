﻿using AccioVegialis.Data.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AccioVegialis.Data
{
    public class Recipes
    {
        public Recipes() 
        {
            this.Ingredients = new HashSet<Vegetables>();
            this.Comments = new HashSet<RecipeComments>();
            this.FavoritedBy = new HashSet<ApplicationUser>();
        }
        // [ForeignKey(nameof(User))]
        [Key]
        public int RecipeID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        [ForeignKey(nameof(UserName))]
        public virtual ApplicationUser Author { get; set; }
        public string UserName { get; set; }
        public virtual ICollection<Vegetables> Ingredients { get; set; }
        [Required]
        public string RecipeText { get; set; }
        public virtual ICollection<Recipecomments> Comments { get; set; }
        public virtual ICollection<ApplicationUser> FavoritedBy { get; set; }
        [Required]
        public DateTimeOffset CreatedUTC { get; set; }
        public DateTimeOffset? ModifiedUTC { get; set; }//?Do we need this for sure?
        public Guid OwnerID { get; set; }
    }
}
