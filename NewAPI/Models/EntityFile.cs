using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NewAPI.Models
{
    [Serializable]
    public class EntityFile
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
    }
}