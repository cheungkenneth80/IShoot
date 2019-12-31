using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IShoot.Models
{
    public class Photo
    {
        public int Id { get; set; }
        public string Description { get; set; }

        //The DataType attribute on ReleaseDate specifies the type of the data(Date). With this attribute:
            //The user is not required to enter time information in the date field.
            //Only the date is displayed, not time information.

       [DataType(DataType.Date)]
        public DateTime created_at { get; set; }
        public string Url { get; set; }

    }
}
