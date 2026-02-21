using ProjectManagementXarelto.Core.Models;


namespace ProjectManagementXarelto.Core.Common;

public static class SessionContext {
    public static User? CurrentUser { get; set; }
}