using Microsoft.JSInterop;
using System.Text;
using System.Text.Json;

namespace RogueDexWeb.Models
{
    public class LocalStorageHelper : ILocalStorageHelper
    {
        private readonly IJSRuntime _javaScript;

        public LocalStorageHelper(IJSRuntime javaScript)
        {
            _javaScript = javaScript;
        }

        public async Task SetItem<T>(string key, T value)
        {
            var serialized = JsonSerializer.Serialize(value);
            var base64 = Convert.ToBase64String(Encoding.UTF8.GetBytes(serialized));
            await _javaScript.InvokeAsync<string>("LocalStorageActions.setItem", key, base64);
        }

        public async Task<T> GetItem<T>(string key)
        {
            var base64 = await _javaScript.InvokeAsync<string>("LocalStorageActions.getItem", key);
            if (string.IsNullOrEmpty(base64))
            {
                return default;
            }

            var value = Encoding.UTF8.GetString(Convert.FromBase64String(base64));
            var deserialized = JsonSerializer.Deserialize<T>(value);
            return deserialized;
        }

        public async Task RemoveItem(string key)
        {
            await _javaScript.InvokeAsync<string>("LocalStorageActions.removeItem", key);
        }

        public async Task ClearData()
        {
            await _javaScript.InvokeAsync<string>("LocalStorageActions.clearData");
        }
    }

    public interface ILocalStorageHelper
    {
        Task SetItem<T>(string key, T value);
        Task<T> GetItem<T>(string key);
        Task RemoveItem(string key);
        Task ClearData();
    }
}
