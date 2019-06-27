using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TezosPassordCrackerForWindows
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void LinkLabelDonationTezos_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Thank you for donating. 
            Clipboard.SetText(linkLabelDonationTezos.Text);

            if (DialogResult.Yes == MessageBox.Show("Thank you for your support! Our work is donation based. \nThe Tezos address " + linkLabelDonationTezos.Text + " has been copied to your clipboard.\n\nWould you like to see the donation address?", "Thank you!", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                Process.Start(@"https://tzscan.io/" + linkLabelDonationTezos.Text);
            }
        }

        private void LinkLabelDonationBTC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //Thank you for donating. 
            Clipboard.SetText(linkLabelDonationBTC.Text);

            if (DialogResult.Yes == MessageBox.Show("Thank you for your support! Our work is donation based. \nThe Bitcoin address " + linkLabelDonationBTC.Text + " has been copied to your clipboard.\n\nWould you like to see the donation address?", "Thank you!", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
            {
                Process.Start(@"https://www.blockchain.com/btc/address/" + linkLabelDonationBTC.Text);
            }
        }

        private void LinkLabelGitHub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(@"https://github.com/LordDarkHelmet/TezosPassordCrackerForWindows");
        }

        private void About_Load(object sender, EventArgs e)
        {
            labelVersion.Text = Application.ProductVersion;
            labellabelProductName.Text = Application.ProductName;
            labelCompanyName.Text = Application.CompanyName;
        }

        private void PictureBoxSpaceballs_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://www.imdb.com/title/tt0094012/");
        }

        private void PictureBoxTezosHelpGroupIcon_Click(object sender, EventArgs e)
        {
            Process.Start(@"https://t.me/xtzrecovery");
        }
    }
}
