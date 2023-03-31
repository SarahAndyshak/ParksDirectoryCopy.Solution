namespace ParksDirectory.Models
{
  public class Park
  {
    public int ParkId { get; set; }

    public string Name { get; set; }

    public string Classification { get; set; }

    public string Location { get; set; }

    public string MajorLandmarks { get; set; }

    public string Activities { get; set;}

    public string Facilities { get; set; }

    public int YearFounded { get; set; }
  }
}