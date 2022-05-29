using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmprendeUCR_WebApplication.Data.Entities
{
    public class Report
    {
        [Key]
        /**
        * @brief setter and getter of the Primary Key of Report
        */
        public int ID { get; set; }
        /**
        * @brief setter and getter of the Title of the Report
        */
        public string Title { get; set; }
        /**
        * @brief setter and getter of the description of a Report
        */
        public string Content { get; set; }
    }
}
