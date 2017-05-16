namespace Screen_Capture_Auto_Save
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnTray = new System.Windows.Forms.Button();
            this.btnOpenPath = new System.Windows.Forms.Button();
            this.btnPath = new System.Windows.Forms.Button();
            this.btnManual = new System.Windows.Forms.Button();
            this.lblVer = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.lblPath = new System.Windows.Forms.Label();
            this.lblInform = new System.Windows.Forms.Label();
            this.checkMulti = new System.Windows.Forms.CheckBox();
            this.btnLang = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // btnTray
            // 
            this.btnTray.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTray.Location = new System.Drawing.Point(12, 136);
            this.btnTray.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnTray.Name = "btnTray";
            this.btnTray.Size = new System.Drawing.Size(201, 27);
            this.btnTray.TabIndex = 1;
            this.btnTray.Text = "트레이 아이콘에 표시";
            this.btnTray.UseVisualStyleBackColor = true;
            this.btnTray.Click += new System.EventHandler(this.btnTray_Click);
            // 
            // btnOpenPath
            // 
            this.btnOpenPath.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenPath.Location = new System.Drawing.Point(12, 101);
            this.btnOpenPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnOpenPath.Name = "btnOpenPath";
            this.btnOpenPath.Size = new System.Drawing.Size(201, 27);
            this.btnOpenPath.TabIndex = 2;
            this.btnOpenPath.Text = "저장 경로 열기";
            this.btnOpenPath.UseVisualStyleBackColor = true;
            this.btnOpenPath.Click += new System.EventHandler(this.btnOpenPath_Click);
            // 
            // btnPath
            // 
            this.btnPath.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPath.Location = new System.Drawing.Point(12, 66);
            this.btnPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnPath.Name = "btnPath";
            this.btnPath.Size = new System.Drawing.Size(201, 27);
            this.btnPath.TabIndex = 3;
            this.btnPath.Text = "저장 경로 설정";
            this.btnPath.UseVisualStyleBackColor = true;
            this.btnPath.Click += new System.EventHandler(this.btnPath_Click);
            // 
            // btnManual
            // 
            this.btnManual.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManual.Location = new System.Drawing.Point(12, 171);
            this.btnManual.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnManual.Name = "btnManual";
            this.btnManual.Size = new System.Drawing.Size(86, 27);
            this.btnManual.TabIndex = 5;
            this.btnManual.Text = "설명서";
            this.btnManual.UseVisualStyleBackColor = true;
            this.btnManual.Click += new System.EventHandler(this.btnManual_Click);
            // 
            // lblVer
            // 
            this.lblVer.AutoSize = true;
            this.lblVer.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVer.Location = new System.Drawing.Point(796, 174);
            this.lblVer.Name = "lblVer";
            this.lblVer.Size = new System.Drawing.Size(117, 19);
            this.lblVer.TabIndex = 6;
            this.lblVer.Text = "Version 0.6c";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // lblPath
            // 
            this.lblPath.AutoSize = true;
            this.lblPath.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPath.Location = new System.Drawing.Point(219, 70);
            this.lblPath.Name = "lblPath";
            this.lblPath.Size = new System.Drawing.Size(0, 19);
            this.lblPath.TabIndex = 7;
            // 
            // lblInform
            // 
            this.lblInform.AutoSize = true;
            this.lblInform.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblInform.Location = new System.Drawing.Point(26, 18);
            this.lblInform.Name = "lblInform";
            this.lblInform.Size = new System.Drawing.Size(0, 19);
            this.lblInform.TabIndex = 8;
            // 
            // checkMulti
            // 
            this.checkMulti.AutoSize = true;
            this.checkMulti.Location = new System.Drawing.Point(362, 170);
            this.checkMulti.Name = "checkMulti";
            this.checkMulti.Size = new System.Drawing.Size(163, 23);
            this.checkMulti.TabIndex = 9;
            this.checkMulti.Text = "여러 모니터 모두 캡쳐";
            this.checkMulti.UseVisualStyleBackColor = true;
            // 
            // btnLang
            // 
            this.btnLang.Location = new System.Drawing.Point(845, 18);
            this.btnLang.Name = "btnLang";
            this.btnLang.Size = new System.Drawing.Size(325, 27);
            this.btnLang.TabIndex = 10;
            this.btnLang.Text = "Change Language ( English / Korean )";
            this.btnLang.UseVisualStyleBackColor = true;
            this.btnLang.Click += new System.EventHandler(this.btnLang_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(780, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 57);
            this.label1.TabIndex = 11;
            this.label1.Text = "개발자 블로그 :\r\n이메일 주소 :\r\nGitHub 주소 :";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(900, 105);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(270, 19);
            this.linkLabel1.TabIndex = 12;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "http://blog.naver.com/einsbon";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(900, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 19);
            this.label2.TabIndex = 13;
            this.label2.Text = "einsbon@gmail.com";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(900, 140);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(243, 19);
            this.linkLabel2.TabIndex = 14;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "https://github.com/Einsbon";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(362, 103);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(192, 23);
            this.radioButton1.TabIndex = 16;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "PrintScreen 으로 캡쳐";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(362, 129);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(264, 23);
            this.radioButton2.TabIndex = 17;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Shift + PrintScreen 으로 캡쳐";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 212);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnLang);
            this.Controls.Add(this.checkMulti);
            this.Controls.Add(this.lblInform);
            this.Controls.Add(this.lblPath);
            this.Controls.Add(this.lblVer);
            this.Controls.Add(this.btnManual);
            this.Controls.Add(this.btnPath);
            this.Controls.Add(this.btnOpenPath);
            this.Controls.Add(this.btnTray);
            this.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "Screen Capture Auto Save";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnTray;
        private System.Windows.Forms.Button btnOpenPath;
        private System.Windows.Forms.Button btnPath;
        private System.Windows.Forms.Button btnManual;
        private System.Windows.Forms.Label lblVer;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label lblPath;
        private System.Windows.Forms.Label lblInform;
        private System.Windows.Forms.CheckBox checkMulti;
        private System.Windows.Forms.Button btnLang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}

