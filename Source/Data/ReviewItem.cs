using System;

namespace Critr.Data
{
  public class ReviewItem
  {
    //-------------------------------------------------------------------------

    public int Id { get; private set; }
    public bool Active { get; set; }
    public User CreatedByUser { get; set; }
    public DateTime Timestamp { get; set; }
    public Changelist Changelist { get; set; }
    public string FilePath { get; set; }
    public int FileRevision { get; set; }
    public string Content { get; set; }

    //-------------------------------------------------------------------------

    public ReviewItem()
    {
      Id = -1;
      Active = false;
      CreatedByUser = null;
      Timestamp = DateTime.Now;
      Changelist = null;
      FilePath = "";
      FileRevision = -1;
      Content = "";
    }

    //-------------------------------------------------------------------------
  }
}
