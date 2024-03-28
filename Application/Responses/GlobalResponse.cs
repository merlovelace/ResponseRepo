namespace Application.Responses;

public class GlobalResponse<T>
{
    public string Status { get; set; }
    public string Message { get; set; }
    public T Data { get; set; }

    public GlobalResponse(string status, string message, T data)
    {
        Status = status;
        Message = message;
        Data = data;
    }
}

//
// [HttpGet]
// public IActionResult GetUser(int id)
// {
//     var user = _userService.GetUserById(id); // Assuming _userService is your service layer method to fetch user
//     if (user == null)
//     {
//         return NotFound(new ApiResponse("error", "User not found", null));
//     }
//     return Ok(new ApiResponse("success", "Data retrieved successfully", user));
// }