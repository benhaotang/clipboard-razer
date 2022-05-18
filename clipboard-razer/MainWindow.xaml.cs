using System.Windows;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SharpBlade;
using SharpBlade.Native;
using SharpBlade.Razer;



namespace RazerClipboard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static bool isplus = false;
        public static bool isremove = false;
        public static string content1 = " ";
        public static string content2 = " ";
        public static string content3 = " ";
        public static string content4 = " ";
        public static string content5 = " ";
        public static string content6 = " ";
        public static string content7 = " ";
        public static string content8 = " ";
        public MainWindow()
        {
            InitializeComponent();
            ISwitchblade sbInstance = Switchblade.Instance;
            sbInstance.AppEvent += OnAppEvent;
            sbInstance.Touchpad.Set(this);
            if (!File.Exists(@"Default/1.txt"))
            {
                FileStream fs = File.Create(@"Default/1.txt");
                fs.Close();
            }
            if (!File.Exists(@"Default/2.txt"))
            {
                FileStream fs = File.Create(@"Default/2.txt");
                fs.Close();
            }
            if (!File.Exists(@"Default/3.txt"))
            {
                FileStream fs = File.Create(@"Default/3.txt");
                fs.Close();
            }
            if (!File.Exists(@"Default/4.txt"))
            {
                FileStream fs = File.Create(@"Default/4.txt");
                fs.Close();
            }
            if (!File.Exists(@"Default/5.txt"))
            {
                FileStream fs = File.Create(@"Default/5.txt");
                fs.Close();
            }
            if (!File.Exists(@"Default/6.txt"))
            {
                FileStream fs = File.Create(@"Default/6.txt");
                fs.Close();
            }
            if (!File.Exists(@"Default/7.txt"))
            {
                FileStream fs = File.Create(@"Default/7.txt");
                fs.Close();
            }
            if (!File.Exists(@"Default/8.txt"))
            {
                FileStream fs = File.Create(@"Default/8.txt");
                fs.Close();
            }
            content1 = File.ReadAllText(@"Default/1.txt");
            text1.Text = content1;
            content2 = File.ReadAllText(@"Default/2.txt");
            text2.Text = content2;
            content3 = File.ReadAllText(@"Default/3.txt");
            text3.Text = content3;
            content4 = File.ReadAllText(@"Default/4.txt");
            text4.Text = content4;
            content5 = File.ReadAllText(@"Default/5.txt");
            text5.Text = content5;
            content6 = File.ReadAllText(@"Default/6.txt");
            text6.Text = content6;
            content7 = File.ReadAllText(@"Default/7.txt");
            text7.Text = content7;
            content8 = File.ReadAllText(@"Default/8.txt");
            text8.Text = content8;

            sbInstance.DynamicKeys.Enable(DynamicKeyType.DK1, OnonePress, @"Default\Images\k1.png");
            sbInstance.DynamicKeys.Enable(DynamicKeyType.DK2, OntwoPress, @"Default\Images\k2.png");
            sbInstance.DynamicKeys.Enable(DynamicKeyType.DK3, OnthreePress, @"Default\Images\k3.png");
            sbInstance.DynamicKeys.Enable(DynamicKeyType.DK4, OnfourPress, @"Default\Images\k4.png");
            sbInstance.DynamicKeys.Enable(DynamicKeyType.DK5, OnfivePress, @"Default\Images\remove_press.png");
            sbInstance.DynamicKeys.Enable(DynamicKeyType.DK6, OnsixPress, @"Default\Images\k5.png");
            sbInstance.DynamicKeys.Enable(DynamicKeyType.DK7, OnsevenPress, @"Default\Images\k6.png");
            sbInstance.DynamicKeys.Enable(DynamicKeyType.DK8, OneightPress, @"Default\Images\k7.png");
            sbInstance.DynamicKeys.Enable(DynamicKeyType.DK9, OnninePress, @"Default\Images\k8.png");
            sbInstance.DynamicKeys.Enable(DynamicKeyType.DK10, OntenPress, @"Default\Images\plus_press.png");
        }

        private void OnfivePress(object sender, System.EventArgs e)
        {
            if (isremove == true)
            {
                ISwitchblade sbInstance = Switchblade.Instance;
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK1, OnonePress, @"Default\Images\k1.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK2, OntwoPress, @"Default\Images\k2.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK3, OnthreePress, @"Default\Images\k3.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK4, OnfourPress, @"Default\Images\k4.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK5, OnfivePress, @"Default\Images\remove_press.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK6, OnsixPress, @"Default\Images\k5.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK7, OnsevenPress, @"Default\Images\k6.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK8, OneightPress, @"Default\Images\k7.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK9, OnninePress, @"Default\Images\k8.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK10, OntenPress, @"Default\Images\plus_press.png", true);
                isremove = false;
            }
            else
            {
                ISwitchblade sbInstance = Switchblade.Instance;
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK1, OnonePress, @"Default\Images\k1.png",true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK2, OntwoPress, @"Default\Images\k2.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK3, OnthreePress, @"Default\Images\k3.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK4, OnfourPress, @"Default\Images\k4.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK5, OnfivePress, @"Default\Images\remove.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK6, OnsixPress, @"Default\Images\k5.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK7, OnsevenPress, @"Default\Images\k6.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK8, OneightPress, @"Default\Images\k7.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK9, OnninePress, @"Default\Images\k8.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK10, Quit, @"Default\Images\quit.png", true);
                isremove =true;
                isplus = false;
            }
        }

        private void Quit(object sender, System.EventArgs e)
        {
            Application.Current.Shutdown();
        }

            private void OntenPress(object sender, System.EventArgs e)
        {
            if (isplus == true)
            {
                ISwitchblade sbInstance = Switchblade.Instance;
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK1, OnonePress, @"Default\Images\k1.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK2, OntwoPress, @"Default\Images\k2.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK3, OnthreePress, @"Default\Images\k3.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK4, OnfourPress, @"Default\Images\k4.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK5, OnfivePress, @"Default\Images\remove_press.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK6, OnsixPress, @"Default\Images\k5.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK7, OnsevenPress, @"Default\Images\k6.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK8, OneightPress, @"Default\Images\k7.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK9, OnninePress, @"Default\Images\k8.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK10, OntenPress, @"Default\Images\plus_press.png", true);
                isplus = false;
            }
            else
            {
                ISwitchblade sbInstance = Switchblade.Instance;
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK1, OnonePress, @"Default\Images\k1.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK2, OntwoPress, @"Default\Images\k2.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK3, OnthreePress, @"Default\Images\k3.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK4, OnfourPress, @"Default\Images\k4.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK5, OnfivePress, @"Default\Images\remove_press.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK6, OnsixPress, @"Default\Images\k5.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK7, OnsevenPress, @"Default\Images\k6.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK8, OneightPress, @"Default\Images\k7.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK9, OnninePress, @"Default\Images\k8.png", true);
                sbInstance.DynamicKeys.Enable(DynamicKeyType.DK10, OntenPress, @"Default\Images\plus.png", true);
                isplus = true;
                isremove = false;
            }
        }

        private void OnninePress(object sender, System.EventArgs e)
        {
            string currentt = "";
            int key = 8;
            if (isplus)
            {
                currentt = GetStringData();
                ShowInText(key, currentt);
            }
            else if (isremove)
            {
                ShowInText(key, currentt);
            }
            else
            {
                currentt = content8;
                AddClip(key);
                System.Windows.Forms.SendKeys.SendWait("^v");
            }
            content8 = currentt;
            StreamWriter sw = File.AppendText(@"Default/8.txt");
            sw.Write(content8);
            sw.Flush();
            sw.Close();
        }

        private void OneightPress(object sender, System.EventArgs e)
        {
            string currentt = "";
            int key = 7;
            if (isplus)
            {
                currentt = GetStringData();
                ShowInText(key, currentt);
            }
            else if (isremove)
            {
                ShowInText(key, currentt);
            }
            else
            {
                currentt = content7;
                AddClip(key);
                System.Windows.Forms.SendKeys.SendWait("^v");
            }
            content7 = currentt;
            StreamWriter sw = File.AppendText(@"Default/7.txt");
            sw.Write(content7);
            sw.Flush();
            sw.Close();
        }

        private void OnsevenPress(object sender, System.EventArgs e)
        {
            string currentt = "";
            int key = 6;
            if (isplus)
            {
                currentt = GetStringData();
                ShowInText(key, currentt);
            }
            else if (isremove)
            {
                ShowInText(key, currentt);
            }
            else
            {
                currentt = content6;
                AddClip(key);
                System.Windows.Forms.SendKeys.SendWait("^v");
            }
            content6 = currentt;
            StreamWriter sw = File.AppendText(@"Default/6.txt");
            sw.Write(content6);
            sw.Flush();
            sw.Close();
        }

        private void OnsixPress(object sender, System.EventArgs e)
        {
            string currentt = "";
            int key = 5;
            if (isplus)
            {
                currentt = GetStringData();
                ShowInText(key, currentt);
            }
            else if (isremove)
            {
                ShowInText(key, currentt);
            }
            else
            {
                currentt = content5;
                AddClip(key);
                System.Windows.Forms.SendKeys.SendWait("^v");
            }
            content5 = currentt;
            StreamWriter sw = File.AppendText(@"Default/5.txt");
            sw.Write(content5);
            sw.Flush();
            sw.Close();
        }

        private void OnfourPress(object sender, System.EventArgs e)
        {
            string currentt = "";
            int key = 4;
            if (isplus)
            {
                currentt = GetStringData();
                ShowInText(key, currentt);
            }
            else if (isremove)
            {
                ShowInText(key, currentt);
            }
            else
            {
                currentt = content4;
                AddClip(key);
                System.Windows.Forms.SendKeys.SendWait("^v");
            }
            content4 = currentt;
            StreamWriter sw = File.AppendText(@"Default/4.txt");
            sw.Write(content4);
            sw.Flush();
            sw.Close();
        }

        private void OnthreePress(object sender, System.EventArgs e)
        {
            string currentt = "";
            int key = 3;
            if (isplus)
            {
                currentt = GetStringData();
                ShowInText(key, currentt);
            }
            else if (isremove)
            {
                ShowInText(key, currentt);
            }
            else
            {
                currentt = content3;
                AddClip(key);
                System.Windows.Forms.SendKeys.SendWait("^v");
            }
            content3 = currentt;
            StreamWriter sw = File.AppendText(@"Default/3.txt"); 
            sw.Write(content3);
            sw.Flush();
            sw.Close();
        }
       
        private void OntwoPress(object sender, System.EventArgs e)
        {
            string currentt = "";
            int key = 2;
            if (isplus)
            {
                currentt = GetStringData();
                ShowInText(key, currentt);
            }
            else if (isremove)
            {
                ShowInText(key, currentt);
            }
            else
            {
                currentt = content2;
                AddClip(key);
                System.Windows.Forms.SendKeys.SendWait("^v");
            }
            content2 = currentt;
            StreamWriter sw = File.AppendText(@"Default/2.txt");
            sw.Write(content2);
            sw.Flush();
            sw.Close();
        }

        private void OnonePress(object sender, System.EventArgs e)
        {
            string currentt = "";
            int key = 1;
            if (isplus)
            {
                currentt = GetStringData();
                ShowInText(key, currentt);
            }
            else if (isremove)
            {
                ShowInText(key, currentt);
            }
            else
            {
                currentt = content1;
                AddClip(key);
                System.Windows.Forms.SendKeys.SendWait("^v");
            }
            content1 = currentt;
            StreamWriter sw = File.AppendText(@"Default/1.txt"); 
            sw.Write(content1);
            sw.Flush();
            sw.Close();
        }

        public static void AddClip(int num)
        {
            if (num == 1)
            {
                Clipboard.SetDataObject(content1 ?? "");
            }
            else if (num == 2)
            {
                Clipboard.SetDataObject(content2 ?? "");
            }
            else if (num == 3)
            {
                Clipboard.SetDataObject(content3 ?? "");
            }
            else if (num == 4)
            {
                Clipboard.SetDataObject(content4 ?? "");
            }
            else if (num == 5)
            {
                Clipboard.SetDataObject(content5 ?? "");
            }
            else if (num == 6)
            {
                Clipboard.SetDataObject(content6 ?? "");
            }
            else if (num == 7)
            {
                Clipboard.SetDataObject(content7 ?? "");
            }
            else if(num == 8)
            {
                Clipboard.SetDataObject(content8 ?? "");
            }

        }



        private string GetStringData()
        {
            string ret = "";
            System.Windows.IDataObject iData = System.Windows.Clipboard.GetDataObject();
            if (iData.GetDataPresent(System.Windows.DataFormats.Text))
            {
                ret = (string)iData.GetData(System.Windows.DataFormats.Text);
            }
            return ret;
        }
        private void ShowInText(int num,string content)
        {
            if (num == 1) {
                text1.Text = content;
            }
            else if (num == 2)
            {
                text2.Text = content;
            }
            else if (num == 3)
            {
                text3.Text = content;
            }
            else if (num == 4)
            {
                text4.Text = content;
            }
            else if (num == 5)
            {
                text5.Text = content;
            }
            else if (num == 6)
            {
                text6.Text = content;
            }
            else if (num == 7)
            {
                text7.Text = content;
            }
            else if (num == 8)
            {
                text8.Text = content;
            }

        }
        
        void OnAppEvent(object sender, SharpBlade.Events.AppEventEventArgs appEventArgs)
        {
            if (appEventArgs.EventType == AppEventType.Deactivated || appEventArgs.EventType == AppEventType.Close ||
                appEventArgs.EventType == AppEventType.Exit)
            {
                Application.Current.Shutdown();
            }
        }

        
    }
}
