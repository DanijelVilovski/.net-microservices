using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Uris.Context;
using Uris.DTO;
using Uris.Models;
using Uris.Repositories.KursRepository;
using Uris.Repositories.ParcelaRepository;
using Uris.Repositories.UplataRepository;

namespace Uris.Controllers
{
    [Route("api/Uplata")]
    [ApiController]
    public class UplataController : ControllerBase
    {
        private readonly IUplataRepository uplataRepository;
        private readonly IMapper mapper;
        private readonly IKursRepository kursRepository;

        public UplataController(IUplataRepository uplataRepository, IKursRepository kursRepository, IMapper mapper)
        {
            this.uplataRepository = uplataRepository;
            this.mapper = mapper;
            this.kursRepository = kursRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<UplataDTO>> GetAll()
        {
            return Ok(mapper.Map<List<UplataDTO>>(uplataRepository.GetAll().ToList()));
        }

        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<UplataDTO> GetById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var uplata = uplataRepository.GetById(id);

            if (uplata == null)
            {
                return NotFound();
            }

            return Ok(mapper.Map<UplataDTO>(uplata));
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<UplataDTO> Post([FromBody] UplataDTO uplataDTO)
        {
            if (uplataDTO == null)
            {
                return BadRequest(uplataDTO);
            }
            if (uplataDTO.Id > 0)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }

            var kurs = kursRepository.GetById(uplataDTO.KursID);

            if(kurs == null)
            {
                return BadRequest("Ne postoji kurs sa prosleđenim ID-jem");
            }

            return Ok(uplataRepository.Add(mapper.Map<Uplata>(uplataDTO)));
        }

        [HttpPut("{id:int}")]
        public ActionResult<UplataDTO> Update(int id, [FromBody] UplataDTO uplataDTO)
        {
            if (uplataDTO == null || id != uplataDTO.Id)
            {
                return BadRequest();
            }

            var kurs = kursRepository.GetById(uplataDTO.KursID);

            if (kurs == null)
            {
                return BadRequest("Ne postoji kurs sa prosleđenim ID-jem");
            }

            var uplata = mapper.Map<Uplata>(uplataDTO);
            uplataRepository.Update(uplata, uplata.Id);

            return NoContent();
        }

        [HttpDelete("{id:int}")]
        public IActionResult Delete(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            var uplata = uplataRepository.GetById(id);

            if (uplata == null)
            {
                return NotFound();
            }

            uplataRepository.Delete(id);
            return NoContent();
        }
    }
}
