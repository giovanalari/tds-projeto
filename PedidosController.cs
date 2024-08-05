using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

public class PedidosController : Controller
{
    private static List<Pedido> pedidos = new List<Pedido>(); // Simulação de um banco de dados

    public IActionResult Index()
    {
        return View(pedidos);
    }

    public IActionResult Detalhes(int id)
    {
        var pedido = pedidos.FirstOrDefault(p => p.Id == id);
        if (pedido == null)
        {
            return NotFound();
        }
        return View(pedido);
    }

    public IActionResult Editar(int id)
    {
        var pedido = pedidos.FirstOrDefault(p => p.Id == id);
        if (pedido == null)
        {
            return NotFound();
        }
        return View(pedido);
    }

    [HttpPost]
    public IActionResult Editar(Pedido pedido)
    {
        var pedidoExistente = pedidos.FirstOrDefault(p => p.Id == pedido.Id);
        if (pedidoExistente == null)
        {
            return NotFound();
        }
        pedidoExistente.Status = pedido.Status;
        pedidoExistente.Responsavel = pedido.Responsavel;
        // Atualizar outros campos conforme necessário
        return RedirectToAction("Index");
    }

    public IActionResult Novo()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Novo(Pedido pedido)
    {
        pedido.Id = pedidos.Count > 0 ? pedidos.Max(p => p.Id) + 1 : 1;
        pedidos.Add(pedido);
        return RedirectToAction("Index");
    }
}
