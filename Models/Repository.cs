namespace WebApplication1.Models;

public static class Repository
{
    private static List<MeetingInfo> _meeting = new();
    
    private static List<UserInfo> _users = new();

    static Repository()
    {
        _meeting.Add((new MeetingInfo()
        {
            MeetingId = 1,
            MeetingLocation = "Meeting Room 1",
            MeetingDate = DateTime.Now.AddHours(1),
            MeetingNumberOfPeople = 10
        }));
        _meeting.Add((new MeetingInfo()
        {
            MeetingId = 2,
            MeetingLocation = "Meeting Room 2",
            MeetingDate = DateTime.Now.AddHours(2),
            MeetingNumberOfPeople = 10
        }));
        _meeting.Add((new MeetingInfo()
        {
            MeetingId = 3,
            MeetingLocation = "Meeting Room 3",
            MeetingDate = DateTime.Now.AddHours(3),
            MeetingNumberOfPeople = 10
        }));
        _meeting.Add(new MeetingInfo()
        {
            MeetingId = 4,
            MeetingLocation = "Meeting Room 4",
            MeetingDate = DateTime.Now.AddHours(4),
            MeetingNumberOfPeople = 10
        });
        _users.Add(new UserInfo()
        {
            Id = 1,
            Name = "Ahmet",
            Email = "abcf@gmail.com",
            Phone = "22222",
            WillAttend = true
        });
        _users.Add(new UserInfo()
        {
            Id = 2,
            Name = "Mehmet",
            Email = "abce@gmail.com",
            Phone = "444444",
            WillAttend = false
        });
        _users.Add(new UserInfo()
        {
            Id = 3,
            Name = "Ceylan",
            Email = "abcd@gmail.com",
            Phone = "333333",
            WillAttend = true
        });
    }

    public static List<MeetingInfo> Meetings
    {
        get
        {
           return _meeting;
        }
    }
    
    public static List<UserInfo> Users
    {
        get
        {
            return _users;
        }
    }

    public static void CreateUser(UserInfo user)
    {
        user.Id = Users.Count + 1;
        _users.Add(user);
    }

    public static UserInfo? GetById(int id)
    {
        return _users.FirstOrDefault(user => user.Id == id);
    }
}