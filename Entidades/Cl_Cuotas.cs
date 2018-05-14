using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDalc;

namespace Entidades
{
    public class Cl_Cuotas
    {
        public int NumeroCuota { get; set; }
        public int NumeroSocio { get; set; }
        public DateTime MesPago { get; set; }
        public DateTime  FechaPago { get; set; }
        public int Monto { get; set; }
        public string Activo { get; set; }


        RadioTaxiEntities contexto = new RadioTaxiEntities();
        public Cl_Cuotas()
        {

        }

        public bool agregar()
        {
            try
            {
                BibliotecaDalc.CUOTAS cuota = new CUOTAS();
                CommonBC.Syncronize(this, cuota);
                contexto.CUOTAS.Add(cuota);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool desactivar()
        {
            try
            {
                BibliotecaDalc.CUOTAS cuo = contexto.CUOTAS.First(c => c.NUMEROCUOTA==NumeroCuota);
                CommonBC.Syncronize(this,cuo);
                contexto.CUOTAS.Add(cuo);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool buscar()
        {
            try
            {
                BibliotecaDalc.CUOTAS cuo = contexto.CUOTAS.First(c => c.NUMEROCUOTA == NumeroCuota);
                CommonBC.Syncronize(cuo, this);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool modificar()
        {
            try
            {
                BibliotecaDalc.CUOTAS cuo = contexto.CUOTAS.First(c => c.NUMEROCUOTA == NumeroCuota);
                CommonBC.Syncronize(this, cuo);
                contexto.CUOTAS.Add(cuo);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Cl_Cuotas> readAll()
        {
            try
            {
                List<Cl_Cuotas> cu = new List<Cl_Cuotas>();
                var cuotas = contexto.CUOTAS.ToList();
                foreach (var item in cuotas)
                {
                    Cl_Cuotas c = new Cl_Cuotas();
                    CommonBC.Syncronize(item, c);
                }
                return cu;
            }
            catch (Exception)
            {

                return null;
            }
        }


        public List<Cl_Cuotas> generarListado(List<BibliotecaDalc.CUOTAS> socioM)
        {
            try
            {
                List<Cl_Cuotas> cu = new List<Cl_Cuotas>();
                foreach (var item in socioM)
                {
                    Cl_Cuotas c = new Cl_Cuotas();
                    CommonBC.Syncronize(item, c);
                    cu.Add(c);
                }
                return cu;
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Cl_Cuotas> readBymes()
        {
            try
            {
                var cuotas = from cu in contexto.CUOTAS
                             where cu.MESPAGO == MesPago
                             select cu;
                return generarListado(cuotas.ToList());
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Cl_Cuotas> readEntreMeses()
        {
            try
            {
                var cuotas = from cu in contexto.CUOTAS
                             where ((DateTime)cu.MESPAGO).ToString("MM").Equals(MesPago.ToString("MM"))
                             select cu;
                return generarListado(cuotas.ToList());
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Cl_Cuotas> readPorSocio()
        {
            try
            {
                var cuotas = from cu in contexto.CUOTAS
                             where cu.FK_NUMEROSOCIO == NumeroSocio
                             select cu;

                return generarListado(cuotas.ToList());
            }
            catch (Exception)
            {

                return null;
            }
        }

        public List<Cl_Cuotas> readByMarca()
        {
            try
            {
                var cuotas = from cu in contexto.CUOTAS
                             join so in contexto.SOCIOS
                             on cu.FK_NUMEROSOCIO equals so.NUMEROSOCIO
                             where so.MARCA.Equals((new Cl_Socios()).Marca)
                             select cu;
                return generarListado(cuotas.ToList());
            }
            catch (Exception)
            {

                return null;
            }
        }
    }
}
