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
using Microsoft.EntityFrameworkCore;


namespace TreinoMVC.Controllers
{
    public class ContatosController : Controller
    {

         private readonly ApplicationDbContext database;

        public ContatosController(ApplicationDbContext database){
            this.database = database;
        }

        public IActionResult Index()
        {

        var contatos = database.Contatos.Where(s => s.Usuario.Contains(User.Identity.Name)).Include(c => c.Categoria).ToList();
        
        return View(contatos);

        }

        public IActionResult Contatos (){
         return View();
        }  

        public IActionResult Categoria (){
            var categorias = database.Categorias.ToList();
            return View (categorias);
        }


        public IActionResult NovaCategoria (){
          return View();
        }  
          public IActionResult EditarCategoria (int id){
            var categoria = database.Categorias.First(cat => cat.Id == id);
            CategoriaDTO categoriaView = new CategoriaDTO();
            categoriaView.Id = categoria.Id;
            categoriaView.Nome = categoria.Nome;
            return View (categoriaView);
        }
        public IActionResult Cadastrar(){

         ViewBag.Categorias = database.Categorias.ToList();
         return View();}

         public IActionResult EditarContato(int id){
            ViewBag.Categorias = database.Categorias.ToList();
           var contato = database.Contatos.Include(c => c.Categoria).First(con => con.Id == id);
            ContatoDTO contatoView = new ContatoDTO();
            contatoView.Id = contato.Id;
            contatoView.Nome = contato.Nome;
            contatoView.CategoriaID = contato.Categoria.Id;
            contatoView.Email = contato.Email;
            contatoView.Telefone = contato.Telefone;
            return View (contatoView);}

            public IActionResult AtualizarContatos(ContatoDTO contatoTemporario){
            if(ModelState.IsValid){
                var contatos = database.Contatos.First(con => con.Id  == contatoTemporario.Id);
                contatos.Nome = contatoTemporario.Nome;
                contatos.Categoria = database.Categorias.First(categoria => categoria.Id == contatoTemporario.CategoriaID);
                contatos.Email = contatoTemporario.Email;
                contatos.Telefone = contatoTemporario.Telefone;
                database.SaveChanges();
                return RedirectToAction ("Index");

            }
            
            else { 
                ViewBag.Categorias = database.Categorias.ToList();
                return View ("../Contatos/Categoria");}

        }

        public IActionResult Deletar (int id){
         ViewBag.Categorias = database.Categorias.ToList();
           var contato = database.Contatos.First(con => con.Id == id);
            ContatoDTO contatoView = new ContatoDTO();
            contatoView.Id = contato.Id;
            contatoView.Nome = contato.Nome;
            //contatoView.CategoriaID = database.Categorias.First(categoria => categoria.Id);
            contatoView.Email = contato.Email;
            contatoView.Telefone = contato.Telefone;
            database.Contatos.Remove(contato);
            database.SaveChanges();
            return RedirectToAction("Index");}

                
         [HttpPost]    
         public IActionResult Salvar (ContatoDTO contatoTemporario){
             if(ModelState.IsValid){
                Contato contato = new Contato();
                contato.Nome = contatoTemporario.Nome;
                contato.Categoria = database.Categorias.First(categoria => categoria.Id == contatoTemporario.CategoriaID );
                contato.Email = contatoTemporario.Email;
                contato.Telefone = contatoTemporario.Telefone;
                contato.Usuario = User.Identity.Name;
                database.Contatos.Add(contato);
                database.SaveChanges();
                 return RedirectToAction ("Index");
            }else { 
                ViewBag.Categorias = database.Categorias.ToList();
                return View ("../Contatos/Cadastrar");}
        }

    }
}