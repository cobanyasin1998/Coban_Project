using System.Text.Json.Serialization;

namespace Coban.SharedLibrary.DTO
{
    public class ResponseDTO<T> where T : class
    {
        public T Data { get; private set; }
        public int Status { get; set; }
        [JsonIgnore]
        public bool IsSuccessful { get; set; }
        public ErrorDTO Error { get; set; }
        public static ResponseDTO<T> Success(T data, int statusCode)
        {
            return new ResponseDTO<T>
            {
                Data = data,
                Status = statusCode,
                IsSuccessful = true
            };
        }
        public static ResponseDTO<T> Success(int statusCode)
        {
            return new ResponseDTO<T>
            {
                Data = default,
                Status = statusCode,
                IsSuccessful = true
            };
        }
        public static ResponseDTO<T> Fail(ErrorDTO errorDto, int statusCode)
        {
            return new ResponseDTO<T>
            {

                Status = statusCode,
                Error = errorDto,
                IsSuccessful = false
            };
        }
        public static ResponseDTO<T> Fail(string errorMessage, int statusCode, bool isShow)
        {
            var errorDto = new ErrorDTO(errorMessage, isShow);

            return new ResponseDTO<T>
            {

                Status = statusCode,
                Error = errorDto,
                IsSuccessful = false
            };
        }


    }
}
