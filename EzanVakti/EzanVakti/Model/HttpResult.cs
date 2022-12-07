using Picasso.EzanVakti;

namespace Picasso.Model
{
    public class HttpResult<T>
    {
        public bool IsSuccess { get; set; }
        public string ErrorMessage { get; set; }
        public T Data { get; set; }
    }
}