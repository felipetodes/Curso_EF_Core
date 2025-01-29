using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCare.Domain
{
   
        public class Coach: BaseDomainModel
        {
            public int Id { get; set; }
            public string Name { get; set; }

        }
    }
