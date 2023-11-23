using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TestSol_API.Models;
using TestSol_API.Models.DTO;
using TestSol_API.ModelsTestSol;
using TestSol_API.Repositorio.IRepositorio;

namespace TestSol_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmpleadoController : ControllerBase
    {
        private readonly IEmpleadoRepositorio _empleadoRepo;
        private readonly IAreaRepositorio _areaRepo;
        private readonly IMapper _mapper;
        protected APIResponse _response;

        public EmpleadoController(IEmpleadoRepositorio empleadoRepo, IAreaRepositorio areaRepo,IMapper mapper)
        {
            _empleadoRepo = empleadoRepo;
            _areaRepo = areaRepo;
            _mapper = mapper;
            _response = new APIResponse();
        }

        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetAllEmpleados()
        {
            try
            {
                IEnumerable<Empleado> empleadosList = await _empleadoRepo.GetAll();
                _response.StatusCode = HttpStatusCode.OK;
                _response.Resultado = _mapper.Map<IEnumerable<EmpleadoDto>>(empleadosList);

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsExitoso = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpGet("id", Name = "GetEmpleadoById")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult<APIResponse>> GetEmpleadoById(string id)
        {
            try
            {
                if (id == "")
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsExitoso = false;
                    return BadRequest(_response);
                }

                var empleado = await _empleadoRepo.GetById(p => p.EmpleadoId == id);
                if (empleado == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    _response.IsExitoso = false;
                    return NotFound(_response);
                }

                _response.StatusCode = HttpStatusCode.OK;
                _response.Resultado = _mapper.Map<EmpleadoDto>(empleado);

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsExitoso = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<APIResponse>> PostEmpleado([FromBody] EmpleadoDto empleadoDto)
        {
            try
            {
                if (!ModelState.IsValid) return BadRequest(ModelState);

                if (await _empleadoRepo.GetById(p => p.EmpleadoId == empleadoDto.EmpleadoId) != null)
                {
                    ModelState.AddModelError("EmpleadoExiste", "Ya existe un registro con ese Id");
                    return BadRequest(ModelState);
                }

                if (await _areaRepo.GetById(p => p.AreaId == empleadoDto.AreaId) == null)
                {
                    ModelState.AddModelError("ClaveForanea", "El Id del Area no existe!");
                    return BadRequest(ModelState);
                }

                if (empleadoDto == null) return BadRequest(empleadoDto);

                Empleado newItem = _mapper.Map<Empleado>(empleadoDto);

                //newItem.FechaCreacion = DateTime.Now;

                await _empleadoRepo.Create(newItem);

                _response.StatusCode = HttpStatusCode.Created;
                _response.Resultado = newItem;

                return CreatedAtRoute("GetEmpleadoById", new { id = newItem.EmpleadoId }, _response);
            }
            catch (Exception ex)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsExitoso = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
                return BadRequest(_response);
            }
        }

        [HttpDelete("id:int")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> DeleteEmpleado(string id)
        {
            try
            {
                if (id == "")
                {
                    _response.StatusCode = HttpStatusCode.BadRequest;
                    _response.IsExitoso = false;
                    return BadRequest(_response);
                }

                var empleado = await _empleadoRepo.GetById(p => p.EmpleadoId == id);
                if (empleado == null)
                {
                    _response.StatusCode = HttpStatusCode.NotFound;
                    _response.IsExitoso = false;
                    return NotFound(_response);
                }

                await _empleadoRepo.Remove(empleado);
                _response.StatusCode = HttpStatusCode.NoContent;
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsExitoso = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
                return BadRequest(_response);
            }            
        }

        [HttpPut("id:int")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> PutEmpleado(string id, [FromBody] EmpleadoDto empleadoDto)
        {
            if (empleadoDto == null || id != empleadoDto.EmpleadoId)
            {
                _response.StatusCode = HttpStatusCode.BadRequest;
                _response.IsExitoso = false;
                return BadRequest(_response);
            }

            if (await _empleadoRepo.GetById(p => p.EmpleadoId == empleadoDto.EmpleadoId, tracked: false) == null)
            {
                ModelState.AddModelError("ClaveForanea", "El Id del Empleado no existe!");
                return BadRequest(ModelState);
            }

            Empleado modelo = _mapper.Map<Empleado>(empleadoDto);

            await _empleadoRepo.Update(modelo);

            _response.StatusCode = HttpStatusCode.NoContent;

            return Ok(_response);
        }
    }
}
