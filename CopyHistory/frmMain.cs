using System;
using System.Collections;
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
        ArrayList cpy = new ArrayList();
        ArrayList obj = new ArrayList();
        public static String temp = "zzzzzzz";
        void KeyReaderr(IntPtr wParam, IntPtr lParam)
        {
            try
            {
                int key = Marshal.ReadInt32(lParam);

                Hook.VK vk = (Hook.VK)key;
                //MessageBox.Show(vk.ToString());
                //

                #region

                if (vk == Hook.VK.VK_LCONTROL || vk == Hook.VK.VK_RCONTROL)
                {
                    temp += "Co_";
                }
                if (vk == Hook.VK.VK_C || vk == Hook.VK.VK_X || vk == Hook.VK.VK_SNAPSHOT)
                {
                    if (temp.Substring(temp.Length - 3, 3) == "Co_") temp += "_pY";
                    if (vk == Hook.VK.VK_SNAPSHOT) temp = temp + "zzzzzzCo__pY";
                    if (temp.Length >= 6)
                    {
                        System.Threading.Thread.Sleep(400);
                        if (temp.Substring(temp.Length - 6, 6) == "Co__pY")
                        {
                            if (!listBox.Items.Contains(Clipboard.GetDataObject()))
                            {
                                string name = "";
                                Image itemimage = null;
                                string itemtext = null;
                                IDataObject data = Clipboard.GetDataObject();
                                obj.Add(data);
                                if (data.GetDataPresent(DataFormats.StringFormat))
                                {
                                    itemtext = Clipboard.GetText();
                                    cpy.Add(itemtext);
                                    listBox.Items.Add(DateTime.Now.ToShortTimeString() + " "+ itemtext);


                                }
                                else
                                {
                                    Bitmap bitmap = (Clipboard.GetData(DataFormats.Bitmap) as Bitmap);
                                    itemimage = bitmap;
                                    cpy.Add(itemimage);
                                    listBox.Items.Add(DateTime.Now.ToShortTimeString() + " " + "Image");
                                }





                            }
                        }
                    }
                }

            }
            catch(Exception a)
            {

            }
           

            #endregion

           // MessageBox.Show(temp);
        }
        bool closing = false;
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closing==false) e.Cancel = true;
            else
            {   }
            this.Hide();
            this.Visible = false;

            
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string st = Convert.ToString(listBox.Items[listBox.SelectedIndex]);
            DialogResult yesNo = MessageBox.Show(st.Substring(6, st.Length-6), "Copy", MessageBoxButtons.YesNoCancel);
            if (yesNo == DialogResult.Yes)
            {
                if(Convert.ToString(st.Substring(6, st.Length - 6)) == "Image")
                {
                    Clipboard.SetData(DataFormats.Bitmap, cpy[listBox.SelectedIndex]);
                }
                else
                {
                    
                    Clipboard.SetText(st.Substring(5, st.Length-5));

                }
            }
            else
            {

            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void Open_Click(object sender, EventArgs e)
        {
            this.Show();
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
        }

        private void Close_Click(object sender, EventArgs e)
        {
            closing = true;
            Application.Exit();
        }
    }
}
