namespace Idnaf.UARTTerminal
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.richTextBoxUART = new System.Windows.Forms.RichTextBox();
            this.contextMenuStripRTB = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.smallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mediumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBoxCOM = new System.Windows.Forms.ComboBox();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.buttonLog = new System.Windows.Forms.Button();
            this.textBoxIn = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.serialPortUART = new System.IO.Ports.SerialPort(this.components);
            this.comboBoxSpeed = new System.Windows.Forms.ComboBox();
            this.checkBoxHexOut = new System.Windows.Forms.CheckBox();
            this.checkBoxHexIn = new System.Windows.Forms.CheckBox();
            this.labelFilePath = new System.Windows.Forms.Label();
            this.toolTipForForm = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxCR = new System.Windows.Forms.CheckBox();
            this.checkBoxAppend = new System.Windows.Forms.CheckBox();
            this.contextMenuStripRTB.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxUART
            // 
            this.richTextBoxUART.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBoxUART.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBoxUART.ContextMenuStrip = this.contextMenuStripRTB;
            this.richTextBoxUART.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxUART.Location = new System.Drawing.Point(2, 1);
            this.richTextBoxUART.Name = "richTextBoxUART";
            this.richTextBoxUART.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.richTextBoxUART.Size = new System.Drawing.Size(817, 254);
            this.richTextBoxUART.TabIndex = 0;
            this.richTextBoxUART.Text = "";
            // 
            // contextMenuStripRTB
            // 
            this.contextMenuStripRTB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem,
            this.fontToolStripMenuItem});
            this.contextMenuStripRTB.Name = "contextMenuStripRTB";
            this.contextMenuStripRTB.Size = new System.Drawing.Size(104, 142);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.clearToolStripMenuItem.Text = "Clear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(100, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.smallToolStripMenuItem,
            this.mediumToolStripMenuItem,
            this.bigToolStripMenuItem});
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.fontToolStripMenuItem.Text = "Font";
            // 
            // smallToolStripMenuItem
            // 
            this.smallToolStripMenuItem.Name = "smallToolStripMenuItem";
            this.smallToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.smallToolStripMenuItem.Text = "Small";
            this.smallToolStripMenuItem.Click += new System.EventHandler(this.smallToolStripMenuItem_Click);
            // 
            // mediumToolStripMenuItem
            // 
            this.mediumToolStripMenuItem.Name = "mediumToolStripMenuItem";
            this.mediumToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.mediumToolStripMenuItem.Text = "Medium";
            this.mediumToolStripMenuItem.Click += new System.EventHandler(this.mediumToolStripMenuItem_Click);
            // 
            // bigToolStripMenuItem
            // 
            this.bigToolStripMenuItem.Name = "bigToolStripMenuItem";
            this.bigToolStripMenuItem.Size = new System.Drawing.Size(110, 22);
            this.bigToolStripMenuItem.Text = "Big";
            this.bigToolStripMenuItem.Click += new System.EventHandler(this.bigToolStripMenuItem_Click);
            // 
            // comboBoxCOM
            // 
            this.comboBoxCOM.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxCOM.FormattingEnabled = true;
            this.comboBoxCOM.Location = new System.Drawing.Point(2, 261);
            this.comboBoxCOM.Name = "comboBoxCOM";
            this.comboBoxCOM.Size = new System.Drawing.Size(99, 21);
            this.comboBoxCOM.Sorted = true;
            this.comboBoxCOM.TabIndex = 1;
            this.toolTipForForm.SetToolTip(this.comboBoxCOM, "Select COM port");
            this.comboBoxCOM.Click += new System.EventHandler(this.comboBoxCOM_Click);
            // 
            // buttonConnect
            // 
            this.buttonConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonConnect.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonConnect.Location = new System.Drawing.Point(107, 261);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(48, 22);
            this.buttonConnect.TabIndex = 2;
            this.buttonConnect.Text = "Open";
            this.toolTipForForm.SetToolTip(this.buttonConnect, "Open selected COM port");
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // buttonLog
            // 
            this.buttonLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonLog.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonLog.Location = new System.Drawing.Point(589, 261);
            this.buttonLog.Name = "buttonLog";
            this.buttonLog.Size = new System.Drawing.Size(48, 22);
            this.buttonLog.TabIndex = 3;
            this.buttonLog.Text = "Log";
            this.toolTipForForm.SetToolTip(this.buttonLog, "Log data received\r\nPlease be reminded that the log may contains unprintable chara" +
                    "cters");
            this.buttonLog.UseVisualStyleBackColor = true;
            this.buttonLog.Click += new System.EventHandler(this.buttonLog_Click);
            // 
            // textBoxIn
            // 
            this.textBoxIn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxIn.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxIn.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxIn.Location = new System.Drawing.Point(107, 288);
            this.textBoxIn.Name = "textBoxIn";
            this.textBoxIn.Size = new System.Drawing.Size(662, 19);
            this.textBoxIn.TabIndex = 4;
            this.textBoxIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIn_KeyPress);
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSend.Location = new System.Drawing.Point(775, 284);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(44, 23);
            this.buttonSend.TabIndex = 5;
            this.buttonSend.Text = "Send";
            this.toolTipForForm.SetToolTip(this.buttonSend, "Send data");
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // serialPortUART
            // 
            this.serialPortUART.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortUART_DataReceived);
            // 
            // comboBoxSpeed
            // 
            this.comboBoxSpeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.comboBoxSpeed.FormattingEnabled = true;
            this.comboBoxSpeed.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "28800",
            "38400",
            "57600",
            "115200",
            "230400"});
            this.comboBoxSpeed.Location = new System.Drawing.Point(2, 285);
            this.comboBoxSpeed.Name = "comboBoxSpeed";
            this.comboBoxSpeed.Size = new System.Drawing.Size(99, 21);
            this.comboBoxSpeed.TabIndex = 6;
            this.toolTipForForm.SetToolTip(this.comboBoxSpeed, "Select baudrate");
            // 
            // checkBoxHexOut
            // 
            this.checkBoxHexOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxHexOut.AutoSize = true;
            this.checkBoxHexOut.Location = new System.Drawing.Point(161, 263);
            this.checkBoxHexOut.Name = "checkBoxHexOut";
            this.checkBoxHexOut.Size = new System.Drawing.Size(122, 17);
            this.checkBoxHexOut.TabIndex = 7;
            this.checkBoxHexOut.Text = "Hexadecimal Output";
            this.toolTipForForm.SetToolTip(this.checkBoxHexOut, "Make output in hexadecimal view");
            this.checkBoxHexOut.UseVisualStyleBackColor = true;
            this.checkBoxHexOut.Click += new System.EventHandler(this.checkBoxHexOut_Click);
            // 
            // checkBoxHexIn
            // 
            this.checkBoxHexIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxHexIn.AutoSize = true;
            this.checkBoxHexIn.Location = new System.Drawing.Point(290, 263);
            this.checkBoxHexIn.Name = "checkBoxHexIn";
            this.checkBoxHexIn.Size = new System.Drawing.Size(114, 17);
            this.checkBoxHexIn.TabIndex = 8;
            this.checkBoxHexIn.Text = "Hexadecimal Input";
            this.toolTipForForm.SetToolTip(this.checkBoxHexIn, "Make input in hexadecimal format");
            this.checkBoxHexIn.UseVisualStyleBackColor = true;
            this.checkBoxHexIn.Click += new System.EventHandler(this.checkBoxHexIn_Click);
            // 
            // labelFilePath
            // 
            this.labelFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelFilePath.AutoSize = true;
            this.labelFilePath.Location = new System.Drawing.Point(646, 267);
            this.labelFilePath.Name = "labelFilePath";
            this.labelFilePath.Size = new System.Drawing.Size(31, 13);
            this.labelFilePath.TabIndex = 9;
            this.labelFilePath.Text = "Log :";
            // 
            // toolTipForForm
            // 
            this.toolTipForForm.IsBalloon = true;
            this.toolTipForForm.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTipForForm.ToolTipTitle = "Information";
            // 
            // checkBoxCR
            // 
            this.checkBoxCR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxCR.AutoSize = true;
            this.checkBoxCR.Location = new System.Drawing.Point(410, 263);
            this.checkBoxCR.Name = "checkBoxCR";
            this.checkBoxCR.Size = new System.Drawing.Size(85, 17);
            this.checkBoxCR.TabIndex = 10;
            this.checkBoxCR.Text = "CR=Newline";
            this.toolTipForForm.SetToolTip(this.checkBoxCR, "Make CR (0x0D) as new line");
            this.checkBoxCR.UseVisualStyleBackColor = true;
            // 
            // checkBoxAppend
            // 
            this.checkBoxAppend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkBoxAppend.AutoSize = true;
            this.checkBoxAppend.Checked = true;
            this.checkBoxAppend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAppend.Location = new System.Drawing.Point(501, 263);
            this.checkBoxAppend.Name = "checkBoxAppend";
            this.checkBoxAppend.Size = new System.Drawing.Size(63, 17);
            this.checkBoxAppend.TabIndex = 11;
            this.checkBoxAppend.Text = "Append";
            this.toolTipForForm.SetToolTip(this.checkBoxAppend, "Append data");
            this.checkBoxAppend.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 307);
            this.Controls.Add(this.checkBoxAppend);
            this.Controls.Add(this.checkBoxCR);
            this.Controls.Add(this.labelFilePath);
            this.Controls.Add(this.checkBoxHexIn);
            this.Controls.Add(this.checkBoxHexOut);
            this.Controls.Add(this.comboBoxSpeed);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxIn);
            this.Controls.Add(this.buttonLog);
            this.Controls.Add(this.buttonConnect);
            this.Controls.Add(this.comboBoxCOM);
            this.Controls.Add(this.richTextBoxUART);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(826, 334);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Idnaf UART Terminal - 3MAR2010";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStripRTB.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxUART;
        private System.Windows.Forms.ComboBox comboBoxCOM;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonLog;
        private System.Windows.Forms.TextBox textBoxIn;
        private System.Windows.Forms.Button buttonSend;
        private System.IO.Ports.SerialPort serialPortUART;
        private System.Windows.Forms.ComboBox comboBoxSpeed;
        private System.Windows.Forms.CheckBox checkBoxHexOut;
        private System.Windows.Forms.CheckBox checkBoxHexIn;
        private System.Windows.Forms.Label labelFilePath;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripRTB;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTipForForm;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem smallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mediumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bigToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxCR;
        private System.Windows.Forms.CheckBox checkBoxAppend;
    }
}

