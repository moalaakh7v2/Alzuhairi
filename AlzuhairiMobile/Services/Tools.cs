using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace AlzuhairiMobile.Services
{
    public class Tools
    {
        public static string GetMacAddr()
        {
            try
            {
                var ni = NetworkInterface.GetAllNetworkInterfaces().OrderBy(intf => intf.NetworkInterfaceType)
                    .FirstOrDefault(intf => intf.OperationalStatus == OperationalStatus.Up
                    && (intf.NetworkInterfaceType == NetworkInterfaceType.Wireless80211
                    || intf.NetworkInterfaceType == NetworkInterfaceType.Ethernet));
                var hw = ni.GetPhysicalAddress();
                return string.Join(":", (from ma in hw.GetAddressBytes() select ma.ToString("X2")).ToArray());
            }
            catch (Exception ex)
            {

            }
            return "Error Device";
        }

    }
}
