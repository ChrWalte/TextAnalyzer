using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace textAnalyzer
{
    public partial class MainForm : Form {
        private static String DEFAULTTEXT = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void mainTxt_TextChanged(object sender, EventArgs e)
        {
            //Useful vars.
            int iTemp = 0;
            String sTemp = "";

            //DEFAULTTEXT
            DEFAULTTEXT = mainTxt.Text;

            //LENGTH
            lengthTxt.Text = "Length: " + mainTxt.Text.Length;

            //WORDS
            WordsTxt.Text = "Words: " + (mainTxt.Text.Split(' ').Length - 1);

            //LENGTH NO SPACES
            for (int i = 0; i < mainTxt.Text.Length; i++)
            {
                if (mainTxt.Text[i] != ' ')
                    sTemp += mainTxt.Text[i];
            }

            lengthNSTxt.Text = "Length (No Spaces): " + sTemp.Length;

            //MD5
            MD5Txt.Text = Hash.md5(mainTxt.Text);

            //SHA1
            SHA1Txt.Text = Hash.sha1(mainTxt.Text);

            //SHA256
            SHA256Txt.Text = Hash.sha256(mainTxt.Text);

            //SHA384
            SHA384Txt.Text = Hash.sha384(mainTxt.Text);

            //SHA512
            SHA512Txt.Text = Hash.sha512(mainTxt.Text);

            //EncryptTxt
            byte[] bTemp = AES.Encrypt(mainTxt.Text, EncryptPassTxt.Text, "textAnalyzer0000");
            EncryptTxt.Text = Encoding.ASCII.GetString(bTemp, 0, bTemp.Length);

            //Test
            test.Text = AES.Decrypt(EncryptTxt.Text, EncryptPassTxt.Text, "textAnalyzer0000");

        }
    }
}
