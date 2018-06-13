using System;
using System.Collections.Generic;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitoring
{
    class HardwareInfo
    {
        public static string cpuMaker = "";
        public static String GetCpu()
        {     
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();
            String info = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                string name = (string)mo["Name"];
                name = name.Replace("(TM)", "™").Replace("(tm)", "™").Replace("(R)", "®").Replace("(r)", "®").Replace("(C)", "©").Replace("(c)", "©").Replace("    ", " ").Replace("  ", " ");
                
                info = name;
            }
            if (info.Contains("ntel"))
            {
                cpuMaker = "Intel";
            }
            else cpuMaker = "Amd";
            return info;
        }
        public static string GetRam()
        {
            ManagementScope ram = new ManagementScope();
            ObjectQuery recherche = new ObjectQuery("SELECT Capacity FROM Win32_PhysicalMemory");
            ManagementObjectSearcher oSearcher = new ManagementObjectSearcher(ram, recherche);
            ManagementObjectCollection oCollection = oSearcher.Get();

            long MemSize = 0;
            long mCap = 0;

            foreach (ManagementObject obj in oCollection)
            {
                mCap = Convert.ToInt64(obj["Capacity"]);
                MemSize += mCap;
            }
            MemSize = (MemSize / 1024) / 1024;
            return MemSize.ToString() + " Mo";
        }
        public static string GetOS()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_OperatingSystem");
            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return ((string)wmi["Caption"]).Trim() + ", " + (string)wmi["OSArchitecture"];
                }
                catch { }
            }
            return "Système d'exploitation non reconnu";
        }
        public static String GetGpu()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("root\\CIMV2", "SELECT * FROM Win32_VideoController");

            foreach (ManagementObject wmi in searcher.Get())
            {
                try
                {
                    return wmi.GetPropertyValue("VideoProcessor").ToString();

                }

                catch { }
            }
            return "Composant d'affichage non reconnu";

        }
        public static string GetIp()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    return ip.ToString();
                }
            }
            throw new Exception("Ip inconnue");
        }

        public static double GetPhysicalMemory()
        {
            var winQuery = new ObjectQuery("SELECT * FROM Win32_OperatingSystem");
            var searcher = new ManagementObjectSearcher(winQuery);
            var operatingSystem = searcher.Get().Cast<ManagementObject>().FirstOrDefault();

            return operatingSystem != null ? double.Parse(operatingSystem["TotalVisibleMemorySize"].ToString()) : 0;
        }
    }
}
