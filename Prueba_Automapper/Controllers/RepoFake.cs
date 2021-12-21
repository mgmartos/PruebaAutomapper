using Microsoft.AspNetCore.Mvc;
using Prueba_Automapper.DTO;
using Prueba_Automapper.Interfaces;
using Prueba_Automapper.Models;
using Prueba_Automapper.Repository;
using System.Collections.Generic;
using System.Threading.Tasks;


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Prueba_Automapper.Utils;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace Prueba_Automapper.Controllers
{
    public class RepoFake : IMlib_WithDTO
    {


        private readonly biblosContext _context;
        private readonly IMapper _mapper;
        //        private readonly ILogger _logger;
        private Loggin _logger;

        public RepoFake(biblosContext context, IMapper mapper, ILogin login)
        {
            _context = context;
            _mapper = mapper;
            _logger = (Loggin)login;
            //            var builder = new ConfigurationBuilder()
            //.SetBasePath(Directory.GetCurrentDirectory())
            //.AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            //            IConfiguration configuration = builder.Build();

            //            string llave1 = configuration["AllowedHosts_2"];
            //            string llave2 = configuration["AllowedHosts"];
            //            string llave3 = configuration.GetConnectionString("defaultConnection");
            //            var contextOptions = new DbContextOptionsBuilder<biblosContext>()
            //    .UseSqlServer(llave3)
            //    .Options;

            //             _context = new biblosContext(contextOptions);



            //            //_context = context;
            //           // _mapper = mapper;
            //            //_logger = loggerfactory.CreateLogger(typeof(Mlib_WithDTO));
            //           //_logger = (Loggin)login;
        }


        public async Task<List<string>> DameEditoriales()
        {
            var lista = await this._context.Mlibs.Select(e => e.Editorial.Trim().ToUpper()).Distinct().ToListAsync();

            return lista;

            ///return await new biblosController(new Repository.Mlib_WithDTO());
        }

        Task<Mlib> IMlib_WithDTO.CrearMlib(LibroDTO dto)
        {
            throw new System.NotImplementedException();
        }

        Task<List<string>> IMlib_WithDTO.GetEditoriales()
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<Mlib>> IMlib_WithDTO.GetLibrosEditorial(string editorial)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<Mlib>> IMlib_WithDTO.GetLibrosEditorialTema(string editorial, string tema)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<Mlib>> IMlib_WithDTO.GetLibrosTema(string Tema)
        {
            throw new System.NotImplementedException();
        }

        Task<ActionResult<Mlib>> IMlib_WithDTO.GetMlib(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<IEnumerable<Mlib>> IMlib_WithDTO.GetMlibs()
        {
            throw new System.NotImplementedException();
        }

        Task<List<string>> IMlib_WithDTO.GetTemas()
        {
            throw new System.NotImplementedException();
        }

        Task<List<LibrosBaseDTO>> IMlib_WithDTO.Recovery_Libros_Base()
        {
            throw new System.NotImplementedException();
        }

        Task<List<LibrosOpinionDTO>> IMlib_WithDTO.Recovery_Libros_Opinion()
        {
            throw new System.NotImplementedException();
        }

        Task<LibrosBaseDTO> IMlib_WithDTO.Recovery_Libro_Base(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<LibrosOpinionDTO> IMlib_WithDTO.Recovery_Libro_Opinion(int id)
        {
            throw new System.NotImplementedException();
        }

        Task<int> IMlib_WithDTO.UpdateMlib(int id, LibroDTO dto)
        {
            throw new System.NotImplementedException();
        }
    }
     
}
