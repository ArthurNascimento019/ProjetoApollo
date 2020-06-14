namespace ProjetoApollo.Authorization.Roles
{
    public static class StaticRoleNames
    {
        public static class Host
        {
            public const string Admin = "Admin";
            public const string Client = "Client";
        }

        public static class Tenants
        {
            public const string Admin = "Admin";
            public const string Medic = "Medic";
            public const string Lobby = "Lobby";
        }
    }
}