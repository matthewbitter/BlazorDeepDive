using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace BlazorDeepDive.StateStore
{
    public class SessionStorage
    {

        private readonly ProtectedSessionStorage ProtectedSessionStorage;

        public SessionStorage(ProtectedSessionStorage protectedSessionStorage)
        {
            ProtectedSessionStorage = protectedSessionStorage;
        }

        public async Task<T?> GetItemAsync<T>(string key)
        {
            var result = await ProtectedSessionStorage.GetAsync<T>(key);
            return result.Success ? result.Value : default;
        }

        public async Task SetItemAsync<T>(string key, T value)
        {
            await ProtectedSessionStorage.SetAsync(key, value);
        }

    }
}
