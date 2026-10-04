namespace BlazorDeepDive.Models
{
    public static class ServersRepository
    {

        private static List<Server> servers = new List<Server>()
        {

            new Server() { ServerId = 1, Name = "Server 1", City = "Toronto" },
            new Server() { ServerId = 2, Name = "Server 2", City = "Toronto" },
            new Server() { ServerId = 3, Name = "Server 3", City = "Toronto" },
            new Server() { ServerId = 4, Name = "Server 4", City = "Toronto" },

            new Server() { ServerId = 5, Name = "Server 5", City = "Montreal" },
            new Server() { ServerId = 6, Name = "Server 6", City = "Montreal" },
            new Server() { ServerId = 7, Name = "Server 7", City = "Montreal" },

            new Server() { ServerId = 8, Name = "Server 8", City = "Ottawa" },
            new Server() { ServerId = 9, Name = "Server 9", City = "Ottawa" },

            new Server() { ServerId = 10, Name = "Server 10", City = "Calgary" },
            new Server() { ServerId = 11, Name = "Server 11", City = "Calgary" },

            new Server() { ServerId = 12, Name = "Server 12", City = "Halifax" },
            new Server() { ServerId = 13, Name = "Server 13", City = "Halifax" },
            new Server() { ServerId = 14, Name = "Server 14", City = "Halifax" },
            new Server() { ServerId = 15, Name = "Server 15", City = "Halifax" }

        };

        public static void AddServer(Server server)
        {

            var maxId = servers.Max(s => s.ServerId);
            server.ServerId = maxId + 1;

            servers.Add(server);

        }

        public static List<Server> GetServers()
        {
            return servers;
        }

        public static List<Server> GetServersByCity(string city)
        {

            if (string.IsNullOrWhiteSpace(city))
            {
                return servers.ToList();
            }

            return servers.Where(s => s.City == city).ToList();

        }

        public static Server? GetServerById(int serverId)
        {

            return servers.FirstOrDefault(s => s.ServerId == serverId);

        }

        public static void UpdateServer(Server server)
        {

            var existingServer = servers.FirstOrDefault(s => s.ServerId == server.ServerId);

            if (existingServer != null)
            {
                existingServer.Name = server.Name;
                existingServer.City = server.City;
                existingServer.IsOnline = server.IsOnline;
            }

        }

        public static void DeleteServer(int serverId)
        {

            var serverToDelete = servers.FirstOrDefault(s => s.ServerId == serverId);

            if (serverToDelete != null)
            {
                servers.Remove(serverToDelete);
            }

        }

        public static List<Server> SearchServers(string searchTerm)
        {

            return servers.Where(s => s.Name != null && s.Name.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)).ToList();

        }

    }

}