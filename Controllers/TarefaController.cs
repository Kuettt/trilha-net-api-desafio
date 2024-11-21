using Microsoft.AspNetCore.Mvc;
using TrilhaApiDesafio.Context;
using TrilhaApiDesafio.Models;

namespace TrilhaApiDesafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TarefaController : ControllerBase
    {
        private readonly OrganizadorContext _context;

        public TarefaController(OrganizadorContext context)
        {
            _context = context;
        }

        [HttpGet("{id}")]
<<<<<<< HEAD
        public IActionResult ObterPorId(int id) //Concluído
        {
            // TODO: Buscar o Id no banco utilizando o EF
            var idUsuario = _context.Tarefas.Find(id);
            // TODO: Validar o tipo de retorno. Se não encontrar a tarefa, retornar NotFound,
            if (idUsuario == null)
            {
                return NotFound();
            }
            // caso contrário retornar OK com a tarefa encontrada
            return Ok(idUsuario);
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos() // Concluído
        {
            var Usuarios = _context.Tarefas.ToList();
            return Ok(Usuarios);
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo) //Concluído
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o titulo recebido por parâmetro
            var buscartitulo = _context.Tarefas.Where(x => x.Titulo.Contains(titulo)); 
            // Dica: Usar como exemplo o endpoint ObterPorData
            return Ok(buscartitulo);
=======
        public IActionResult ObterPorId(int id)
        {
            // TODO: Buscar o Id no banco utilizando o EF
            // TODO: Validar o tipo de retorno. Se não encontrar a tarefa, retornar NotFound,
            // caso contrário retornar OK com a tarefa encontrada
            return Ok();
        }

        [HttpGet("ObterTodos")]
        public IActionResult ObterTodos()
        {
            // TODO: Buscar todas as tarefas no banco utilizando o EF
            return Ok();
        }

        [HttpGet("ObterPorTitulo")]
        public IActionResult ObterPorTitulo(string titulo)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o titulo recebido por parâmetro
            // Dica: Usar como exemplo o endpoint ObterPorData
            return Ok();
>>>>>>> 97498ee4da95d5d12bf367a90d5f1d1175215251
        }

        [HttpGet("ObterPorData")]
        public IActionResult ObterPorData(DateTime data)
        {
            var tarefa = _context.Tarefas.Where(x => x.Data.Date == data.Date);
            return Ok(tarefa);
        }

        [HttpGet("ObterPorStatus")]
        public IActionResult ObterPorStatus(EnumStatusTarefa status)
        {
            // TODO: Buscar  as tarefas no banco utilizando o EF, que contenha o status recebido por parâmetro
            // Dica: Usar como exemplo o endpoint ObterPorData
            var tarefa = _context.Tarefas.Where(x => x.Status == status);
            return Ok(tarefa);
        }

        [HttpPost]
<<<<<<< HEAD
        public IActionResult Criar(Tarefa tarefa) //Concluído
=======
        public IActionResult Criar(Tarefa tarefa)
>>>>>>> 97498ee4da95d5d12bf367a90d5f1d1175215251
        {
            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

<<<<<<< HEAD
            _context.Tarefas.Add(tarefa);
            _context.SaveChanges();
=======
>>>>>>> 97498ee4da95d5d12bf367a90d5f1d1175215251
            // TODO: Adicionar a tarefa recebida no EF e salvar as mudanças (save changes)
            return CreatedAtAction(nameof(ObterPorId), new { id = tarefa.Id }, tarefa);
        }

        [HttpPut("{id}")]
<<<<<<< HEAD
        public IActionResult Atualizar(int id, Tarefa tarefa) //Concluído
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            tarefaBanco.Titulo = tarefa.Titulo;
            tarefaBanco.Descricao = tarefa.Descricao;
            tarefaBanco.Data = tarefa.Data;
            tarefaBanco.Status = tarefa.Status;
            
=======
        public IActionResult Atualizar(int id, Tarefa tarefa)
        {
            var tarefaBanco = _context.Tarefas.Find(id);

>>>>>>> 97498ee4da95d5d12bf367a90d5f1d1175215251
            if (tarefaBanco == null)
                return NotFound();

            if (tarefa.Data == DateTime.MinValue)
                return BadRequest(new { Erro = "A data da tarefa não pode ser vazia" });

            // TODO: Atualizar as informações da variável tarefaBanco com a tarefa recebida via parâmetro
            // TODO: Atualizar a variável tarefaBanco no EF e salvar as mudanças (save changes)
<<<<<<< HEAD
            _context.Update(tarefaBanco);
            _context.SaveChanges();
            return Ok(tarefaBanco);
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id) //Concluído
=======
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult Deletar(int id)
>>>>>>> 97498ee4da95d5d12bf367a90d5f1d1175215251
        {
            var tarefaBanco = _context.Tarefas.Find(id);

            if (tarefaBanco == null)
                return NotFound();

            // TODO: Remover a tarefa encontrada através do EF e salvar as mudanças (save changes)
<<<<<<< HEAD
            _context.Tarefas.Remove(tarefaBanco);
            _context.SaveChanges();
=======
>>>>>>> 97498ee4da95d5d12bf367a90d5f1d1175215251
            return NoContent();
        }
    }
}
