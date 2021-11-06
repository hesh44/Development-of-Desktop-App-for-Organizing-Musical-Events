using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    public class Server
    {
        private FrmServer frmServer;
        private List<NitKlijenta> klijenti = new List<NitKlijenta>();
        private Socket soket;

        public Server(FrmServer frmServer)
        {
            this.frmServer = frmServer;
        }

        internal bool Pokreni()
        {
            try
            {
                soket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                soket.SetSocketOption(SocketOptionLevel.Socket, SocketOptionName.ReuseAddress, true);
                soket.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 20000));
                soket.Listen(5);
                Thread nit = new Thread(Osluskuj);
                nit.IsBackground = true;
                nit.Start();
                return true;
            }
            catch (SocketException e)
            {
                Debug.WriteLine(">>> " + e.Message);
                return false;
            }
        }

        private void Osluskuj()
        {
            bool kraj = false;
            while (!kraj)
            {
                try
                {
                    Socket klijent = soket.Accept();
                    NitKlijenta nitKlijenta = new NitKlijenta(klijent, frmServer);
                    klijenti.Add(nitKlijenta);
                    //OsveziFormu();
                    new Thread(nitKlijenta.Obradjuj).Start();
                }
                catch (ThreadInterruptedException e)
                {
                    kraj = true;
                }
                catch (SocketException e)
                {
                    kraj = true;
                }
            }
        }

        internal bool Zaustavi()
        {
            try
            {
                for (int i = 0; i < klijenti.Count; i++)
                {
                    klijenti[i].Ugasi();
                }
                klijenti = new List<NitKlijenta>();
                soket.Close();
                return true;
            }
            catch (Exception e)
            {
                Debug.WriteLine(">>> " + e.Message);
                return false;
            }

        }

    }
}
