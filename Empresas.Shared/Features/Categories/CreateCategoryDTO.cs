using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empresas.Shared.Features.Categories
{
    public class CreateCategoryDTO
    {
        public int CategoryId { get; set; }
        public string Description { get; set; }

        public bool isActive { get; set; }
    }
}
