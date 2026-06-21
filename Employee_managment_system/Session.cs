namespace Employee_managment_system
{
    public static class Session
    {
        public static AuthService.LoginResult CurrentUser { get; set; }

        public static bool IsLoggedIn
        {
            get { return CurrentUser != null && CurrentUser.Success; }
        }

        public static bool IsAdmin
        {
            get { return CurrentUser != null && CurrentUser.Role == "Admin"; }
        }

        public static void Logout()
        {
            if (CurrentUser != null && CurrentUser.Success)
            {
                AuthService.LogUserAction(CurrentUser.UserID, "Logout");
            }
            CurrentUser = null;
        }
    }
}