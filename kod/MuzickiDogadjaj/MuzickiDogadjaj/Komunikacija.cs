using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Domen;

namespace MuzickiDogadjaj
{
    public class Komunikacija
    {
        private static Komunikacija _instance;


        public static Komunikacija Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Komunikacija();
                return _instance;
            }
        }
        private Socket klijent;
        private NetworkStream tok;


        private BinaryFormatter formater = new BinaryFormatter();



        internal bool PoveziSe()
        {
            try
            {
                if (klijent == null || !klijent.Connected)
                {

                    klijent = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    klijent.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                    klijent.Connect(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 20000));
                    tok = new NetworkStream(klijent);
                }
                return true;
            }
            catch (SocketException e)
            {
                Debug.WriteLine(">>> " + e.Message);
                return false;
            }
        }
        internal void Zavrsi()
        {
            klijent.Close();
        }






        // PRIJAVA
        internal Organizator PrijaviOrganizatora(string username, string pass)
        {
            try
            {
                Organizator organizator = new Organizator { KorisnickoIme = username, Lozinka = pass };
                Zahtev zahtev = new Zahtev { Objekat = organizator, Operacija = Operacija.PrijaviOrganizatora };
                formater.Serialize(tok, zahtev);

                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                if (odgovor.Signal == Signal.Ok)
                {
                    return (Organizator)odgovor.Objekat;
                }
                return null;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(">>" + ex.Message);
                throw;

            }
        }


        //UNOS MUZICKOG DOGADJAJA
        internal object vratiLokacije()
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = new Object(), Operacija = Operacija.VratiLokacije };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (List<Lokacija>)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije pronasao lokacije");
                }
                return null;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }
        internal Odgovor DodajMuzickiD(Domen.MuzickiDogadjaj muzickiDogadjaj)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = muzickiDogadjaj, Operacija = Operacija.DodajMuzickiD };
                formater.Serialize(tok, zahtev);
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                switch (odgovor.Signal)
                {
                    case Signal.Ok:
                        return odgovor;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije dodao muzički događaj");
                }
                return null;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguća komunikacija sa serverom");
            }
        }


        // UNOS IZVODJACA
        internal bool SacuvajIzvodjaca(Izvodjac i)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = i, Operacija = Operacija.SacuvajIzvodjaca };
                formater.Serialize(tok, zahtev);
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                switch (odgovor.Signal)
                {
                    case Signal.Ok:
                        return (bool)odgovor.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije sačuvao izvođača");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguća komunikacija sa serverom");
            }
        }


        // UNOS NASTUPA
        internal object vratiMuzickeD()
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = new Object(), Operacija = Operacija.VratiMuzickeD };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (List<Domen.MuzickiDogadjaj>)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije pronasao muzicke dogadjaje");
                }
                return null;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }
        internal object vratiBineZaOvajMuzickiD(Domen.MuzickiDogadjaj muzickiDogadjaj)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = muzickiDogadjaj, Operacija = Operacija.VratiBineZaOvajMuzickiD };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (List<Bina>)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije pronasao bine za ovaj muzicki dogadjaj");
                }
                return null;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }
        internal object vratiIzvodjace()
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = new Object(), Operacija = Operacija.VratiIzvodjace };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (List<Izvodjac>)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije pronasao izvodjace");
                }
                return null;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }
        internal bool sacuvajNastup(Nastup nastup)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = nastup, Operacija = Operacija.SacuvajNastup };
                formater.Serialize(tok, zahtev);
                Odgovor odgovor = (Odgovor)formater.Deserialize(tok);
                switch (odgovor.Signal)
                {
                    case Signal.Ok:
                        return (bool)odgovor.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije dodao nastup");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }



        // BRISANJE I IZMENA MUZICKOG D
        internal bool ObrisiMuzickiD(Domen.MuzickiDogadjaj md)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = md, Operacija = Operacija.ObrisiMuzickiD };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (bool)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije obrisao muzicki dogadjaj");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }
        internal bool SacuvajIzmenuMuzickogD(Domen.MuzickiDogadjaj md)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = md, Operacija = Operacija.SacuvajIzmenuMuzickogD };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (bool)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije izmenio muzicki dogadjaj");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }


        // BRISANJE I IZMENA IZVODJACA
        internal bool ObrisiIzvodjaca(Izvodjac i)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = i, Operacija = Operacija.ObrisiIzvodjaca };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (bool)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije obrisao izvodjaca");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }
        internal bool IzmeniIzvodjaca(Izvodjac i)
        {
            try
            {
                Zahtev zahtev = new Zahtev { Objekat = i, Operacija = Operacija.IzmeniIzvodjaca };
                formater.Serialize(tok, zahtev);
                Odgovor odg = (Odgovor)formater.Deserialize(tok);
                switch (odg.Signal)
                {
                    case Signal.Ok:
                        return (bool)odg.Objekat;
                    case Signal.KrajServer:
                        Zavrsi();
                        throw new Exception("Server je prekinuo rad");
                    case Signal.Error:
                        throw new Exception("Server nije izmenio izvodjaca");
                }
                return false;
            }
            catch (Exception)
            {
                Zavrsi();
                throw new Exception("Nije moguca komunikacija sa serverom");
            }
        }
    }
}
