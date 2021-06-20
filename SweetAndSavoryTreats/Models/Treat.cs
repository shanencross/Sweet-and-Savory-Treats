using System.Collections.Generic;

namespace SweetAndSavoryTreats.Models
{
  public class Treat
  {
    public int TreatId { get; set; }
    public string Name { get; set; }

    public float Price { get; set; }
    public virtual ICollection<FlavorTreat> FlavorTreats { get; }

    public Treat()
    {
      this.FlavorTreats = new HashSet<FlavorTreat>();
    }
  }                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         
}