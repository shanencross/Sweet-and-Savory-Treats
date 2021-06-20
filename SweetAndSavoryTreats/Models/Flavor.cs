using System.Collections.Generic;

namespace SweetAndSavoryTreats.Models
{
  public class Flavor
  {
    public int FlavorId { get; set; }
    public string Name { get; set; }
    public virtual ICollection<FlavorTreat> FlavorTreats { get; }

    public Flavor()
    {
      this.FlavorTreats = new HashSet<FlavorTreat>();
    }

  }
}