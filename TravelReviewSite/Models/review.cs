using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TravelReviewSite.Models
{
    public class Review
    {
        [Key]
        public int ReviewID { get; set; } /*<---Key should always be an int---->*/
        public string Title { get; set; }
        public string Description { get; set; }
       

        [ForeignKey("Category")]
        public int CategoryID { get; set; }
        public virtual Category Category { get; set; } /*<---navagation property--->*/

    }
} 