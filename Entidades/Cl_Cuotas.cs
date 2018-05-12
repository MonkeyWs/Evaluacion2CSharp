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
        public int MesPago { get; set; }
        public DateTime  FechaPago { get; set; }
        public int Monto { get; set; }


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

       
    }
}
