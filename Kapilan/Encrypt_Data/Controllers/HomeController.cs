using Encrypt_Data.RegisterModel;
using Encrypt_Data.RollModal;
using Encrypt_Data.TableReg;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Data;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Encrypt_Data.Controllers
{
    [Route("api/controller")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly DB _db;
        public IConfiguration _configuration;
        public HomeController(DB userService, IConfiguration config)
        {
            _db = userService;
            _configuration = config;
        }

        //Register Process

        [HttpPost]
        [Route("register")]
        public string AddEmployees(TableRegister Reg)
        {
            Register EL = new Register();
            if (EL != null)
            {
                EL.First_Name = Reg.First_Name;
                EL.Last_Name = Reg.Last_Name;
                EL.Email = Reg.Email;
                EL.User_Name = Reg.User_Name;
                EL.Password = Encrypt_Password.encrypt(Reg.Password);
                EL.Phone_Number = Reg.Phone_Number;
                _db.user_login.Add(EL);
                _db.SaveChanges();
            }
            return EL.User_Name;
        }
        [HttpPost]
        [Route("login")]
        public async Task<IActionResult> login(UserLogin _userData)
        {
            if (_userData != null)
            {
                var claims = new[] {
                   new Claim(JwtRegisteredClaimNames.Sub, _configuration["Jwt:Subject"]),
                     new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                     new Claim(JwtRegisteredClaimNames.Iat, DateTime.UtcNow.ToString()),
                     new Claim("User_Name", _userData.User_Name),
                     new Claim("DisplayName", _userData.Password),
                 };

                var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]));
                var signIn = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                var token = new JwtSecurityToken(
                                        _configuration["Jwt:Issuer"],
                                        _configuration["Jwt:Audience"],
                                        claims,
                    expires: DateTime.Now.AddMinutes(4),
                    signingCredentials: signIn);

                return Ok(new JwtSecurityTokenHandler().WriteToken(token));
            }
            else
            {
                return BadRequest("Invalid credentials");
            }
        }
        private ActionResult<UserLogin> GetUser(string User_Name, string Password)
        {
            var data = _db.user_login.Where(u => u.User_Name == User_Name && u.Password == Password).FirstOrDefault();
            return null;
        }
    }
}




