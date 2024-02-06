using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterSetup.Domain.Entities
{
    public class Company
    {
        public int CompanyId { get; set; }
        public string Name { get; set; }
        public string NameBn { get; set; }
        public string Code { get; set; }
        public string Address { get; set; }
        public string AddressBn { get; set; }
        public string Phone { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateDate { get; set; }
    }
}
