using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHpets.Models;

namespace LHpets.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        Cliente cliente1 = new Cliente(01,"Arthur A. ferreira", "857.032.950-41", "arthur.antunes@sp.senai.br", "madruga");
        Cliente cliente2 = new Cliente(02,"Rebeca vitoria do n. silva", "039.618.250-09", "rebecnascimento@gmail.com", "flor");
        Cliente cliente3 = new Cliente(03,"grace hopper", "911.702.988-00", "grace.hopper@gmail.com", "thor");
        Cliente cliente4 = new Cliente(04,"Ada lovelace", "800.700.654-02", "love.lace@gmail.com", "pinguin");
        Cliente cliente5 = new Cliente(05,"linus jorge ", "933.450.879-01", "linuss.ss@gmail.com", "cenourinha");

      List<Cliente> listaclientes = new List<Cliente>();
      listaclientes.Add(cliente1);
      listaclientes.Add(cliente2);
      listaclientes.Add(cliente3);
      listaclientes.Add(cliente4);
      listaclientes.Add(cliente5);

      ViewBag.listaclientes = listaclientes;




        Fornecedor fornecedor1 = new Fornecedor(01, "C# pet s/a", "14.182.102/001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "ctrl Alt dog", "15.452.442/001-50", "ctrl@alt.dog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "Bootspet INC", "24.592.592/001-87", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "tiktok dogs", "87.489.362/001-97", "noisnamidia@tiktokdogs.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "bifinho forever", "18.179.552/001-14", "contato@bgg.us");
 
     List<Fornecedor> listafornecedores = new List<Fornecedor>();
     listafornecedores.Add(fornecedor1);
     listafornecedores.Add(fornecedor2);
     listafornecedores.Add(fornecedor3);
     listafornecedores.Add(fornecedor4);
     listafornecedores.Add(fornecedor5);
     
     ViewBag.listafornecedores = listafornecedores;





     return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
