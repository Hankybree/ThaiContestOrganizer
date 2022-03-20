namespace Api.Models.Dto
{
    public class ErrorDto
    {
        public int StatusCode { get; set; }
        public string Reason { get; set; }
        public string Message { get; set; }
    }
}
