using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Kendo.Mvc.Grid.CRUD.Models
{
    public class Roles
    {
        public int rowid { get; set; }
        public int idUser { get; set; }
        public int idMenu { get; set; }
        public bool status { get; set; }
    }
}