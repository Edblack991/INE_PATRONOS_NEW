using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApp.Models;
using Highsoft.Web.Mvc.Charts;
using WebApp.ViewModels;

namespace WebApp.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        #region Pagina Principal de las graficas
        public ActionResult Index()
        {
            List<PieSeriesData> pieData = new List<PieSeriesData>();

            pieData.Add(new PieSeriesData { Name = "ANDRES MANUEL Morena", Y = 40, });
            pieData.Add(new PieSeriesData { Name = "ANTONIO MEADE PRI", Y = 30 });
            pieData.Add(new PieSeriesData { Name = "RICARDO ANAYA PAN", Y = 25, });

            ViewData["Grafica_presidente"] = pieData;



            List<ColumnSeriesData> columnData = new List<ColumnSeriesData>()
            {
                new ColumnSeriesData { Name = "Partido Revolucionario Institucional", Y = 36},
                new ColumnSeriesData { Name = "Partido Accion Nacional", Y = 16 },
                new ColumnSeriesData { Name = "Movimiento Ciudadano", Y = 10.3 },
                new ColumnSeriesData { Name = "Nueva Alianza ", Y = 4.77},
                new ColumnSeriesData { Name = "Partido Revolución Democrática", Y = 18.0},
                new ColumnSeriesData { Name = "Partido del trabajo", Y = 20.0},
                new ColumnSeriesData { Name = "Partido Verde Ecologista", Y = 17.0},
                new ColumnSeriesData { Name = " Morena", Y = 50.0},


            };

            ViewData["Grafica_partido"] = columnData;



            List<PieSeriesData> pieHalfData = new List<PieSeriesData>();

            pieHalfData.Add(new PieSeriesData { Name = "IVONNE", Y = 45.0 });
            pieHalfData.Add(new PieSeriesData { Name = "FELIPE DE JESUS", Y = 26.8 });
            pieHalfData.Add(new PieSeriesData { Name = "HUMBERTO", Y = 12.8, });
            pieHalfData.Add(new PieSeriesData { Name = "JORGE ARISTOTELES", Y = 8.5 });
            pieHalfData.Add(new PieSeriesData { Name = "FERNANDO GUZMAN", Y = 15.4 });

            ViewData["Grafica_gobernador"] = pieHalfData;



            List<PieSeriesData> pieHalfData1 = new List<PieSeriesData>();

            pieHalfData1.Add(new PieSeriesData { Name = "CESAR", Y = 34.0 });
            pieHalfData1.Add(new PieSeriesData { Name = "ADRIAN MARIO", Y = 50.8 });
            pieHalfData1.Add(new PieSeriesData { Name = "ROSA MARIA", Y = 16.8, });
            pieHalfData1.Add(new PieSeriesData { Name = "MANUEL", Y = 16.5 });
            pieHalfData1.Add(new PieSeriesData { Name = "JESUS RODRIGO", Y = 16.5 });
            pieHalfData1.Add(new PieSeriesData { Name = "MANUEL BRAULIO", Y = 16.5 });
            pieHalfData1.Add(new PieSeriesData { Name = "VICTOR HUGO", Y = 16.5 });

            ViewData["Grafica_alcalde"] = pieHalfData1;



            List<ColumnSeriesData> columnVotingData = new List<ColumnSeriesData>()
            {
                new ColumnSeriesData { Name = "Personas que Ya votaron", Y = 56.3},
                new ColumnSeriesData { Name = "Personas que no votaron", Y = 24.03 },
            };
            ViewData["Grafica_votaciones"] = columnVotingData;

            return View();    
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        #region Terminos y condiciones
        public ActionResult Politicas()
        {
            return View();
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        #region Validacion de los datos
        public ActionResult Login()
        {
            return View();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="citizen"></param>
        /// <returns></returns>
        [HttpPost]
        //[ValidateAntiForgeryToken]
        public ActionResult Login(CitizenViewModels citizenViewModels)
        {
            if (ModelState.IsValid)
            {
                using (INE_PatronosDbContext dbContext = new INE_PatronosDbContext())
                {
                    var obj = dbContext.Citizens.Where(x => x.ElectroKey.Equals(citizenViewModels.ElectroKey) && x.CIC.Equals(citizenViewModels.CIC)).FirstOrDefault();
                    if (obj != null)
                    {
                        Session["ID"] = obj.Id.ToString();
                        Session["ElectroKey"] = obj.ElectroKey.ToString();
                    }
                    else
                    {
                        ModelState.AddModelError("", "Error al intentar ingresar.");
                        return RedirectToAction("MostrarError");
                    }
                }
            }
            //aqui va donde lo quieres dirijir
            return RedirectToAction("BoletaPresidente");
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public ActionResult MostrarError()
        {
            return View();
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        #region Ventana de Boleta
        [HttpGet]
        public ActionResult BoletaPresidente()
        {
            if (Session["ID"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login");
            }
        }

        [HttpPost]
        public ActionResult BoletaPresidente(VotePresident votePresident)
        {
            using (INE_PatronosDbContext dbContext = new INE_PatronosDbContext())
            {
                if (!ModelState.IsValid)
                {
                    return View(votePresident);
                }

                dbContext.VotePresidents.Add(votePresident);
                dbContext.SaveChanges();
                return RedirectToAction("Confirmacion");
            }   
        }
        #endregion

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        #region Resultados
        [HttpGet]
        public ActionResult Resultados()
        {
            using (INE_PatronosDbContext dbctx = new INE_PatronosDbContext())
            {
                List<VotePresident> votePresidents = new List<VotePresident>();
                votePresidents = dbctx.VotePresidents.ToList();
                return View(votePresidents);
            }              
        }
        #endregion

        public ActionResult Confirmacion()
        {
            return View();
        }

        public ActionResult MostrarCitizen()
        {
            using (INE_PatronosDbContext dbctx = new INE_PatronosDbContext())
            {
                List<Citizen> defaultCitizens = new List<Citizen>();
                defaultCitizens = dbctx.Citizens.ToList();
                return View(defaultCitizens);
            }
            
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        #region Boleta provicional
        public ActionResult BoletaProvisional()
        {
            return View();
        }
        #endregion
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        #region TU Informacion
        public ActionResult TuInformacion()
        {
            return View();
        }
        #endregion

        //ya que termine de votar confirmara si quiere hacer unos cambios antes terminar
        //y regresara a la pagina principal de las graficas.

    }
}