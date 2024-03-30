using InmobiliariaCamargo.Models;
using Microsoft.AspNetCore.Mvc;
using Org.BouncyCastle.Crypto.Engines;

namespace InmobiliariaCamargo.Controllers
{
    public class PropietariosController : Controller
    {
        RepositorioPropietario repositorio;

            public PropietariosController()
            {
                repositorio = new RepositorioPropietario();
            }
      
        // GET: PropietariosController
        public ActionResult Index()
        {
            
            var lista = repositorio.ObtenerTodos();
            return View(lista);
        }

        // GET: PropietariosController/Details/5
        public ActionResult Details(int id)
        {
            
            try
            {
                var i = repositorio.ObtenerPorId(id);
                return View(i);
            }
            catch (Exception ex)
            {
                {
                    throw;
                }
            }
        }

        // GET: PropietariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PropietariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
       public ActionResult Create(int id, Propietario p)
        {
           
                repositorio.ObtenerPorId(id);
                int res = repositorio.Alta(p);
                if (res > 0)
                    return RedirectToAction(nameof(Index));
                else
                    return View();
                
           
        }

        // GET: PropietariosController/Edit/5
        public ActionResult Edit(int id)
        {
           try
            {
                var entidad = repositorio.ObtenerPorId(id);
                return View(entidad);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        // POST: PropietariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Propietario p)
        {
           try
            {
                repositorio.ObtenerPorId(id);
                repositorio.Modificacion(p);
                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                {
                    throw;
                }
            }
        }
        // GET: PropietariosController/Delete/5
        public ActionResult Delete(int id)
        {
            var entidad = repositorio.ObtenerPorId(id);
                return View(entidad);
        }

        // POST: PropietariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Propietario p)
        {
            try
            {
                
                int res = repositorio.Baja(id);
                if (res > 0)
                    return RedirectToAction(nameof(Index));
                else
                    return View();
            }
            catch
            {
                return View();
         
            }
        }
    }

   
}
