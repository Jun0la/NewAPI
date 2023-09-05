﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]                       
        {
            new Evento()

                {
                    EventoId = 1, 
                    Tema = "Angular", 
                    Local = "Pres. Prudente", 
                    Lote = "1°", Quantidade = 199, 
                    DataEvento = DateTime.Now.AddDays(2).ToString(),
                },

            new Evento()

                {
                    EventoId = 2, 
                    Tema = "Angular & .NET CORE", 
                    Local = "Pres. Prudente", 
                    Lote = "5°", Quantidade = 100, 
                    DataEvento = DateTime.Now.AddDays(20).ToString(),
                    ImageURL = "foto.png"
                }
        };

        public EventoController()
        {

        }

        

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {
          return _evento.Where(evento => evento.EventoId == id);
        }




        [HttpGet]
        public IEnumerable<Evento> Get()
        {
          return _evento;
        }

        [HttpPost]
        public string Post()
        {
           return "Exemplo de Post";
        }
        [HttpPut("{id}")]
        public string Put(int id)
        {
           return $"Exemplo de Put {id}";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Exemplo de Delete com id = {id}";
        }
    }
}
