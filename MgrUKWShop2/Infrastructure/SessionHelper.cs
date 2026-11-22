using Microsoft.EntityFrameworkCore.Storage.Json;
using System.Text.Json;

namespace MgrUKWShop2.Infrastructure
{
    public static class SessionHelper
    {
        public static void SerilizeToJson(this ISession session, string key, object value)
        {
            session.SetString(key, JsonSerializer.Serialize(value));
        }

        public static T DeserializeFromJson<T>(this ISession session, string key)
        {
            var value = session.GetString(key);

            return value == null ? default(T) : JsonSerializer.Deserialize<T>(key);
        }

    }
}
