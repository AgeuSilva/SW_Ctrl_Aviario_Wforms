using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace Trabalho_ControleAviário
{
    public partial class Monitora_Aviario : Form
    {
        SerialPort SerialComPort = new SerialPort(); //criei o objeto SerialComPort - hipe
        public delegate void Fdelegate(string a);
        delegate void funcaoRecepcao();

        bool bTrata_RecepcaoSerial = false;

        int iVarSetpointTemperatura = 25;
        int iVarSetpointUmidade = 45;
        int iVarTemperatura = 27;
        int iVarUmidade = 47;
        int iVarTempoGraf = 0;

        public Monitora_Aviario()
        {
            InitializeComponent();

            SerialComPort.DataReceived += new SerialDataReceivedEventHandler(SerialComPort_DataReceived);
            Timer1.Tick += new EventHandler(Timer1_Tick);
            Timer1.Enabled = true;

            buttonDesconectaPlaca.Enabled = false;
        }

        private void Timer1_Tick(object Sender, EventArgs e) // Timer de 500ms
        {
            labelTemp.Text = iVarTemperatura.ToString();
            labelUmi.Text = iVarUmidade.ToString();

            if (chartTempUmi.Series[2].Points.Count > 80 && chartTempUmi.Series[3].Points.Count > 80)
            {
                chartTempUmi.Series[0].Points.RemoveAt(0);
                chartTempUmi.Series[1].Points.RemoveAt(0);
                chartTempUmi.Series[2].Points.RemoveAt(0);
                chartTempUmi.Series[3].Points.RemoveAt(0);
                chartTempUmi.Update();
            }

            chartTempUmi.Series[0].Points.AddXY(iVarTempoGraf, iVarSetpointTemperatura);
            chartTempUmi.Series[1].Points.AddXY(iVarTempoGraf, iVarSetpointUmidade);
            chartTempUmi.Series[2].Points.AddXY(iVarTempoGraf, iVarTemperatura);
            chartTempUmi.Series[3].Points.AddXY(iVarTempoGraf, iVarUmidade);

            iVarTempoGraf++;

            if (bTrata_RecepcaoSerial == true)
            {
                bTrata_RecepcaoSerial = false;
                string TxtDecoder = SerialComPort.ReadExisting();              //le o dado disponível na serial
                this.BeginInvoke(new Fdelegate(trataDadoRecebido), new object[] { TxtDecoder });
            }
        }

        public void SerialComPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            bTrata_RecepcaoSerial = true;
        }

        private void trataDadoRecebido(string sDado)
        {
            string Decodificado = string.Empty;
            int FlagStatus = 0;
            String sStr = sDado;

            for (int cont = 0; cont < sStr.Length; cont++)
            {
                if (sStr.Substring(cont, 1) == "[")
                {
                    FlagStatus = 1;
                }
                else if (FlagStatus == 1)
                {
                    if (sStr.Substring(cont, 1) == "]")
                    {
                        string[] Texto = Decodificado.Split(']');// [AD0:10AE]
                        try
                        {
                            if (Texto[0] == "AQUECEDOR=LIGADO")
                            {
                                buttonAquecedor.BackColor = System.Drawing.Color.Red;
                                buttonAquecedor.Text = "AQUECEDOR LIGADO";
                            }

                            if (Texto[0] == "AQUECEDOR=DESLIGADO")
                            {
                                buttonAquecedor.BackColor = System.Drawing.Color.Gray;
                                buttonAquecedor.Text = "AQUECEDOR DESLIGADO";
                            }

                            if (Texto[0] == "UMIDIFICADOR=LIGADO")
                            {
                                buttonUmidificador.BackColor = System.Drawing.Color.Blue;
                                buttonUmidificador.Text = "UMIDIFICADOR LIGADO";
                            }

                            if (Texto[0] == "UMIDIFICADOR=DESLIGADO")
                            {
                                buttonUmidificador.BackColor = System.Drawing.Color.Gray;
                                buttonUmidificador.Text = "UMIDIFICADOR DESLIGADO";
                            }

                            if (Texto[0].Contains("TEMPERATURA="))
                            {
                                string[] TextoTemp = Decodificado.Split('=');// [AD0:10AE]
                                iVarTemperatura = Int32.Parse(TextoTemp[1].Trim());
                            }

                            if (Texto[0].Contains("UMIDADE="))
                            {
                                string[] TextoTemp = Decodificado.Split('=');// [AD0:10AE]
                                iVarUmidade = Int32.Parse(TextoTemp[1].Trim());
                            }

                            if (Texto[0].Contains("SETTEMP="))
                            {
                                string[] TextoTemp = Decodificado.Split('=');// [AD0:10AE]
                                iVarSetpointTemperatura = Int32.Parse(TextoTemp[1].Trim());

                                labelSetpointTemp.Text = iVarSetpointTemperatura.ToString();
                                chartTempUmi.Series[0].Points.AddXY(iVarTempoGraf, iVarSetpointTemperatura);
                            }

                            if (Texto[0].Contains("SETUMID="))
                            {
                                string[] TextoTemp = Decodificado.Split('=');// [AD0:10AE]
                                iVarSetpointUmidade = Int32.Parse(TextoTemp[1].Trim());

                                labelSetpointUmi.Text = iVarSetpointUmidade.ToString();
                                chartTempUmi.Series[1].Points.AddXY(iVarTempoGraf, iVarSetpointUmidade);
                            }
                        }
                        catch
                        {

                        }

                        Decodificado = string.Empty;
                        FlagStatus = 0;
                    }
                    else
                    {
                        Decodificado += sStr.Substring(cont, 1);
                    }
                }
            }
            //this.textBoxRecepcao.Text += DateTime.Now.ToString("HH:mm:ss") + ":  ";
            this.textBoxRecepcao.Text += sStr;// + "\r\n";
        }

        private void btnAumentaTemp_Click(object sender, EventArgs e)
        {
            iVarSetpointTemperatura++;
            if(iVarSetpointTemperatura > 70)
            {
                iVarSetpointTemperatura = 70;
            }

            labelSetpointTemp.Text = iVarSetpointTemperatura.ToString();
            chartTempUmi.Series[0].Points.AddXY(iVarTempoGraf, iVarSetpointTemperatura);

            if (SerialComPort.IsOpen)
            {
                SerialComPort.Write("[SETTEMP=");
                SerialComPort.Write(iVarSetpointTemperatura.ToString());
                SerialComPort.Write("]");
            }
        }

        private void btnDiminuiTemp_Click(object sender, EventArgs e)
        {
            iVarSetpointTemperatura--;
            if (iVarSetpointTemperatura < 0)
            {
                iVarSetpointTemperatura = 0;
            }

            labelSetpointTemp.Text = iVarSetpointTemperatura.ToString();
            chartTempUmi.Series[0].Points.AddXY(iVarTempoGraf, iVarSetpointTemperatura);

            if (SerialComPort.IsOpen)
            {
                SerialComPort.Write("[SETTEMP=");
                SerialComPort.Write(iVarSetpointTemperatura.ToString());
                SerialComPort.Write("]");
            }
        }

        private void btnAumentaUmi_Click(object sender, EventArgs e)
        {
            iVarSetpointUmidade++;
            if (iVarSetpointUmidade > 99)
            {
                iVarSetpointUmidade = 99;
            }

            labelSetpointUmi.Text = iVarSetpointUmidade.ToString();
            chartTempUmi.Series[1].Points.AddXY(iVarTempoGraf, iVarSetpointUmidade);

            if (SerialComPort.IsOpen)
            {
                SerialComPort.Write("[SETUMID=");
                SerialComPort.Write(iVarSetpointUmidade.ToString());
                SerialComPort.Write("]");
            }
        }

        private void btnDiminuiUmi_Click(object sender, EventArgs e)
        {
            iVarSetpointUmidade--;
            if (iVarSetpointUmidade < 0)
            {
                iVarSetpointUmidade = 0;
            }

            labelSetpointUmi.Text = iVarSetpointUmidade.ToString();
            chartTempUmi.Series[1].Points.AddXY(iVarTempoGraf, iVarSetpointUmidade);

            if (SerialComPort.IsOpen)
            {
                SerialComPort.Write("[SETUMID=");
                SerialComPort.Write(iVarSetpointUmidade.ToString());
                SerialComPort.Write("]");
            }
        }

        private void Monitora_Aviario_Load(object sender, EventArgs e)
        {
            #region Configuração Serial do Terminal
            String[] ListCom = SerialPort.GetPortNames();

            string NameCom;
            int x = 0;
            for (int i = 0; i < ListCom.Length; i++)
            {
                NameCom = ListCom[i];
                comboBoxPortaCom.Items.Add(NameCom);
                if (NameCom == "COM1")
                {
                    x = i;

                }

            }

            if (ListCom.Length > 0)
                comboBoxPortaCom.SelectedIndex = x;
            #endregion

            #region Carrega valores de BaudRate no ComboBox
            Int32[] BaudRateValores = { 100,300,600,1200,2400,4800,9600,14400,19200,
                                        38400,56000,57600,115200,128000,256000
                                       };
            int x1 = 0;
            for (int i = 0; i < BaudRateValores.Length; i++)
            {
                comboBoxBaudRate.Items.Add(BaudRateValores[i].ToString());
                if (BaudRateValores[i] == 115200)
                {
                    x1 = i;
                }
            }
            comboBoxBaudRate.SelectedIndex = x1;
            #endregion
        }

        private void buttonConectaPlaca_Click(object sender, EventArgs e)
        {
            SerialComPort.PortName = comboBoxPortaCom.Text;
            SerialComPort.BaudRate = Int32.Parse(comboBoxBaudRate.Text);

            try
            {
                SerialComPort.Open();
                buttonConectaPlaca.Enabled = false;
                buttonDesconectaPlaca.Enabled = true;
                comboBoxPortaCom.Enabled = false;
                comboBoxBaudRate.Enabled = false;
                
                labelInfoConexao.Text = "CONECTADO";
                labelInfoConexao.BackColor = System.Drawing.Color.Green;

                if (SerialComPort.IsOpen)
                {
                    SerialComPort.Write("[SETTEMP=");
                    SerialComPort.Write(iVarSetpointTemperatura.ToString());
                    SerialComPort.Write("]");

                    SerialComPort.Write("[SETUMID=");
                    SerialComPort.Write(iVarSetpointUmidade.ToString());
                    SerialComPort.Write("]");
                }

            }
            catch
            {
                MessageBox.Show("Não foi possível abrir a porta COM selecionada");
            }
        }

        private void buttonDesconectaPlaca_Click(object sender, EventArgs e)
        {
            SerialComPort.Close();
            buttonDesconectaPlaca.Enabled = false;
            buttonConectaPlaca.Enabled = true;
            comboBoxPortaCom.Enabled = true;
            comboBoxBaudRate.Enabled = true;
           
            labelInfoConexao.Text = "Desconectado";
            labelInfoConexao.BackColor = System.Drawing.Color.Red;
        }

        private void buttonLimpaLog_Click(object sender, EventArgs e)
        {
            this.textBoxRecepcao.Text = "";
        }
    }
}
