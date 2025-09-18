using System.Text.Json;

namespace MarketMini.Service
{
    public static class LoadDataJson
    {
        /// <summary>
        /// Load dữ liệu từ file JSON vào List<T>
        /// </summary>
        public static List<T> Load<T>(string filePath)
        {
            if (!File.Exists(filePath)) return new List<T>();

            var json = File.ReadAllText(filePath);
            if (string.IsNullOrWhiteSpace(json)) return new List<T>();

            return JsonSerializer.Deserialize<List<T>>(json) ?? new List<T>();
        }

        /// <summary>
        /// Ghi List<T> vào file JSON (overwrite)
        /// </summary>
        public static void Save<T>(string filePath, List<T> data)
        {
            var options = new JsonSerializerOptions { WriteIndented = true };
            string json = JsonSerializer.Serialize(data, options);
            File.WriteAllText(filePath, json);
        }
    }
}
