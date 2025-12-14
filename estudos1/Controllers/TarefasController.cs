using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using estudos1.Models;

namespace estudos1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TarefasController : ControllerBase
{
    private static List<Tarefa> tarefas = new List<Tarefa>();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(tarefas);
    }

    [HttpPost]
    public IActionResult Post(Tarefa tarefa)
    {
        tarefa.Id = tarefas.Count + 1;
        tarefas.Add(tarefa);

        return Created("", tarefa);
    }



}
