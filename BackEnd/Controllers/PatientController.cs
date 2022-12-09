using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Services.Interfaces;
using DTOs;

namespace BackEnd.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class ProjectTaskController : ControllerBase
    {
        private readonly IPatientService _patientService;

        public ProjectTaskController(IPatientService patienService, IMapper mapper)
        {
            _patientService = patienService;
        }

        [HttpGet]
        public async Task<IActionResult> GetListAsync()
        {
            var result = await _patientService.GetAllAsync<PatientDTO>();
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProjectAsync([FromRoute] int id)
        {
            await _patientService.DeleteByIdAsync(id);
            return Ok();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProjectAsync([FromBody] CreatePatientDTO model)
        {
            var result = await _patientService.CreateAsync(model);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProjectAsync([FromBody] UpdatePatientDTO model)
        {
            await _patientService.UpdateAsync(model);
            return Ok();
        }
    }
}
