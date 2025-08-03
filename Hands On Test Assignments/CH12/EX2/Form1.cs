using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX2
{
    public partial class Form1 : Form
    {
        private List<Computer> _computers;
        private Dictionary<int, string> _serviceNames;
        public Form1()
        {
            InitializeComponent();
            _computers = new List<Computer>
            {
                new Computer("My-Desktop", "127.0.0.1", new int[] { 20, 21, 23, 25, 53, 80, 123, 389, 443 }),
                new Computer("google-public-dns-a", "8.8.8.8", new int[] { 53 }),
                new Computer("ranken.edu", "47.44.246.80", new int[] { 25, 80, 443 })
            };

            _serviceNames = new Dictionary<int, string>
            {
                { 20, "FTP_DATA" },
                { 21, "FTP_CONTROL" },
                { 23, "TELNET" },
                { 25, "SMTP" },
                { 53, "DNS" },
                { 80, "HTTP" },
                { 123, "NTP" },
                { 389, "LDAP" },
                { 443, "HTTPS" }
            };
        }
        private void btnScan_Click(object sender, EventArgs e)
        {
            string inputIp = txtAddress.Text.Trim();
            Computer result = ScanIpAddress(inputIp);
            ShowComputer(result);
        }
        private Computer ScanIpAddress(string ipAddress)
        {
            foreach (Computer comp in _computers)
            {
                if (comp.IpAddress == ipAddress)
                    return comp;
            }
            return null;
        }
        private void ShowComputer(Computer computer)
        {
            lblName.Text = computer != null ? computer.Name : "Request Timed Out";
            lblIP.Text = txtAddress.Text;

            if (computer != null && computer.Services.Length > 0)
            {
                string output = "";
                foreach (int port in computer.Services)
                {
                    string service = _serviceNames.ContainsKey(port) ? _serviceNames[port] : "UNKNOWN";
                    output += $"{port}: {service}" + Environment.NewLine;
                }
                lblServices.Text = output;
            }
            else
            {
                lblServices.Text = "NONE";
            }
        }
    }
}
