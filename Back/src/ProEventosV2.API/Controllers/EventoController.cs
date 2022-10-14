using Microsoft.AspNetCore.Mvc;
using ProEventosV2.API.Data;
using ProEventosV2.API.Models;

namespace ProEventosV2.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{ 
    private readonly DataContext context;

    public EventoController(DataContext context)
    {
        this.context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
        return context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
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
