using System.Text.Json.Serialization;

namespace Teknoroma.WebApi.Models
{
    public class LoginResponse
    {
        [JsonPropertyName("isSucces")]
        public bool IsSuccess { get; set; }
        [JsonPropertyName("message")]
        public string Message { get; set; }
        [JsonPropertyName("userId")]
        public int? UserId { get; set; }
        [JsonPropertyName("userName")]
        public string UserName { get; set; }
    }
}
