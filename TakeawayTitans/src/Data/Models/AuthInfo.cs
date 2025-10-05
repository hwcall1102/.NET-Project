
namespace TakeawayTitans.Models;

public record AuthInfo(string? Name, bool IsAuthenticated, IEnumerable<KeyValuePair<string, string>> Claims);
