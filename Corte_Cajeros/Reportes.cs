using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_Cajeros
{
    class Reportes
    {
        public int boletos_cobrados { get; set; }
        public int boletos_tolerancia { get; set; }
        public int boletos_cortesia { get; set; }
        public int boletos_guada { get; set; }
        public int boletos_perdidos { get; set; }
        public int folio_emisor { get; set; }
        public int folios_rojos { get; set; }
        public int contador { get; set; }
        public int coches_dentro { get; set; }
        public int entradas_tarjeta { get; set; }
        public int salidas_tarjeta { get; set; }
        public int total_salidas { get; set; }
        public int total_boletos { get; set; }

        public Reportes() { }

        public Reportes(int boletos_cobrados, int boletos_tolerancia, int boletos_cortesia, int boletos_guada, int boletos_perdidos,  
        int folio_emisor, int folios_rojos, int contador, int coches_dentro, int entradas_tarjeta, int salidas_tarjeta, int total_boletos, int total_salidas)

        {
            this.boletos_cobrados = boletos_cobrados;
            this.boletos_tolerancia = boletos_tolerancia;
            this.boletos_cortesia = boletos_cortesia;
            this.boletos_guada = boletos_guada;
            this.boletos_perdidos = boletos_perdidos;
            this.folio_emisor = folio_emisor;
            this.folios_rojos = folios_rojos;
            this.contador = contador;
            this.coches_dentro = coches_dentro;
            this.entradas_tarjeta = entradas_tarjeta;
            this.salidas_tarjeta = salidas_tarjeta;
            this.total_boletos = total_boletos;
            this.total_salidas = total_salidas;

        }

    }
}
