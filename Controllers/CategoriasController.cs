using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TreinoMVC.Models;
using TreinoMVC.Data;
using TreinoMVC.DTO;

namespace TreinoMVC.Controllers
{
    public class CategoriasController : Controller
    {

        private readonly ApplicationDbContext database;

        public CategoriasController(ApplicationDbContext database){
            this.database = database;
        }

        [HttpPost]
        public IActionResult Salvar (CategoriaDTO categoriaTemporaria){
                if(ModelState.IsValid){
                Categoria categoria = new Categoria();
                categoria.Nome = categoriaTemporaria.Nome;
                database.Categorias.Add(categoria);
                database.SaveChanges();
                return RedirectToAction ("Categoria", "Contatos");
            } else { return View ("../Contatos");}}
        

        public IActionResult Atualizar(CategoriaDTO categoriaTemporaria){
            if(ModelState.IsValid){
                var categoria = database.Categorias.First(cat => cat.Id == categoriaTemporaria.Id);
                categoria.Nome = categoriaTemporaria.Nome;
                database.SaveChanges();
                return RedirectToAction ("Categoria", "Index");
            }else { return RedirectToAction ("Categoria", "Index");}}
                
        public IActionResult Deletar (int id){
            ViewBag.Categorias = database.Categorias.ToList();
            var categoria = database.Categorias.First(cat => cat.Id == id);                   
            try {
                database.Categorias.Remove(categoria);
                database.SaveChanges();
            }
            catch (Microsoft.EntityFrameworkCore.DbUpdateException e){
                throw new Exception("Categoria em uso, não pode ser deletada!", e);
            }
             catch (Exception e){
                throw e;
            }
            return RedirectToAction("Categoria", "Contatos");}

        }
    }

