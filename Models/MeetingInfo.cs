namespace WebApplication1.Models;

public class MeetingInfo
{
    public int MeetingId { get; set; }
    public string? MeetingLocation { get; set; }
    public DateTime MeetingDate { get; set; }
    public int MeetingNumberOfPeople { get; set; }
}