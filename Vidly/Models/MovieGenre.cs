using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class MovieGenre
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]

        public byte Id { get; set; }

        public string Name { get; set; }

    }
}