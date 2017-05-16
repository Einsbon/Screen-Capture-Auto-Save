using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using Utilities;

namespace Screen_Capture_Auto_Save
{
    public partial class Form1 : Form
    {
        bool korean = Properties.Settings.Default.boolKorean;
        string filePath = Properties.Settings.Default.strPath;
        bool multiScreen = Properties.Settings.Default.boolMultiScr;
        bool shift = Properties.Settings.Default.boolShift;

        globalKeyboardHook gkh = new globalKeyboardHook();
        globalKeyboardHook gkhShift = new globalKeyboardHook();

        public Form1()
        {
            InitializeComponent();
            gkh.HookedKeys.Add(Keys.PrintScreen);
            gkh.KeyDown += new KeyEventHandler(gkh_KeyDown);

            gkhShift.HookedKeys.Add(Keys.RShiftKey);
            gkhShift.HookedKeys.Add(Keys.LShiftKey);
            gkhShift.KeyDown += new KeyEventHandler(gkhP_KeyDown);
            gkhShift.KeyUp += new KeyEventHandler(gkhP_KeyUp);

            radioButton2.Checked = Properties.Settings.Default.boolShift;
            radioButton1.Checked = !Properties.Settings.Default.boolShift;

            korean = Properties.Settings.Default.boolKorean;
            checkMulti.Checked = multiScreen;

            if (!korean)
            {
                btnManual.Text = "Manual";
                btnOpenPath.Text = "Open save location";
                btnPath.Text = "Change save location";
                btnTray.Text = "Show on tray icon";
                checkMulti.Text = "Capture Multi Screen";
                lblInform.Text = "Press 'left Shift + PrintScreen' buttons to Capture and Save";
                lblPath.Text = "Save location : " + filePath;
                label1.Text = "Developer's blog :\r\nE-mail address:\r\nGitHub address :";
                radioButton1.Text = "PrintScreen to capture";
                radioButton2.Text = "Shift + PrintScreen to capture";
                lblPath.Text = "Save location : " + filePath;
                if (radioButton2.Checked)
                {
                    if (korean)
                    {
                        lblInform.Text = "Shift + PrintScreen 버튼을 누르면 화면이 저장됩니다.";
                    }
                    else
                    {
                        lblInform.Text = "Press 'Shift + PrintScreen' buttons to Capture and Save";
                    }
                }
                else
                {
                    if (korean)
                    {
                        lblInform.Text = "PrintScreen 버튼을 누르면 화면이 저장됩니다.";
                    }
                    else
                    {
                        lblInform.Text = "Press PrintScreen buttons to Capture and Save";
                    }
                }
                label1.Left = 720;
            }
            else
            {
                btnManual.Text = "설명서";
                btnOpenPath.Text = "저장 폴더 열기";
                btnPath.Text = "저장 경로 설정";
                btnTray.Text = "트레이 아이콘에 표시";
                checkMulti.Text = "여러 모니터 모두 캡쳐";
                lblInform.Text = "왼쪽 Shift + PrintScreen 버튼을 누르면 화면이 저장 됩니다.";
                lblPath.Text = "저장 경로 : " + filePath;
                label1.Text = "개발자 블로그 :\r\n이메일 주소 :\r\nGitHub 주소 :";
                radioButton1.Text = "PrintScreen 으로 캡쳐";
                radioButton2.Text = "Shift + PrintScreen 으로 캡쳐";
                lblPath.Text = "저장 경로 : " + filePath;
                if (radioButton2.Checked)
                {
                    if (korean)
                    {
                        lblInform.Text = "Shift + PrintScreen 버튼을 누르면 화면이 저장됩니다.";
                    }
                    else
                    {
                        lblInform.Text = "Press 'Shift + PrintScreen' buttons to Capture and Save";
                    }
                }
                else
                {
                    if (korean)
                    {
                        lblInform.Text = "PrintScreen 버튼을 누르면 화면이 저장됩니다.";
                    }
                    else
                    {
                        lblInform.Text = "Press PrintScreen buttons to Capture and Save";
                    }
                }
                label1.Left = 780;
            }
        }

        private void gkhP_KeyUp(object sender, KeyEventArgs e)
        {
            shiftPressed = false;
        }
        bool shiftPressed = false;

        private void gkhP_KeyDown(object sender, KeyEventArgs e)
        {
            shiftPressed = true;
        }

        class Screencapture
        {
            //캡쳐
            public static void Capture(string path1, bool multiScr)
            {
                if (!multiScr)
                {
                    Bitmap bitmap = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
                    Graphics graphics = Graphics.FromImage(bitmap);
                    graphics.CopyFromScreen(0, 0, 0, 0, bitmap.Size);
                    string fileName = path1 + "\\" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss");
                    string finalName = fileName;
                    if (System.IO.File.Exists(fileName + ".png"))
                    {
                        int count = 1;
                        while (System.IO.File.Exists(finalName + ".png"))
                        {
                            finalName = fileName + "-" + count++;
                        }
                    }
                    bitmap.Save(finalName + ".png", ImageFormat.Png);
                    graphics.Dispose();//메모리 정리
                    bitmap.Dispose();//메모리 정리
                }
                else
                {
                    Screen[] screens = Screen.AllScreens;
                    int screensConunt = screens.Length;

                    for (int scrNum = 0; scrNum < screensConunt; scrNum++)
                    {
                        Bitmap bitmap = new Bitmap(screens[scrNum].Bounds.Width, screens[scrNum].Bounds.Height);
                        Graphics graphics = Graphics.FromImage(bitmap);
                        graphics.CopyFromScreen(screens[scrNum].Bounds.X, screens[scrNum].Bounds.Y, 0, 0, bitmap.Size, CopyPixelOperation.SourceCopy);
                        string fileName = path1 + "\\" + DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")+ "_monitorNo" + scrNum;
                        string finalName = fileName;
                        if (System.IO.File.Exists(fileName + ".png"))
                        {
                            int count = 1;
                            while (System.IO.File.Exists(finalName + ".png"))
                            {
                                finalName = fileName + "-" + count++;
                            }
                        }
                        bitmap.Save(finalName + ".png", ImageFormat.Png);
                        graphics.Dispose();//메모리 정리
                        bitmap.Dispose();//메모리 정리
                    }
                }
            }
        }

        //버튼: 트레이 아이콘에 표시
        private void btnTray_Click(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true; // tray icon 표시
            this.Hide();//이 창 숨기기
            this.ShowInTaskbar = false;//작업 표시줄에서도 안보이기
        }
        //버튼: 저장 경로 설정
        private void btnPath_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filePath = this.folderBrowserDialog1.SelectedPath;//filePath에 경로 저장
            }

            if (korean)
            {
                lblPath.Text = "저장 경로 : " + filePath;
            }
            else
            {
                lblPath.Text = "Save location : " + filePath;
            }
        }
        //버튼: 저장 경로 열기
        private void btnOpenPath_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(filePath);
        }
        //프린트스크린 키 이벤트
        void gkh_KeyDown(object sender, KeyEventArgs e)
        {
            if (radioButton1.Checked)
            {
                Screencapture.Capture(filePath, checkMulti.Checked);
            }
            else
            {
                if (shiftPressed)
                {
                    Screencapture.Capture(filePath, checkMulti.Checked);
                }
            }
        }

        //버튼: 설명서
        private void btnManual_Click(object sender, EventArgs e)
        {
            if (korean)
            {
                MessageBox.Show("스크린 캡쳐 후 자동으로 저장해주는 프로그램입니다.\r\n\r\n" +
                "왼쪽 Shift + PrintScreen 버튼을 누르면 설정한 경로 속에 자동 저장 됩니다.\r\n\r\n" +
                "이 프로그램은 켜져있는 동안 작동하며 '창 숨기기' 버튼을 누르면 창이 사라집니다.\r\n\r\n" +
                "트레이 아이콘을 클릭 하면 창이 다시 나타납니다.\r\n\r\n " +
                "혹시 오류나 개선해야될 점이 있으면 개발자 이메일로 보내주시면 감사합니다.^_^");
            }
            else
            {
                MessageBox.Show("press 'P + PrintScreen' button to capture and save.\r\n\r\n" +
                    "'Show on tray icon' button will hide this window and show Tray Icon\r\n\r\n" +
                    "click the tray icon to show hided window.\r\n\r\n" +
                    "This program olny works while not closed.\r\n\r\n" +
                    "If you see troubles on this program, please send an e-mail to me");
            }
        }
        //트레이 버튼: 트레이 아이콘 더블클릭 시
        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
        }

        //언어 설정
        private void btnLang_Click(object sender, EventArgs e)
        {
            korean = !korean;
            if (!korean)
            {
                btnManual.Text = "Manual";
                btnOpenPath.Text = "Open save location";
                btnPath.Text = "Change save location";
                btnTray.Text = "Show on tray icon";
                checkMulti.Text = "Capture Multi Screen";
                lblInform.Text = "Press 'left Shift + PrintScreen' buttons to Capture and Save";
                lblPath.Text = "Save location : " + filePath;
                label1.Text = "Developer's blog :\r\nE-mail address:\r\nGitHub address :";
                radioButton1.Text = "PrintScreen to capture";
                radioButton2.Text = "Shift + PrintScreen to capture";
                if (radioButton2.Checked)
                {
                    if (korean)
                    {
                        lblInform.Text = "Shift + PrintScreen 버튼을 누르면 화면이 저장됩니다.";
                    }
                    else
                    {
                        lblInform.Text = "Press 'Shift + PrintScreen' buttons to Capture and Save";
                    }
                }
                else
                {
                    if (korean)
                    {
                        lblInform.Text = "PrintScreen 버튼을 누르면 화면이 저장됩니다.";
                    }
                    else
                    {
                        lblInform.Text = "Press PrintScreen buttons to Capture and Save";
                    }
                }
                label1.Left = 720;
            }
            else
            {
                btnManual.Text = "설명서";
                btnOpenPath.Text = "저장 폴더 열기";
                btnPath.Text = "저장 경로 설정";
                btnTray.Text = "트레이 아이콘에 표시";
                checkMulti.Text = "여러 모니터 모두 캡쳐";
                lblInform.Text = "왼쪽 Shift + PrintScreen 버튼을 누르면 화면이 저장 됩니다.";
                lblPath.Text = "저장 경로 : " + filePath;
                label1.Text = "개발자 블로그 :\r\n이메일 주소 :\r\nGitHub 주소 :";
                radioButton1.Text = "PrintScreen 으로 캡쳐";
                radioButton2.Text = "Shift + PrintScreen 으로 캡쳐";
                if (radioButton2.Checked)
                {
                    if (korean)
                    {
                        lblInform.Text = "Shift + PrintScreen 버튼을 누르면 화면이 저장됩니다.";
                    }
                    else
                    {
                        lblInform.Text = "Press 'Shift + PrintScreen' buttons to Capture and Save";
                    }
                }
                else
                {
                    if (korean)
                    {
                        lblInform.Text = "PrintScreen 버튼을 누르면 화면이 저장됩니다.";
                    }
                    else
                    {
                        lblInform.Text = "Press PrintScreen buttons to Capture and Save";
                    }
                }
                label1.Left = 780;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://blog.naver.com/einsbon");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Einsbon");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.boolKorean = korean;
            Properties.Settings.Default.boolMultiScr = checkMulti.Checked;
            Properties.Settings.Default.strPath = filePath;
            Properties.Settings.Default.boolShift = radioButton2.Checked;
            Properties.Settings.Default.Save();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                if (korean)
                {
                    lblInform.Text = "Shift + PrintScreen 버튼을 누르면 화면이 저장됩니다.";
                }
                else
                {
                    lblInform.Text = "Press 'Shift + PrintScreen' buttons to Capture and Save";
                }
            }
            else
            {
                if (korean)
                {
                    lblInform.Text = "PrintScreen 버튼을 누르면 화면이 저장됩니다.";
                }
                else
                {
                    lblInform.Text = "Press PrintScreen buttons to Capture and Save";
                }
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            notifyIcon1.Visible = false;
            this.Show();
            this.ShowInTaskbar = true;
        }
    }
}
