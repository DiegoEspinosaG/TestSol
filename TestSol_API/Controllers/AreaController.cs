using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using TestSol_API.Models.DTO;
using TestSol_API.Models;
using TestSol_API.ModelsTestSol;
using TestSol_API.Repositorio.IRepositorio;

namespace TestSol_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AreaController : ControllerBase
    {
        private readonly IAreaRepositorio _areaRepo;
        private readonly IMapper _mapper;
        protected APIResponse _response;

        public AreaController(IAreaRepositorio areaRepo, IMapper mapper)
        {
            _areaRepo = areaRepo;
            _mapper = mapper;
            _response = new APIResponse();
        }

        [HttpGet]
        public async Task<ActionResult<APIResponse>> GetAllAreas()
        {
            try
            {
                IEnumerable<Area> areasList = await _areaRepo.GetAll();
                _response.StatusCode = HttpStatusCode.OK;
                _response.Resultado = _mapper.Map<IEnumerable<AreaDto>>(areasList);

                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsExitoso = false;
                _response.ErrorMessages = new List<string>() { ex.ToString() };
            }
            return _response;
        }
    }
}
