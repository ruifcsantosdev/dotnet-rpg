using System.Threading.Tasks;
using dotnet_rpg.Dtos.Fight;
using dotnet_rpg.Services.FightService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [Authorize]
    [ApiController]
    [Route("controller")]
    public class FightController : ControllerBase
    {
        private readonly IFightService fightService;
        public FightController(IFightService fightService)
        {
            this.fightService = fightService;
        }

        [HttpGet]
        public async Task<IActionResult> GetHighscore()
        {
            return Ok(await this.fightService.GetHighscore());
        }

        [HttpPost("Weapon")]
        public async Task<IActionResult> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await this.fightService.WeaponAttack(request));
        }

        [HttpPost("Skill")]
        public async Task<IActionResult> SkillAttack(SkillAttackDto request)
        {
            return Ok(await this.fightService.SkillAttack(request));
        }

        [HttpPost]
        public async Task<IActionResult> Fight(FightRequestDto request)
        {
            return Ok(await this.fightService.Fight(request));
        }
    }
}