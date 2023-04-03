namespace Provet.Domain.Commands.Responses
{
    public class GenericResponse
    {
        public int Status { get; set; }
        public string? Message { get; set; }
        public string? StackTrace { get; set; }
        public DateTime Date { get; set; }
    }
}
