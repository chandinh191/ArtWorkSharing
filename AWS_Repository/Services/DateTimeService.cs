using AWS_DAO.Common.Interfaces;

namespace AWS_Repository.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
