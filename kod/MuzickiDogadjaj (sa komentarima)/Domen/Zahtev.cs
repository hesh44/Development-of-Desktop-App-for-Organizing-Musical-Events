using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domen
{
    [Serializable]
    public class Zahtev
    {
        public Operacija Operacija { get; set; }
        public object Objekat { get; set; }
    }

    public enum Operacija
    {
        PrijaviOrganizatora,
        Kraj,
        SacuvajIzvodjaca,
        DodajMuzickiD,
        VratiLokacije,
        VratiMuzickeD,
        VratiIzvodjace,
        VratiBineZaOvajMuzickiD,
        SacuvajNastup,
        ObrisiMuzickiD,
        SacuvajIzmenuMuzickogD,
        ObrisiIzvodjaca,
        IzmeniIzvodjaca
    }
}