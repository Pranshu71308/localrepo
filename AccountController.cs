using Microsoft.AspNetCore.Mvc;
using Npgsql;
using Microsoft.AspNetCore.Http; // Include this namespace for HttpContext
using Amnex_Project_Resource_Mapping_System.Models;
using Newtonsoft.Json;
namespace Amnex_Project_Resource_Mapping_System.Controllers
{
    namespace Amnex_Project_Resource_Mapping_System.Controllers
    {
        public class AccountController : Controller
        {

            private readonly NpgsqlConnection _connection;
            //private readonly IConfiguration _configuration;
            public AccountController(NpgsqlConnection connection)
            {
                _connection = connection;
                connection.Open();
            }
            public IActionResult Login()
            {
                return View();
            }
            [HttpPost]
            public async Task<IActionResult> Login(Login data, string recaptchaResponse)
            {
                // Validate reCAPTCHA
                bool isRecaptchaValid = await ValidateRecaptcha(recaptchaResponse);
                if (!isRecaptchaValid)
                {
                    ModelState.AddModelError(string.Empty, "reCAPTCHA validation failed.");
                    return Json(new { success = false, message = "reCAPTCHA validation failed." });
                }

                // Validate user credentials
                bool isCredentialsValid = ValidateUserCredentials(data);
                if (isCredentialsValid)
                {
                    return Json(new { success = true });
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Invalid username or password.");
                    return Json(new { success = false, message = "Invalid username or password." });
                }
            }

            private bool ValidateUserCredentials(Login data)
            {
                using (var cmd = new NpgsqlCommand($"SELECT * FROM validateusercredentials('{data.Username}', '{data.Password}');", _connection))
                {
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            HttpContext.Session.SetString("userId", reader.GetInt32(0).ToString());
                            string uname = HttpContext.Session.GetString("userId");
                            Console.WriteLine($"Username stored in session: {uname}");
                            HttpContext.Session.SetString("userName", reader.GetString(1));
                            Console.WriteLine();
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                }
            }

            private async Task<bool> ValidateRecaptcha(string recaptchaResponse)
            {
                try
                {
                    var secretKey = "6LcSucopAAAAAAWwzvWJsWeeP-jXqH_NDI0orpEg";
                    var client = new HttpClient();
                    var response = await client.GetAsync($"https://www.google.com/recaptcha/api/siteverify?secret={secretKey}&response={recaptchaResponse}");
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    var captchaResponse = JsonConvert.DeserializeObject<CaptchaResponse>(responseBody);

                    return captchaResponse!.Success;
                }
                catch (Exception ex)
                {
                    // Log or handle any exceptions that occur during the reCAPTCHA validation
                    // For simplicity, return false if an exception occurs
                    Console.WriteLine($"An error occurred during reCAPTCHA validation: {ex.Message}");
                    return false;
                }
            }

            public class CaptchaResponse
            {
                [JsonProperty("success")]
                public bool Success { get; set; }
            }
        }
    }
}
