using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;

namespace Idnaf.UARTTerminal
{
    public partial class MainForm : Form
    {
        private string filePath;
        private delegate void delRTB(string str);
        public MainForm()
        {
            filePath = "";
            InitializeComponent();
        }
        
        private void comboBoxCOM_Click(object sender, EventArgs e)
        {
            comboBoxCOM.Items.Clear();
            string[] strPort = SerialPort.GetPortNames();
            for (int i = 0; i < strPort.Length; i++)
            {
                comboBoxCOM.Items.Add(strPort[i]);
            }
        }
        
        private void buttonConnect_Click(object sender, EventArgs e)
        {
            if (buttonConnect.Text == "Open")
            {
                if (comboBoxCOM.SelectedIndex == -1 || comboBoxSpeed.SelectedIndex == -1)
                {
                    MessageBox.Show("Please select COM port and its corresponded speed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (serialPortUART.IsOpen == true)
                {
                    MessageBox.Show("Could not open COM port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                serialPortUART.BaudRate = Convert.ToInt32(comboBoxSpeed.SelectedItem.ToString());
                serialPortUART.PortName = comboBoxCOM.SelectedItem.ToString();
                try
                {
                    serialPortUART.Open();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Can not open COM port\nError message : " + ex.Message
                        , "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                serialPortUART.DiscardInBuffer();
                serialPortUART.DiscardOutBuffer();
                if (serialPortUART.IsOpen == false)
                {
                    MessageBox.Show("Could not open COM port", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                buttonConnect.Text = "Close";
            }
            else
            {
                if (serialPortUART.IsOpen)
                {
                    serialPortUART.Close();
                }
                else
                {
                    MessageBox.Show("Nothing to disconnect", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                buttonConnect.Text = "Open";
            }
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Title = "Save log";
            sfd.Filter = "Text file (*.txt)|*.txt|Log file (*.log)|*.log|Others (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                filePath = sfd.FileName;
                labelFilePath.Text = "Log : " + Path.GetFileName(sfd.FileName);
                
            }
        }
        private void InsertToRTB(string str)
        {
            if (checkBoxAppend.Checked)
            {
                richTextBoxUART.AppendText(str);
                richTextBoxUART.Select(richTextBoxUART.TextLength - 1, 1);
                richTextBoxUART.ScrollToCaret();                
            }
            else
            {
                richTextBoxUART.Text = str;
            }
        }
        private void serialPortUART_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            StringBuilder strTemp = new StringBuilder();
            byte[] dataBuffer = new byte[serialPortUART.ReadBufferSize];
            int bufferLen = serialPortUART.BytesToRead;
            FileStream fs = null;

            serialPortUART.Read(dataBuffer, 0, bufferLen);
            if (filePath != "")
            {
                fs = new FileStream(filePath, FileMode.Append, FileAccess.Write,FileShare.ReadWrite);
                fs.Write(dataBuffer, 0, bufferLen);
                fs.Close();                
            }
            
            if (checkBoxHexOut.Checked)
            {
                if (checkBoxCR.Checked)
                {
                    for (int i = 0; i < bufferLen; i++)
                    {                        
                        strTemp.Append(dataBuffer[i].ToString("X02"));
                        if (dataBuffer[i] == 0x0D)
                        {
                            strTemp.Append(Environment.NewLine);
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < bufferLen; i++)
                    {
                        strTemp.Append(dataBuffer[i].ToString("X02"));
                    }
                }
            }
            else            
            {
                if (checkBoxCR.Checked)
                {
                    for (int i = 0; i < bufferLen; i++)
                    {
                        if (dataBuffer[i] == 0x0D)
                        {
                            strTemp.Append(Environment.NewLine);
                            continue;
                        }
                        strTemp.Append(Convert.ToChar(dataBuffer[i]));
                    }
                }
                else
                {
                    for (int i = 0; i < bufferLen; i++)
                    {
                        strTemp.Append(Convert.ToChar(dataBuffer[i]));
                    }
                }
            }
            //delRTB delrtb = new delRTB(InsertToRTB);
            //this.Invoke(delrtb, strTemp.ToString());
            this.BeginInvoke(new EventHandler(delegate
            {
                InsertToRTB(strTemp.ToString());
            }));
            Application.DoEvents();
            //richTextBoxUART.AppendText(strTemp.ToString());
            //richTextBoxUART.Select(richTextBoxUART.TextLength - 1, 1);
            //richTextBoxUART.ScrollToCaret();            
        }

        private void checkBoxHexOut_Click(object sender, EventArgs e)
        {
            richTextBoxUART.Clear();
        }

        private void checkBoxHexIn_Click(object sender, EventArgs e)
        {
            textBoxIn.Clear();
        }
        /// <summary>
        /// Convert from text of APDU format to array
        /// </summary>
        /// <param name="strTextIn"></param>
        /// <returns></returns>
        /// 
        private char[] LTHex = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
        public byte[] TxtToArray(string strTextIn)
        {
            string strTemp;
            byte[] bATR;

            if (strTextIn != "")
            {
                // Sanitation
                strTemp = strTextIn.Replace(" ", "");
                bATR = new byte[strTemp.Length / 2];
                strTemp = strTemp.ToUpper();


                for (byte i = 0; i < (strTemp.Length / 2); i++)
                {
                    for (byte y = 0; y < LTHex.Length; y++)
                    {
                        if (strTemp[2 * i] == LTHex[y])
                        {
                            bATR[i] = y;
                            continue;
                        }
                    }

                    for (byte y = 0; y < LTHex.Length; y++)
                    {

                        if (strTemp[2 * i + 1] == LTHex[y])
                        {
                            bATR[i] <<= 4;
                            bATR[i] += y;
                            continue;
                        }
                    }
                }
                return bATR;
            }
            return bATR = null;
        }
        private void SendUART()
        {
            if (checkBoxHexIn.Checked)
            {
                // Hex mode
                byte[] dataToBeSent = TxtToArray(textBoxIn.Text);
                if (serialPortUART.IsOpen)
                {
                    serialPortUART.Write(dataToBeSent, 0, dataToBeSent.Length);
                    textBoxIn.Text = "";
                }
                else
                {
                    MessageBox.Show("COM port is closed / disconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                // ASCII mode
                if (serialPortUART.IsOpen)
                {
                    serialPortUART.Write(textBoxIn.Text);
                    textBoxIn.Clear();
                }
                else
                {
                    MessageBox.Show("COM port is closed / disconnected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void buttonSend_Click(object sender, EventArgs e)
        {
            SendUART();
        }
        private void textBoxIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                SendUART();
            }
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxUART.Text != "")
                Clipboard.SetText(richTextBoxUART.Text);
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxUART.Text = Clipboard.GetText();
        }
        
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (richTextBoxUART.Text != "")
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save log";
                sfd.Filter = "Text file (*.txt)|*.txt|Log file (*.log)|*.log|Others (*.*)|*.*";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    richTextBoxUART.SaveFile(sfd.FileName,RichTextBoxStreamType.PlainText);
                }                
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.Show();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBoxUART.Clear();
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.richTextBoxUART.Font = new System.Drawing.Font("Lucida Console", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void mediumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxUART.Font = new System.Drawing.Font("Lucida Console", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void bigToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBoxUART.Font = new System.Drawing.Font("Lucida Console", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPortUART.IsOpen)
            {
                serialPortUART.Close();
            }
        }
    }
}