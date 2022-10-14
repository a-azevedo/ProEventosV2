using Microsoft.AspNetCore.Mvc;
using ProEventosV2.API.Models;

namespace ProEventosV2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _evento = new Evento[] {
        new Evento() {
                EventoId = 1,
                Local = "Rio de Janeiro",
                DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                Tema = "Angular e .Net",
                QtdePessoas = 70,
                Lote = "1° Lote",
                ImagemUrl = "foto.png"
            },
            new Evento() {
                EventoId = 2,
                Local = "Paraná",
                DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                Tema = "DevOps e Cloud",
                QtdePessoas = 135,
                Lote = "1° Lote",
                ImagemUrl = "foto.png"
            }
    };

    public EventoController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoId == id);
    }

    [HttpPost]
    public string Post()
    {
        return "http post method exemple";
    }

    [HttpPut("{id}")]
    public string Put(int id)
    {
        return $"http put method exemple com id = {id}";
    }

    [HttpDelete("{id}")]
    public string Delete(int id)
    {
        return $"http delete method exemple com id = {id}";
    }
}
