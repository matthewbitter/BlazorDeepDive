using BlazorDeepDive.Data;

namespace BlazorDeepDive.Models
{
    public interface IServersEFCoreRepository
    {
        ServerManagementContext Context { get; }

        void AddServer(Server server);
        void DeleteServer(int serverId);
        Server? GetServerById(int serverId);
        List<Server> GetServers();
        List<Server> GetServersByCity(string city);
        List<Server> SearchServers(string searchTerm);
        void UpdateServer(Server server);
    }
}