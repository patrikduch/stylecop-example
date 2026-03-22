namespace StyleCopExample.Application.Common;

public class ApiResponse<T>
{
    public bool Success { get; set; }

    required public T Data { get; set; }

    public string? Message { get; set; } = string.Empty;

    public int StatusCode { get; set; }

    public static ApiResponse<T> Ok(T data, string? message = null) =>
        new ApiResponse<T>
        {
            Success = true,
            Data = data,
            Message = message,
            StatusCode = 200,
        };

    public static ApiResponse<T> Fail(string message, int statusCode = 500) =>
        new ApiResponse<T>
        {
            Success = false,
            Data = default!,
            Message = message,
            StatusCode = statusCode,
        };
}
