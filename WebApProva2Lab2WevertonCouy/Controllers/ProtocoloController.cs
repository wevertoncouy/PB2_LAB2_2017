using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApProva2Lab2WevertonCouy.Models;

namespace WebApProva2Lab2WevertonCouy.Controllers
{
    public class ProtocoloController : Controller
    {
        private ProtocoloContext db = new ProtocoloContext();

        // GET: Protocolo
        public ActionResult Index()
        {
            var protocoloes = db.Protocoloes.Include(p => p.Aluno).Include(p => p.tramite);
            return View(protocoloes.ToList());
        }

        // GET: Protocolo/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Protocolo protocolo = db.Protocoloes.Find(id);
            if (protocolo == null)
            {
                return HttpNotFound();
            }
            return View(protocolo);
        }

        // GET: Protocolo/Create
        public ActionResult Create()
        {
            ViewBag.AlunoId = new SelectList(db.Alunoes, "AlunoId", "Nome");
            ViewBag.TramiteId = new SelectList(db.Tramites, "TramiteId", "Descricao");
            return View();
        }

        // POST: Protocolo/Create
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ProtocoloId,Numero,DataEntrada,DataSaida,AlunoId,TramiteId")] Protocolo protocolo)
        {
            if (ModelState.IsValid)
            {
                db.Protocoloes.Add(protocolo);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AlunoId = new SelectList(db.Alunoes, "AlunoId", "Nome", protocolo.AlunoId);
            ViewBag.TramiteId = new SelectList(db.Tramites, "TramiteId", "Descricao", protocolo.TramiteId);
            return View(protocolo);
        }

        // GET: Protocolo/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Protocolo protocolo = db.Protocoloes.Find(id);
            if (protocolo == null)
            {
                return HttpNotFound();
            }
            ViewBag.AlunoId = new SelectList(db.Alunoes, "AlunoId", "Nome", protocolo.AlunoId);
            ViewBag.TramiteId = new SelectList(db.Tramites, "TramiteId", "Descricao", protocolo.TramiteId);
            return View(protocolo);
        }

        // POST: Protocolo/Edit/5
        // Para se proteger de mais ataques, ative as propriedades específicas a que você quer se conectar. Para 
        // obter mais detalhes, consulte https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ProtocoloId,Numero,DataEntrada,DataSaida,AlunoId,TramiteId")] Protocolo protocolo)
        {
            if (ModelState.IsValid)
            {
                db.Entry(protocolo).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AlunoId = new SelectList(db.Alunoes, "AlunoId", "Nome", protocolo.AlunoId);
            ViewBag.TramiteId = new SelectList(db.Tramites, "TramiteId", "Descricao", protocolo.TramiteId);
            return View(protocolo);
        }

        // GET: Protocolo/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Protocolo protocolo = db.Protocoloes.Find(id);
            if (protocolo == null)
            {
                return HttpNotFound();
            }
            return View(protocolo);
        }

        // POST: Protocolo/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Protocolo protocolo = db.Protocoloes.Find(id);
            db.Protocoloes.Remove(protocolo);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
