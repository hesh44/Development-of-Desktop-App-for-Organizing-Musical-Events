using BrokerBazePodataka;
using Domen;
using System;
using SistemskeOperacije;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kontroler
{
    public class Kontroler
    {
        private static Kontroler _instance;
        private Broker broker = new Broker();
        public static Kontroler Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Kontroler();
                return _instance;
            }
        }

        // PRIJAVA
        public Organizator PrijaviOrganizatora(Organizator organizator)
        {
            OpstaSistemskaOperacija operacija = new PrijaviOrganizatoraSO();
            operacija.Izvrsi(organizator);
            return ((PrijaviOrganizatoraSO)operacija).Organizator;
        }



        // UNOS MUZICKOG D
        public object VratiLokacije()
        {
            OpstaSistemskaOperacija operacija = new VratiLokacijeSO();
            operacija.Izvrsi(new Lokacija());
            return ((VratiLokacijeSO)operacija).Lokacije;
        }
        public object DodajMuzickiD(MuzickiDogadjaj muzickiDogadjaj)
        {
            OpstaSistemskaOperacija operacija = new SacuvajMuzickiDogadjajSO();
            operacija.Izvrsi(muzickiDogadjaj);
            return ((SacuvajMuzickiDogadjajSO)operacija).Uspelo;
        }



        // UNOS IZVODJACA
        public object SacuvajIzvodjaca(Izvodjac objekat)
        {
            OpstaSistemskaOperacija operacija = new SacuvajIzvodjacaSO();
            operacija.Izvrsi(objekat);
            return ((SacuvajIzvodjacaSO)operacija).Uspelo;
        }



        // UNOS NASTUPA
        public object VratiBineZaOvajMuzickiD(MuzickiDogadjaj objekat)
        {
            OpstaSistemskaOperacija operacija = new VratiBineZaOvajMuzickiDSO();
            operacija.Izvrsi(objekat);
            return ((VratiBineZaOvajMuzickiDSO)operacija).Bine;
        }
        public object VratiMuzickeD()
        {
            OpstaSistemskaOperacija operacija = new VratiMuzickeDSO();
            operacija.Izvrsi(new MuzickiDogadjaj());
            return ((VratiMuzickeDSO)operacija).MuzickiDogadjaji;
        }
        public object VratiIzvodjace()
        {
            OpstaSistemskaOperacija operacija = new VratiIzvodjaceSO();
            operacija.Izvrsi(new Izvodjac());
            return ((VratiIzvodjaceSO)operacija).Izvodjaci;
        }

        public object SacuvajNastup(Nastup nastup)
        {
            OpstaSistemskaOperacija operacija = new SacuvajNastupSO();
            operacija.Izvrsi(nastup);
            return ((SacuvajNastupSO)operacija).Uspelo;
        }

        public object ObrisiMuzickiD(MuzickiDogadjaj objekat)
        {
            OpstaSistemskaOperacija operacija = new ObrisiMuzickiDSO();
            operacija.Izvrsi(objekat);
            return ((ObrisiMuzickiDSO)operacija).Uspelo;
        }

        public object SacuvajIzmenuMuzickogD(MuzickiDogadjaj objekat)
        {
            OpstaSistemskaOperacija operacija = new SacuvajIzmenuMuzickogDSO();
            operacija.Izvrsi(objekat);
            return ((SacuvajIzmenuMuzickogDSO)operacija).Uspelo;
        }

        public object ObrisiIzvodjaca(Izvodjac objekat)
        {
            OpstaSistemskaOperacija operacija = new ObrisiIzvodjacaSO();
            operacija.Izvrsi(objekat);
            return ((ObrisiIzvodjacaSO)operacija).Uspelo;
        }

        public object IzmeniIzvodjaca(Izvodjac objekat)
        {
            OpstaSistemskaOperacija operacija = new SacuvajIzmenuIzvodjacaSO();
            operacija.Izvrsi(objekat);
            return ((SacuvajIzmenuIzvodjacaSO)operacija).Uspelo;
        }
    }
}
