using EntidadesDAO;
using System.Data.Entity;
using System.Net;
using System.Threading.Tasks;
using System.Web.Mvc;

namespace Mvc_EF.Controllers
{
    public class EmpregadoController : Controller
    {
        private CadastroModelo db = new CadastroModelo();

        // GET: Empregado
        public async Task<ActionResult> Index()
        {
            var empregados = db.Empregados.Include(e => e.Departamento);
            return View(await empregados.ToListAsync());
        }

        // GET: Empregado/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empregado empregado = await db.Empregados.FindAsync(id);
            if (empregado == null)
            {
                return HttpNotFound();
            }
            return View(empregado);
        }

        // GET: Empregado/Create
        public ActionResult Create()
        {
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "DepartamentoId", "Nome");
            return View();
        }

        // POST: Empregado/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "EmpregadoId,DepartamentoId,Nome,SobreNome,Email")] Empregado empregado)
        {
            if (ModelState.IsValid)
            {
                db.Empregados.Add(empregado);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "DepartamentoId", "Nome", empregado.DepartamentoId);
            return View(empregado);
        }

        // GET: Empregado/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empregado empregado = await db.Empregados.FindAsync(id);
            if (empregado == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "DepartamentoId", "Nome", empregado.DepartamentoId);
            return View(empregado);
        }

        // POST: Empregado/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "EmpregadoId,DepartamentoId,Nome,SobreNome,Email")] Empregado empregado)
        {
            if (ModelState.IsValid)
            {
                db.Entry(empregado).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.DepartamentoId = new SelectList(db.Departamentos, "DepartamentoId", "Nome", empregado.DepartamentoId);
            return View(empregado);
        }

        // GET: Empregado/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Empregado empregado = await db.Empregados.FindAsync(id);
            if (empregado == null)
            {
                return HttpNotFound();
            }
            return View(empregado);
        }

        // POST: Empregado/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            Empregado empregado = await db.Empregados.FindAsync(id);
            db.Empregados.Remove(empregado);
            await db.SaveChangesAsync();
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
