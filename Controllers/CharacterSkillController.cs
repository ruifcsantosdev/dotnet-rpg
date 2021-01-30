using System.Threading.Tasks;
using dotnet_rpg.Dtos.CharacterSkill;
using dotnet_rpg.Services.CharacterSkillService;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace dotnet_rpg.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class CharacterSkillController : ControllerBase
    {
        private readonly ICharacterSkillService characterSkillService;
        public CharacterSkillController(ICharacterSkillService characterSkillService)
        {
            this.characterSkillService = characterSkillService;
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill)
        {
            return Ok(await this.characterSkillService.AddCharacterSkill(newCharacterSkill));
        }
    }
}