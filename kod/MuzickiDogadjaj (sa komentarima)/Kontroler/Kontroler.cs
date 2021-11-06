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
        // _ je po konvenciji obelezavanje privatnog atributa
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

        //kontroler pravi operaciju i u njoj brokera(kaci se na bazu)
        // PRIJAVA
        public Organizator PrijaviOrganizatora(Organizator organizator)
        {
            OpstaSistemskaOperacija operacija = new PrijaviOrganizatoraSO();
            // kontroler ustvari radi sa brokerom i vraca svoj rezultat niti
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
            OpstaSistemskaOperacija operacija = new DodajMuzickiDogadjajSO();
            operacija.Izvrsi(muzickiDogadjaj);
            return ((DodajMuzickiDogadjajSO)operacija).Uspelo;
        }



        // UNOST IZVODJACA
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
            OpstaSistemskaOperacija operacija = new IzmeniIzvodjacaSO();
            operacija.Izvrsi(objekat);
            return ((IzmeniIzvodjacaSO)operacija).Uspelo;
        }







        //public object DodajGlumca(Glumac objekat)
        //{
        //    OpstaSistemskaOperacija operacija = new DodajGlumcaSO();
        //    operacija.Izvrsi(objekat);
        //    return ((DodajGlumcaSO)operacija).Uspelo;
        //}

        //public object VratiGlumce()
        //{
        //    OpstaSistemskaOperacija operacija = new VratiGlumceSO();
        //    operacija.Izvrsi(new Glumac());
        //    return ((VratiGlumceSO)operacija).Glumci;

        //}

        //public object ObrisiGlumca(Glumac glumac)
        //{
        //    OpstaSistemskaOperacija operacija = new ObrisiGlumcaSO();
        //    operacija.Izvrsi(glumac);
        //    return ((ObrisiGlumcaSO)operacija).Uspelo;
        //}

        //public object IzmeniGlumca(Glumac glumac)
        //{
        //    OpstaSistemskaOperacija operacija = new IzmeniGlumcaSO();
        //    operacija.Izvrsi(glumac);
        //    return ((IzmeniGlumcaSO)operacija).Uspelo;
        //}

        //public object DodajFilm(Film film)
        //{
        //    OpstaSistemskaOperacija operacija = new DodajFilmSO();
        //    operacija.Izvrsi(film);
        //    return ((DodajFilmSO)operacija).Uspelo;
        //}

        //public object VratiFilmove()
        //{
        //    OpstaSistemskaOperacija operacija = new VratiFimoveSO();
        //    operacija.Izvrsi(new Film());
        //    return ((VratiFimoveSO)operacija).Filmovi;
        //}

        //public object ObrisiFilm(Film film)
        //{
        //    OpstaSistemskaOperacija operacija = new ObrisiFilmSO();
        //    operacija.Izvrsi(film);
        //    return ((ObrisiFilmSO)operacija).Uspelo;
        //}

        //public object IzmeniFilm(Film film)
        //{
        //    OpstaSistemskaOperacija operacija = new IzmeniFilmSO();
        //    operacija.Izvrsi(film);
        //    return ((IzmeniFilmSO)operacija).Uspelo;
        //}

        //public object VratiUloge(Film film)
        //{
        //    OpstaSistemskaOperacija operacija = new VratiUlogeSO();
        //    operacija.Izvrsi(film);
        //    return ((VratiUlogeSO)operacija).Uloge;
        //}

        //public object DodajRecenziju(Recenzija recenzija)
        //{
        //    OpstaSistemskaOperacija operacija = new DodajRecenzijuSO();
        //    operacija.Izvrsi(recenzija);
        //    return ((DodajRecenzijuSO)operacija).Uspelo;
        //}
    }

}
