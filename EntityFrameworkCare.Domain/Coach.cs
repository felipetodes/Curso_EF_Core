using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkCare.Domain
{
    public abstract class BaseDomainModel
    {
        public DateTime CreatedDate { get; set; }

    }
        public class Coach
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime CreatedDate { get; set; }

    }

    public class Team
    {
        public int TeamId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }


    }

}
