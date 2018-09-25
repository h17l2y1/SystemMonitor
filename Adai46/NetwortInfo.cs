using System;
using System.Net;

namespace Adai46
{
    class NetworkInfo : SeacherInfo
    {
        private String _IpAdress;

        public string IpAdress { get => _IpAdress; set => _IpAdress = value; }

        public NetworkInfo()
        {
            _IpAdress = getIp();
        }

        private static String getIp()
        {
            string hostName = Dns.GetHostName();
            return Dns.GetHostByName(hostName).AddressList[0].ToString();
        }

        public String CheckInternetConnection()
        {
            try
            {
                using (var client = new WebClient())
                using (client.OpenRead("http://clients3.google.com/generate_204"))
                {
                    return "True";
                }
            }
            catch
            {
                return "False";
            }
        }


    }
}
