using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CopyHistory
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Hook.CreateHook(KeyReaderr);
        }
        
        public static String temp = "";
        void KeyReaderr(IntPtr wParam, IntPtr lParam)
        {
            int key = Marshal.ReadInt32(lParam);

            Hook.VK vk = (Hook.VK)key;
            //MessageBox.Show(vk.ToString());
            //

            #region

            if(vk == Hook.VK.VK_LCONTROL)
            {
                temp += "Co_";
            }
            if (vk == Hook.VK.VK_C)
            {
                temp += "_pY";
                if (temp.Length >= 6)
                {

                    if (temp.Substring(temp.Length - 6, 6) == "Co__pY")
                    {
                        if (!listBox.Items.Contains(Clipboard.GetText()))
                        {
                            listBox.Items.Add(Clipboard.GetText());
                        }
                    }
                }
            }
            

           

            #endregion

           // MessageBox.Show(temp);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Hook.DestroyHook();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DialogResult yesNo = MessageBox.Show(Convert.ToString(listBox.Items[listBox.SelectedIndex]), "Copy", MessageBoxButtons.YesNo);
            if (yesNo == DialogResult.Yes)
            {
                Clipboard.SetText(Convert.ToString(listBox.Items[listBox.SelectedIndex]));
            }
            else
            {

            }
        }
    }
}
