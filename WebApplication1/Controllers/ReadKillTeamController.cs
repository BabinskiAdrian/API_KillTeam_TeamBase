using Microsoft.AspNetCore.Mvc;

namespace API_DataBase_KillTeamWarhammer40k.Controllers
{
    [ApiController]
    [Route("KillTeam")]
    public class ReadKillTeamController : ControllerBase
    {

        [HttpGet]
        public int Get()
        {

            return 1 ;
        }
    }
}