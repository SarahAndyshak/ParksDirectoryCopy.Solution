using ParksDirectory.Models;

namespace ParksDirectory
{
  public class ParkResponse
  {
    public List<Park> Parks { get; set; } = new List<Park>();
    public int Pages { get; set; }
    public int CurrentPage { get; set; }
  }
}