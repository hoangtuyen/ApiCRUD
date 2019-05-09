using System.Collections.Generic;

namespace WebAPICRUD.Models
{
    public class CategoryViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<ProductViewModel> ProductViewModels { get; set; }
    }
}