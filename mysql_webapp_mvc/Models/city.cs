// For help on creating a model based on a table, see https://docs.microsoft.com/en-us/ef/core/modeling/

using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace mysql_webapp_mvc.Models
{
    public class city
    {
        /**
         * Since the primary key name doesn't have the suffix "Id", need to use
         * the data annotation "Key" to configure this property to be the
         * primary key.  The "Required" annotation configures properties to be
         * non-null.
         */
        [Key]
        public int ID { get; set; }
        // The name of the city
        [Required]
        public string Name { get; set; }
        // The country code of the city (e.g. USA, MEX, CAN)
        [Required]
        public string CountryCode { get; set; }
        // The district or state of the city (e.g. Colorado, Arizona)
        [Required]
        public string District { get; set; }
        // The population of the city
        [Required]
        public int Population { get; set; }
    }
}
