using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using Chamados.Models;


public class ChamadosController : Controller
{


    private static List<Chamado> _chamados = new List<Chamado>();

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Novo()
    {
        return View();
    }


    [HttpPost]
    public IActionResult Criar(Chamado chamado)
    {

        if (ModelState.IsValid)
        {
            chamado.Id = _chamados.Count + 1;
            chamado.Inicio = DateTime.Now;
            chamado.Status = "Aberto";

            _chamados.Add(chamado);

            return RedirectToAction("Detalhes", new { id = chamado.Id } );

        }

        return View("Novo", chamado);

    }


    public IActionResult Detalhes(int id)
    {
        var chamado = _chamados.FirstOrDefault(c => c.Id == id );

        if (chamado == null)
        {
            return NotFound();
        }

        return View(chamado);

    }


    public IActionResult Encerrar(int id)
    {
        var chamado = _chamados.FirstOrDefault( c => c.Id == id );

        if(chamado == null)
        {
            return NotFound();
        }

        chamado.Status = "Encerrado";

        chamado.Termino = DateTime.Now;

        return RedirectToAction("Detalhes", new { id = chamado.Id });

    }




}
