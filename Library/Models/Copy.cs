using System.Collections.Generic;

namespace Library.Models
{
  public class Copy
  {
    public Copy()
    {
      JoinEntities = new HashSet<Checkout>();
    }
  

    public int CopyId { get; set; }
    public int BookId { get; set; }
    public virtual ICollection<Checkout> JoinEntities { get; }
  }
}