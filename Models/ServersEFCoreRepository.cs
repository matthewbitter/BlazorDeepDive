using BlazorDeepDive.Data;
using Microsoft.EntityFrameworkCore;

namespace BlazorDeepDive.Models
{
    public class ServersEFCoreRepository : IServersEFCoreRepository
    {

        public ServerManagementContext Context { get; }

        public ServersEFCoreRepository(IDbContextFactory<ServerManagementContext> dbContextFactory)
        {
            Context = dbContextFactory.CreateDbContext();
        }

        public void AddServer(Server server)
        {
            Context.Servers.Add(server);
            Context.SaveChanges();
        }

        public List<Server> GetServers()
        {
            return Context.Servers.ToList();
        }

        public List<Server> GetServersByCity(string city)
        {
            if (string.IsNullOrWhiteSpace(city))
            {
                return Context.Servers.ToList();
            }
            return Context.Servers.Where(s => s.City == city).ToList();
        }

        public Server? GetServerById(int serverId)
        {
            return Context.Servers.FirstOrDefault(s => s.ServerId == serverId);
        }

        public void UpdateServer(Server server)
        {
            var existingServer = Context.Servers.FirstOrDefault(s => s.ServerId == server.ServerId);
            if (existingServer != null)
            {
                existingServer.Name = server.Name;
                existingServer.City = server.City;
                existingServer.IsOnline = server.IsOnline;
                Context.SaveChanges();
            }
        }

        public void DeleteServer(int serverId)
        {
            var serverToDelete = Context.Servers.FirstOrDefault(s => s.ServerId == serverId);
            if (serverToDelete != null)
            {
                Context.Servers.Remove(serverToDelete);
                Context.SaveChanges();
            }
        }

        public List<Server> SearchServers(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                return Context.Servers.ToList();
            }
            return Context.Servers.Where(s => s.Name.Contains(searchTerm) || s.City.Contains(searchTerm)).ToList();
        }

    }
}
