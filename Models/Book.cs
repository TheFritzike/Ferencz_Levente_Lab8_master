using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Castle.MicroKernel.SubSystems.Conversion;

namespace Ferencz_Levente_Lab8.Models
{
  public class Book
  {
    public int ID { get; set; }
    [Display(Name = "Book Title")]
    public string Title { get; set; }
    public string Author { get; set; }
    [Column(TypeName = "decimal(6, 2)")]
    public decimal Price { get; set; }
  }
}
