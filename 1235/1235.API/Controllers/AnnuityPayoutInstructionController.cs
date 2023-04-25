using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1235.DataAccess;
using _1235.DTO;
using _1235.Service;
using Microsoft.AspNetCore.Mvc;

namespace _1235.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnnuityPayoutInstructionController : ControllerBase
    {
        private readonly AnnuityPayoutInstructionService _annuityPayoutInstructionService;

        public AnnuityPayoutInstructionController()
        {
            _annuityPayoutInstructionService = new AnnuityPayoutInstructionService();
        }

        [HttpPost]
        public IActionResult Create([FromBody] AnnuityPayoutInstruction annuityPayoutInstruction)
        {
            try
            {
                _annuityPayoutInstructionService.Create(annuityPayoutInstruction);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] AnnuityPayoutInstruction annuityPayoutInstruction)
        {
            try
            {
                _annuityPayoutInstructionService.Update(annuityPayoutInstruction);
                return Ok();
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete(int id)
        {
            _annuityPayoutInstructionService.Delete(id);
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById(int id)
        {
            var annuityPayoutInstruction = _annuityPayoutInstructionService.GetById(id);
            return Ok(annuityPayoutInstruction);
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var annuityPayoutInstructions = _annuityPayoutInstructionService.GetAll();
            return Ok(annuityPayoutInstructions);
        }
    }
}