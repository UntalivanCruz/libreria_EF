using System.Net;
using Microsoft.AspNetCore.Mvc;
using libreria.Models;
using libreria.Services;

namespace libreria.Controllers;

//ATRIBUTOS CONTROLLER
[ApiController]
[Route("api/[controller]")]
public class AutorController: ControllerBase
{

    IAutorService autorService;
    public AutorController(IAutorService serviceAutor){
        autorService=serviceAutor;
    }

    //CRUD API
    //ATRIBUTOS DE ENDPOINTS
    //CREATE
    [HttpPost]
    public IActionResult ingresarAutores([FromBody] Autor nuevoAutor){
        autorService.insertar(nuevoAutor);
        return Ok();
    }

    //READ
    [HttpGet]
    public IActionResult mostrarAutores(){
        return Ok(autorService.obtener());
    }

    //UPDATE
    [HttpPut("{id}")]
    public IActionResult actualizarAutores([FromBody] Autor autorActualizar, Guid id){
        autorService.actualizar(id,autorActualizar);
        return Ok();
    }

    //DELETE
    [HttpDelete("{id}")]
    public IActionResult eliminarAutores(Guid id){
        autorService.eliminar(id);
        return Ok();
    }
}