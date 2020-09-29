using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServerDemoApp.Models
{
    public class OrderUpdateModel
    {
        public int Id { get; set; }

        [DisplayName("Name for the order")]
        [MaxLength(20, ErrorMessage = "You need to keep the name to a max of 20 characters")]
        [MinLength(3, ErrorMessage = "You need to enter at least 3 characters for a valid order name")]
        [Required]
        public string OrderName { get; set; }
    }
}
