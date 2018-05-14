using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BibliotecaDalc;
namespace Entidades
{
    public class Cl_Socios
    {
        public int NumeroSocio { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public int Fono { get; set; }
        public string Patente { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Anio { get; set; }
        public string Foto { get; set; }
        public string activo { get; set; }

        RadioTaxiEntities contexto = new RadioTaxiEntities();
        public Cl_Socios()
        {

        }

        public bool agregar()
        {
            try
            {
                BibliotecaDalc.SOCIOS socio = new SOCIOS();
                CommonBC.Syncronize(this, socio);
                contexto.SOCIOS.Add(socio);
                contexto.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        //OJO!! no se elimina, se actualiza, ya que te pide listar los ex socios...
        public bool desactivar()
        {
            try
            {
                BibliotecaDalc.SOCIOS soc = contexto.SOCIOS.First(x => x.NUMEROSOCIO == NumeroSocio);
                CommonBC.Syncronize(this, soc);
                contexto.SOCIOS.Add(soc);
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
                BibliotecaDalc.SOCIOS soc = contexto.SOCIOS.First(x=>x.NUMEROSOCIO==NumeroSocio);
                CommonBC.Syncronize(soc, this);
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
                BibliotecaDalc.SOCIOS soc = contexto.SOCIOS.First(x => x.NUMEROSOCIO == NumeroSocio);
                CommonBC.Syncronize(this, soc);
                contexto.SOCIOS.Add(soc);
                contexto.SaveChanges();
                return true;
            
            }
            catch (Exception)
            {

                return false;
            }
        }

        //listado socios en general
        public List<Cl_Socios> ReadAll()
        {
            try
            {
                List<Cl_Socios> so = new List<Cl_Socios>();
                var socios = contexto.SOCIOS.ToList();
                foreach (var item in socios)
                {
                    Cl_Socios s = new Cl_Socios();
                    CommonBC.Syncronize(item, s);
                }
                return so;
            }
            catch (Exception)
            {

                return null;
            }
        }
        //Listado datos personales por socio.
        public List<Cl_Socios> readByNumeroSocio()
        {
            try
            {
                var socios = from soc in contexto.SOCIOS
                             where soc.NUMEROSOCIO == NumeroSocio
                             select soc;
                return generarListado(socios.ToList());
            }
            catch (Exception)
            {

                return null;
            }
        }

        //genera listado.
        public List<Cl_Socios> generarListado(List<BibliotecaDalc.SOCIOS> socioM)
        {
            try
            {
                List<Cl_Socios> so = new List<Cl_Socios>();
                foreach (var item in socioM)
                {
                    Cl_Socios s = new Cl_Socios();
                    CommonBC.Syncronize(item, s);
                    so.Add(s);
                }
                return so;
            }
            catch (Exception)
            {

                return null;
            }
        }

        //listado ex Socios
        public List<Cl_Socios> readExSocios()
        {
            try
            {
                var socios = from soc in contexto.SOCIOS
                             where soc.ACTIVO.Equals(activo)
                             select soc;
                return generarListado(socios.ToList());
            }
            catch (Exception)
            {

                return null;
            }
        }

    }
}
