using MandrilAPI.Models;
using MandrilAPI.Services;

using Microsoft.AspNetCore.Mvc;


namespace MandrilAPI.Controllers;

[ApiController]
[Route("api/[controller]")]

public class MandrilController : ControllerBase
{
    [HttpGet]
    public ActionResult<IEnumerable<Mandril>> GetMandriles()
    {
        return Ok(MandrilDataStore.Current.Mandriles);


    }
    [HttpGet("{mandrilId}")]

    public ActionResult<Mandril> GetMandril(int mandrilId)
    {
        var mandril = MandrilDataStore.Current.Mandriles.FirstOrDefault(x => x.Id == mandrilId);
        if (mandril == null)
        
            return NotFound("El Mandril no se encuentra");


        
        return Ok(mandril);
        
    }

    [HttpPost]


    public



    }

  