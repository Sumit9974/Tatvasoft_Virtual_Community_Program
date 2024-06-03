using Book_Project.Data;
using Book_Project.Data.Repositories.IRepository;
using Book_Project.Model;
using Microsoft.AspNetCore.Mvc;

namespace Book_Project.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UsersController(IUserRepository userRepository)
        {
            _userRepository = userRepository; 
        }

        //[===============================================================================================================================================================================]//


     

        [HttpGet]
        [Route("api/[controller]/get-all-user-from-database")]
        public ActionResult<List<User>> GetAllUsersFromDatabase()
        {
            return _userRepository.GetAllUsersFromDatabase();
        }



        //[===============================================================================================================================================================================]//


        [HttpPost]
        [Route("api/[controller]/add-user")]
        public IActionResult Post(User user)
        { 
            try
            {
               _userRepository.AddUser(user);
                
                return Ok(user);
            }
            catch (Exception ex)
            { 
                return BadRequest(ex.Message);
            }

        }

   
        //[===============================================================================================================================================================================]//

        [HttpGet]
        [Route("api/[controller]/get-user-group-by-role")]
        public ActionResult<List<IGrouping<string, User>>> GetUsersGroupedByRole()
        {
            return _userRepository.GetUsersGroupedByRole();
        }


    }
}
