using Domen;
using Kontroler;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Server
{
    internal class NitKlijenta
    {
        // za ispit sam ovde prosledjivao samo tok, dok moze da se prosledi klijent pa onda ovde inicijalizuje njego tok 
        private Socket klijent;
        // korisnika koristimo samo kod prijave 
        public Organizator organizator;
        // VEROVATNO nam ne treba jer nisam video da je koristio negde
        //private FrmServer frmServer;
        private NetworkStream tok;
        private BinaryFormatter formatter = new BinaryFormatter();
        // ovo je isto sto i za ispit int operacija
        private bool kraj;

        public NitKlijenta(Socket klijent, FrmServer frmServer)
        {
            this.klijent = klijent;
            // VEROVATNO nam ne treba jer nisam video da je koristio negde
            //this.frmServer = frmServer;
            this.tok = new NetworkStream(klijent);
        }

        internal void Obradjuj()
        {
            kraj = false;
            while (!kraj)
            {
                try
                {
                    Zahtev zahtev;
                    try
                    {
                         zahtev = (Zahtev)formatter.Deserialize(tok);
                    }
                    catch (Exception ex)
                    {
                        System.Windows.Forms.MessageBox.Show(ex.Message);
                        throw;
                    }
                    Odgovor odgovor = new Odgovor();
                    switch (zahtev.Operacija)
                    {
                        case Operacija.PrijaviOrganizatora:
                            odgovor = PrijaviKorisnika((Organizator)zahtev.Objekat);
                            break;
                        case Operacija.SacuvajIzvodjaca:
                            odgovor = SacuvajIzvodjaca((Izvodjac)zahtev.Objekat);
                            break;
                        //case Operacija.VratiGlumce:
                        //    odgovor = VratiGlumce();
                        //    break;
                        case Operacija.ObrisiIzvodjaca:
                            odgovor = ObrisiIzvodjaca((Izvodjac)zahtev.Objekat);
                            break;
                        case Operacija.IzmeniIzvodjaca:
                            odgovor = IzmeniIzvodjaca((Izvodjac)zahtev.Objekat);
                            break;
                        case Operacija.VratiLokacije:
                            odgovor = VratiLokacije();
                            break;
                        case Operacija.DodajMuzickiD:
                            odgovor = DodajMuzickiD((MuzickiDogadjaj)zahtev.Objekat);
                            break;
                        case Operacija.Kraj:
                            Zavrsi();
                            break;
                        case Operacija.VratiIzvodjace:
                            odgovor = VratiIzvodjace();
                            break;
                        case Operacija.VratiMuzickeD:
                            odgovor = VratiMuzickeD();
                            break;
                        case Operacija.VratiBineZaOvajMuzickiD:
                            odgovor = VratiBineZaOvajMuzickiD((MuzickiDogadjaj)zahtev.Objekat);
                            break;
                        case Operacija.ObrisiMuzickiD:
                            odgovor = ObrisiMuzickiD((MuzickiDogadjaj)zahtev.Objekat);
                            break;
                        case Operacija.SacuvajIzmenuMuzickogD:
                            odgovor = SacuvajIzmenuMuzickogD((Domen.MuzickiDogadjaj)zahtev.Objekat);
                            break;
                        //case Operacija.VratiUloge:
                        //    odgovor = VratiUloge((Film)zahtev.Objekat);
                        //    break;
                        case Operacija.SacuvajNastup:
                            odgovor = SacuvajNastup((Nastup)zahtev.Objekat);
                            break;
                    }
                    Salji(odgovor);
                }
                catch (ThreadInterruptedException e)
                {
                    kraj = false;
                }
                catch (IOException e)
                {
                    kraj = false;
                }
            }
        }







        // PRIJAVA 
        private Odgovor PrijaviKorisnika(Organizator objekat)
        {
            // NitKlijenta koristi Kontroler
            // kontroler je spona izmedju niti i brokera za konkretan tip objekta
            organizator = Kontroler.Kontroler.Instance.PrijaviOrganizatora(objekat);
            Odgovor odgovor = new Odgovor();
            if (organizator == null)
            {
                odgovor.Signal = Signal.Error;
                odgovor.Poruka = "Nije pronadjen korisnik";
                odgovor.Objekat = new Organizator();
            }
            else
            {
                odgovor.Signal = Signal.Ok;
                odgovor.Poruka = "Pronadjen je korisnik";
                odgovor.Objekat = organizator;
            }
            return odgovor;
        }



        // UNOS MUZICKOG DOGADJAJA
        private Odgovor DodajMuzickiD(MuzickiDogadjaj muzickiDogadjaj)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.DodajMuzickiD(muzickiDogadjaj);
            if ((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }
        private Odgovor VratiLokacije()
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.VratiLokacije();
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }
        
        

        // UNOST IZVODJACA
        private Odgovor SacuvajIzvodjaca(Izvodjac objekat)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.SacuvajIzvodjaca(objekat);
            if ((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }




        // UNOS NASTUPA
        private Odgovor VratiBineZaOvajMuzickiD(MuzickiDogadjaj objekat)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.VratiBineZaOvajMuzickiD(objekat);
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }
        private Odgovor VratiMuzickeD()
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.VratiMuzickeD();
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }
        private Odgovor VratiIzvodjace()
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.VratiIzvodjace();
            if (odgovor.Objekat == null)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;
            }
            return odgovor;
        }
        private Odgovor SacuvajNastup(Nastup nastup)
        {
            Odgovor odgovor = new Odgovor();
            odgovor.Objekat = Kontroler.Kontroler.Instance.SacuvajNastup(nastup);
            if ((bool)odgovor.Objekat == false)
            {
                odgovor.Signal = Signal.Error;
            }
            else
            {
                odgovor.Signal = Signal.Ok;

            }
            return odgovor;
        }




        // BRISANJE I IZMENA MUZICKOG D
        private Odgovor ObrisiMuzickiD(MuzickiDogadjaj objekat)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Kontroler.Kontroler.Instance.ObrisiMuzickiD(objekat);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;

            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }
        private Odgovor SacuvajIzmenuMuzickogD(MuzickiDogadjaj objekat)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Kontroler.Kontroler.Instance.SacuvajIzmenuMuzickogD(objekat);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;
            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }





        // BRISANJE I IZMENA IZVODJACA
        private Odgovor ObrisiIzvodjaca(Izvodjac objekat)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Kontroler.Kontroler.Instance.ObrisiIzvodjaca(objekat);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;
            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }
        private Odgovor IzmeniIzvodjaca(Izvodjac objekat)
        {
            Odgovor odg = new Odgovor();
            odg.Objekat = Kontroler.Kontroler.Instance.IzmeniIzvodjaca(objekat);
            if ((bool)odg.Objekat == false)
            {
                odg.Signal = Signal.Error;
            }
            else
            {
                odg.Signal = Signal.Ok;
            }
            return odg;
        }





        //private Odgovor VratiUloge(Film film)
        //{
        //    Odgovor odgovor = new Odgovor();
        //    odgovor.Objekat = Kontroler.Kontroler.Instance.VratiUloge(film);
        //    if (odgovor.Objekat == null)
        //    {
        //        odgovor.Signal = Signal.Error;
        //    }
        //    else
        //    {
        //        odgovor.Signal = Signal.Ok;
        //    }
        //    return odgovor;
        //}

        //private Odgovor IzmeniFilm(Film film)
        //{
        //    Odgovor odg = new Odgovor();
        //    odg.Objekat = Kontroler.Kontroler.Instance.IzmeniFilm(film);
        //    if ((bool)odg.Objekat == false)
        //    {
        //        odg.Signal = Signal.Error;
        //    }
        //    else
        //    {
        //        odg.Signal = Signal.Ok;
        //    }
        //    return odg;
        //}

        //private Odgovor ObrisiFilm(Film objekat)
        //{
        //    Odgovor odg = new Odgovor();
        //    odg.Objekat = Kontroler.Kontroler.Instance.ObrisiFilm(objekat);
        //    if ((bool)odg.Objekat == false)
        //    {
        //        odg.Signal = Signal.Error;

        //    }
        //    else
        //    {
        //        odg.Signal = Signal.Ok;
        //    }
        //    return odg;
        //}

        //private Odgovor VratiFilmove()
        //{
        //    Odgovor odgovor = new Odgovor();
        //    odgovor.Objekat = Kontroler.Kontroler.Instance.VratiFilmove();
        //    if (odgovor.Objekat == null)
        //    {
        //        odgovor.Signal = Signal.Error;
        //    }
        //    else
        //    {
        //        odgovor.Signal = Signal.Ok;
        //    }
        //    return odgovor;
        //}

        //private Odgovor DodajFilm(Film objekat)
        //{
        //    Odgovor odgovor = new Odgovor();
        //    odgovor.Objekat = Kontroler.Kontroler.Instance.DodajFilm(objekat);
        //    if ((bool)odgovor.Objekat == false)
        //    {
        //        odgovor.Signal = Signal.Error;
        //    }
        //    else
        //    {
        //        odgovor.Signal = Signal.Ok;

        //    }
        //    return odgovor;
        //}

        //private Odgovor IzmeniGlumca(Glumac glumac)
        //{
        //    Odgovor odg = new Odgovor();
        //    odg.Objekat = Kontroler.Kontroler.Instance.IzmeniGlumca(glumac);
        //    if ((bool)odg.Objekat == false)
        //    {
        //        odg.Signal = Signal.Error;
        //    }
        //    else
        //    {
        //        odg.Signal = Signal.Ok;
        //    }
        //    return odg;
        //}

        //private Odgovor ObrisiGlumca(Glumac objekat)
        //{
        //    Odgovor odg = new Odgovor();
        //    odg.Objekat = Kontroler.Kontroler.Instance.ObrisiGlumca(objekat);
        //    if ((bool)odg.Objekat == false)
        //    {
        //        odg.Signal = Signal.Error;

        //    }
        //    else
        //    {
        //        odg.Signal = Signal.Ok;
        //    }
        //    return odg;
        //}

        //private Odgovor VratiGlumce()
        //{
        //    Odgovor odgovor = new Odgovor();
        //    odgovor.Objekat = Kontroler.Kontroler.Instance.VratiGlumce();
        //    if (odgovor.Objekat == null)
        //    {
        //        odgovor.Signal = Signal.Error;
        //    }
        //    else
        //    {
        //        odgovor.Signal = Signal.Ok;
        //    }
        //    return odgovor;
        //}

        //private Odgovor DodajGlumca(Glumac objekat)
        //{
        //    Odgovor odgovor = new Odgovor();
        //    odgovor.Objekat = Kontroler.Kontroler.Instance.DodajGlumca(objekat);
        //    if ((bool)odgovor.Objekat == false)
        //    {
        //        odgovor.Signal = Signal.Error;
        //    }
        //    else
        //    {
        //        odgovor.Signal = Signal.Ok;

        //    }
        //    return odgovor;
        //}








        private void Salji(Odgovor odgovor)
        {
            formatter.Serialize(tok, odgovor);
        }
        internal void Ugasi()
        {
            Salji(new Odgovor { Signal = Signal.KrajServer });
            Zavrsi();
        }
        internal void Zavrsi()
        {
            kraj = true;
            if (klijent != null && klijent.Connected)
            {
                klijent.Shutdown(SocketShutdown.Both);
                klijent.Disconnect(false);
                klijent.Close();
            }
        }
    }
}
