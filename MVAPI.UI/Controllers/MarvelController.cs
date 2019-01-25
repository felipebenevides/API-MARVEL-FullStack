using Microsoft.AspNetCore.Mvc;
using MVAPI.Application;
using MVAPI.Application.Interfaces;
using MVAPI.Application.ViewModels;
using MVAPI.Models;
using System.Collections.Generic;
using System.Linq;

namespace MVAPI.UI.Controllers
{
    public class MarvelController : Controller
    {
        private readonly IAPPMarvelClient _Appservice;
        public MarvelController(IAPPMarvelClient service)
        {
            _Appservice = service;
        }

        #region Pagina Inicial      
        [HttpGet]
        public IActionResult Home()
        {

            return View();
        }
        #endregion

        #region Exibe Personagens da Marvel Aleatório

        [HttpGet]
        public IActionResult PersonagemAleatorio()
        {
            var PersonagemAleatorio = _Appservice.RetornaPersonagensMarvel();

            return View(PersonagemAleatorio);
        }

        #endregion

        #region Lista Personagens

        [HttpGet]
        public IActionResult ListaPersonagens()
        {
            var ListaPersonagens = _Appservice.ListaPersonagens();

            return View(ListaPersonagens);
        }
        #endregion


        #region Busca Personagens por ID

        [HttpGet]
        public IActionResult BuscaPersonagemID(int id)
        {
            var ListaPersonagens = _Appservice.BuscaPersonagemPorID(id);

            return View(ListaPersonagens);
        }
        #endregion

        #region Lista Quadrinhos

        [HttpGet]
        public IActionResult ListaQuadrinhos()
        {
            var ListaQuadrinhos = _Appservice.ListaQuadrinhos();

            return View(ListaQuadrinhos);
        }
        #endregion
    }
}