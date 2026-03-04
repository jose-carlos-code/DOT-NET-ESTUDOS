using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using estudos1.Models;

namespace estudos1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TarefasController : ControllerBase
{
    private static List<Tarefa> tarefas = new List<Tarefa>();
    private static int proximoId = 1;

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(tarefas);
    }

    [HttpGet("{id}")]
    public IActionResult getById(int id)
    {
        var tarefa = tarefas.FirstOrDefault(t => t.Id == id);
        if(tarefa == null)
        {
            return NotFound("Tarefa não encontrada");

        }

        return Ok(tarefa);
    }

    [HttpPost]
    public IActionResult Post(Tarefa tarefa)
    {
        tarefa.Id = tarefas.Count + 1;
        tarefas.Add(tarefa);

        return Created("", tarefa);
    }



}
