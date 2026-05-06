using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace actividadHerencia1
{
    internal class Bebida
    {
        #region Atributos
        private string nombre;
        private int cm3;
        private Marca marca;
        private int cant;
        private bool esAlcoholicaSiNo;
        private double graduacionAlcoholica;
        private TipoBebida tipoBebida;
        #endregion

        #region Propiedades
        public string Nombre {  get { return nombre; } set { nombre = value; } }
        #endregion
    }

    public class Vino
    {
        private int cantCopas;

    }

    public class Cerveza
    {
        private int cantLatas;
    }

    public class AguaSaborizada
    {
        private string sabor;
    }

}
