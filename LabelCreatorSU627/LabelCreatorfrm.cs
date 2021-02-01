using System;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using ThoughtWorks.QRCode.Codec;
using System.Data.SqlClient;
using System.Data.OleDb;
using Microsoft.Office.Interop.Excel;
using System.Collections.Generic;
using System.Net;
using System.IO;
using LabelCreatorSU627;
using Newtonsoft.Json;

namespace OBDTool
{
    public partial class frmOBDLabel : Form
    {
        int isstart = 0;
        string txtSN;
        string txtsim;
        string constr, Query;
        OleDbConnection Econ;
        int timer11 = 0;
        int lcount = 0;
        int totcount = 0;
        string psno = "";
        private System.Drawing.Font m_FontURL2, m_FontSerial4, m_FontURLot, m_FontSerialot1, m_FontSerialot2;
        private System.Drawing.Font m_FontURL;
        private System.Drawing.Font m_FontSerial2;
        private System.Drawing.Font m_FontSerial3;
        private System.Drawing.Font m_FontRegular;
        private System.Drawing.Font m_FontSerial;
        readonly Random rn = new Random(5);
        string rn1 = "";
        string rn2 = "";
        string ctext = "";
        string commancode = "";
        Boolean status = false;
        int noofcopies = 1;
        int chkvalue = 1;
        string imei = "";
        PrintDocument document = new PrintDocument();
        readonly PrintDialog pdi = new PrintDialog();

        public frmOBDLabel()
        {
            InitializeComponent();
        }

        private void FrmOBDLabel_Load(object sender, EventArgs e)
        {
            checkBox1.Checked = false;
            cmbCopies.SelectedIndex = 0;
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            if (chk2.Checked == false && chk3.Checked == false)
            {
                MessageBox.Show("Select device type");
            }
            else
            {
                noofcopies = Convert.ToInt32(cmbCopies.Text);

                if (pdi.ShowDialog() == DialogResult.OK)
                {
                    if (rdbExcel.Checked == true)
                    {
                        if (txtfilepath.Text.Trim() == "")
                        {
                            MessageBox.Show("Select Excel File");
                        }
                        else
                        {
                            string serialnumber = "";
                            string simnumber = "";
                            DataSet ds = new DataSet();
                            ds = Getfile();
                            if (ds != null)
                            {
                                totcount = ds.Tables[0].Rows.Count;
                                for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
                                {
                                    serialnumber = ds.Tables[0].Rows[i]["serialnumber"].ToString();
                                    simnumber = ds.Tables[0].Rows[i]["simnumber"].ToString();
                                    imei = ds.Tables[0].Rows[i]["imei"].ToString();
                                    timer11 = 1;
                                    lcount = i + 1;
                                    psno = serialnumber;
                                    print_lable_manualprinter(serialnumber, simnumber, noofcopies, imei);
                                }
                            }

                        }
                    }
                    else
                    {
                        if (txtsrnumber.Text.Trim() == "")
                        {
                            MessageBox.Show("Serial Number Required");
                        }
                        else
                            print_lable_manualprinter(txtsrnumber.Text, txtsimnumber.Text, noofcopies, ttximei.Text);
                    }
                }

            }
        }

        void print_lable_manualprinter(string Sno, string simno, int copies, string imeino)
        {
            try
            {
                pdi.UseEXDialog = true;
                document = new PrintDocument();
                document.PrinterSettings.DefaultPageSettings.PrinterResolution.X = 4000;
                document.PrinterSettings.DefaultPageSettings.PrinterResolution.Y = 4000;
                pdi.Document = document;
                document.DefaultPageSettings.Landscape = true;

                txtSN = Sno;
                txtsim = simno;
                imei = imeino;

                this.m_FontURL = new System.Drawing.Font("Tahoma", 4f, FontStyle.Bold);
                this.m_FontURL2 = new System.Drawing.Font("Tahoma", 4f);
                this.m_FontSerial2 = new System.Drawing.Font("Tahoma", 4.0f, FontStyle.Bold);
                this.m_FontSerial3 = new System.Drawing.Font("Tahoma", 5.0f);
                this.m_FontRegular = new System.Drawing.Font("Tahoma", 7f);
                this.m_FontSerial = new System.Drawing.Font("Tahoma", 4.1f, FontStyle.Bold);
                this.m_FontSerial4 = new System.Drawing.Font("Tahoma", 3.7f, FontStyle.Bold);
                // ----- OT ---------------

                this.m_FontURLot = new System.Drawing.Font("Tahoma", 3.3f, FontStyle.Bold);
                this.m_FontSerialot1 = new System.Drawing.Font("Tahoma", 3.0f, FontStyle.Bold);
                this.m_FontSerialot2 = new System.Drawing.Font("Tahoma", 3.4f, FontStyle.Bold);
                // resolution is set


                int num2 = copies;// Copies;

                document.PrintPage += new PrintPageEventHandler(this.PrintDeviceLabelMT05);
                document.DefaultPageSettings.PaperSize = new PaperSize("OBD Label", Convert.ToInt32(150), Convert.ToInt32(120))
                {
                    RawKind = (int)PaperKind.Custom
                };
                pdi.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("OBD Label", Convert.ToInt32(150), Convert.ToInt32(120))
                {
                    RawKind = (int)PaperKind.Custom
                };

                DialogResult result = DialogResult.No;
                if (Chkdevice(txtSN))
                {
                    result = MessageBox.Show("This SR No. is already Exist . if you want to Print label click on Yes", "Alert", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        for (int i = 1; i <= num2; i++)
                        {
                            int ph = 0;
                            int pw = 0;

                            ph = Convert.ToInt32(23 * .254);
                            pw = Convert.ToInt32(33 * .254);

                            document.Print();
                        }
                    }
                }
                else
                {
                    for (int i = 1; i <= num2; i++)
                    {
                        document.Print();
                        status = false;
                        commancode = "";
                    }
                    Adddevice(Sno, ctext, simno, imei);
                    status = false;
                    commancode = "";
                }
            }
            catch (Exception exception1)
            {
                Exception exception = exception1;
                MessageBox.Show("Printing of the label was not successful. Please check your printer settings.", this.Text);
                MessageBox.Show(exception1.ToString());
            }
        }

        private Boolean Chkdevice(string imei)
        {
            status = false;
            commancode = "";
            string connectionstring = "Server=206.225.83.228,1433;Database=SekurPay;uid=sa;pwd=Qazmlp01$$$;Max Pool Size=500;Connection Timeout=60;Application Name=SekurPayGps;";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd;
            string str;
            SqlDataAdapter da;
            DataSet ds = new DataSet();
            Int32 cnt = 0;

            try
            {
                str = "select * from DevicesGlobalUI where serialnumber like '" + imei + "'";

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand(str, conn);
                cmd.CommandType = CommandType.Text;
                da = new SqlDataAdapter(cmd);
                da.Fill(ds);
                conn.Close();
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    commancode = ds.Tables[0].Rows[0]["activecode"].ToString();
                    status = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
                conn.Close();
            }
            if (cnt > 0)
            {
                status = true;
            }
            return status;
        }

        public static string GenerateCoupon(int length)
        {
            Random random = new Random();
            string characters = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }

        public static string GenerateCoupon1(int length)
        {
            Random random = new Random();
            string characters = "EFGHABCDIJKLUVWXYZadestuvwxyfghijklmbMNOPQRSTcnopqrz";
            // string characters = "123456789";
            StringBuilder result = new StringBuilder(length);
            for (int i = 0; i < length; i++)
            {
                result.Append(characters[random.Next(characters.Length)]);
            }
            return result.ToString();
        }

        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        public void PrintDeviceLabelMT05(object Sender, PrintPageEventArgs ev)
        {
            string devicename = "";
            if (chk2.Checked)
                devicename = "SU627S";
            else if (chk3.Checked)
                devicename = "SU627W";

            rn1 = GenerateCoupon(2);//rn.Next(0, 99999).ToString();
            rn2 = GenerateCoupon1(2);//rn.Next(0, 99999).ToString();
            string text = txtSN.Trim(); //"12345678912345";
            string decodedString = Base64Encode(text);
            ctext = rn1.ToString() + decodedString + rn2.ToString();

            if (commancode != "")
            {
                ctext = commancode;
            }

            float y = 0f;
            float x = 0f;
            float num2 = 10f;
            float num = 24f;
            float h = 18f;
            float w = 83f;
            y = 0f;
            x = 5f;

            ev.PageSettings.PrinterResolution.X = 10000;
            ev.PageSettings.PrinterResolution.Y = 10000;

            System.Drawing.Image logo1 = System.Drawing.Image.FromFile("sekurit1.jpg");
            ev.Graphics.DrawImage(logo1, (int)x, y);

            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder
            {
                QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE,
                QRCodeScale = 4,
                QRCodeVersion = 8,
                QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M
            };

            string qrData1 = "PNO=" + devicename + "&http://partners.sekurus.com/activation.aspx?act=" + ctext;

            y = num2 + 17f;//25f
            x = num + 10f;
            h = 43f;
            w = 53f;

            ev.Graphics.DrawImage(qrCodeEncoder.Encode(qrData1), x, y, w, h);
            System.Drawing.Image logo = System.Drawing.Image.FromFile("S1.png");

            float left = w;// -Convert.ToInt32(x / 2);
            float top = h;// -Convert.ToInt32(y / 2);

            y = num2 + 67f;
            x = num;
            h = 9f;
            w = 15f;
            ev.Graphics.DrawImage(Image.FromFile("fc1.png"), (int)x, y, w, h);

            y = num2 + 67f;
            x = num + 30f;
            h = 9f;
            w = 14f;
            ev.Graphics.DrawImage(Image.FromFile("ce1.png"), (int)x, y, w, h);

            y = num2 + 65f;
            x = num + 60f;
            h = 12f;
            w = 16f;
            ev.Graphics.DrawImage(Image.FromFile("rohs1.png"), (int)x, y, w, h);

            y = num2 + 83f; //110f
            x = num - 5;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString("PID  :    " + devicename, this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 91f; //110f
            x = num - 5;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString("ID", this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 91f; //110f
            x = num - 5 + 16f;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString(":", this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 91f; //110f
            x = num - 5 + 27f;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString(txtsim, this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 99f; //110f
            x = num - 5;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString("SIR#", this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 99f; //110f
            x = num - 5 + 16f;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString(":", this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 99f; //110f
            x = num - 5 + 27f;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString(text, this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 109f; //110f
            x = num - 3f;
            ev.Graphics.DrawString("Sekurus International (USA)", this.m_FontSerial, Brushes.Black, x, y);

            y = num2 + 116f;//120
            x = num + 10f;
            ev.Graphics.DrawString("www.sekurus.com", this.m_FontURL, Brushes.Black, x, y);
            ev.HasMorePages = false;

            y = num2 + 124f;//120
            x = num + 9f;
            ev.Graphics.DrawString("FCC : 2A06C" + devicename, this.m_FontURL, Brushes.Black, x, y);
        }

        private int GetDeviceType(string typeName)
        {
            int TypeId = 0;
            string connectionstring = "Server=206.225.83.228,1433;Database=SekurPay;uid=sa;pwd=Qazmlp01$$$;Max Pool Size=500;Connection Timeout=60;Application Name=SekurPayGps;";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd;
            string str;

            try
            {
                str = "select TypeId from DeviceTypes where TypeName = '" + typeName + "'";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd = new SqlCommand(str, conn);
                cmd.CommandType = CommandType.Text;
                object OtypeId = cmd.ExecuteScalar();
                if (OtypeId != null)
                    TypeId = Convert.ToInt32(OtypeId);
                else
                    TypeId = 0;
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
                conn.Close();
            }

            return TypeId;
        }

        private void Adddevice(string sno, string activecode, string simnumber, string imei)
        {
            string connectionstring = "Server=206.225.83.228,1433;Database=SekurPay;uid=sa;pwd=Qazmlp01$$$;Max Pool Size=500;Connection Timeout=60;Application Name=SekurPayGps;";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd;
            string str;
            int devicetype;
            string version = "1.0";

            if (simnumber.Length == 0)
                simnumber = null;

            if (chk2.Checked)
            {
                devicetype = GetDeviceType("SU627S");
                InsertDeviceIntoB2B(sno, simnumber, "SU627S");
            }
            else
            {
                devicetype = GetDeviceType("SU627W");
                InsertDeviceIntoB2B(sno, simnumber, "SU627W");
            }

            try
            {
                str = "[AddOBDDevice1_3]";

                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                cmd = new SqlCommand(str, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add(new SqlParameter("@serialnumber", SqlDbType.VarChar, 50));
                cmd.Parameters["@serialnumber"].Value = sno;
                cmd.Parameters.Add(new SqlParameter("@simnumber", SqlDbType.VarChar, 50));
                cmd.Parameters["@simnumber"].Value = simnumber;
                cmd.Parameters.Add(new SqlParameter("@activecode", SqlDbType.NVarChar, 100));
                cmd.Parameters["@activecode"].Value = activecode;
                cmd.Parameters.Add(new SqlParameter("@devicetype", SqlDbType.Int));
                cmd.Parameters["@devicetype"].Value = devicetype;
                cmd.Parameters.Add(new SqlParameter("@Version", SqlDbType.VarChar, 50));
                cmd.Parameters["@Version"].Value = version;
                cmd.Parameters.Add(new SqlParameter("@imei", SqlDbType.VarChar, 50));
                cmd.Parameters["@imei"].Value = imei;
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
                conn.Close();
            }

        }

        private void Chkmt05_CheckedChanged(object sender, EventArgs e)
        {
            if (chk3.Checked)
            {
                chkvalue = 2;
                chk3.Checked = true;
                chk2.Checked = false;
            }
            else
            {
                if (chkvalue == 2)
                {
                    chk3.Checked = true;
                }
            }
        }

        private void Chk2283g_CheckedChanged(object sender, EventArgs e)
        {
            if (chk2.Checked)
            {
                chkvalue = 3;
                chk3.Checked = false;
                chk2.Checked = true;
            }
            else
            {
                if (chkvalue == 3)
                {
                    chk2.Checked = true;
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                txtfilepath.Text = openFileDialog1.FileName;
                string file = openFileDialog1.FileName;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timer11 != 0)
            {
                panel4.Visible = true;

                label2.Text = "Generating Label for " + psno;

                label4.Text = "Progress: Completed 10% (0/200)";
                double per = Math.Round((Convert.ToDouble(lcount * 100) / totcount), 2);
                label4.Visible = true;
                label4.Text = "Progress: Completed " + per.ToString() + "% (" + lcount + "/" + totcount + ")";
                if (lcount == totcount)
                {
                    panel4.Visible = false;
                    timer11 = 0;
                    timer1.Enabled = false;
                    MessageBox.Show("Completed Successfully");

                }
            }
        }

        private void ExcelConn(string filepath)
        {
            constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0 Xml;HDR=YES;""", filepath);
            Econ = new OleDbConnection(constr);
        }

        public DataSet Getfile()
        {
            DataSet ds = new DataSet();
            try
            {
                ExcelConn(txtfilepath.Text);

                Query = string.Format("Select [Serial Number] as serialnumber,[Sim Number] as simnumber,[IMEI] as imei FROM [{0}] where [Serial Number] <>''", "Sheet1$");
                OleDbCommand Ecom = new OleDbCommand(Query, Econ);
                Econ.Open();

                OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);
                Econ.Close();
                oda.Fill(ds);
                System.Data.DataTable Exceldt = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        private void Timer2_Tick(object sender, EventArgs e)
        {
            label1.ForeColor = label1.ForeColor == Color.Red ? Color.Green : Color.Red;
            if (timer11 != 0)
            {
                timer1.Enabled = true;
            }
        }

        private void RdbExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbExcel.Checked == true)
            {
                panelExcel.Visible = true;
                panelManually.Visible = false;
            }
            else
            {
                panelExcel.Visible = false;
                panelManually.Visible = true;
            }
        }

        private string GetLastSerialNoByDeviceType(string typename)
        {
            string serialNo = "";
            string connectionstring = "Server=206.225.83.228,1433;Database=SekurPay;uid=sa;pwd=Qazmlp01$$$;Max Pool Size=500;Connection Timeout=60;Application Name=SekurPayGps;";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd;
            string str;
            int TypeId = GetDeviceType(typename);

            try
            {
                str = "select top 1 SerialNumber from DevicesGlobalUI where DeviceTypeId = " + TypeId + " and LEN(SerialNumber) between 11 and 12 order by SerialNumber DESC";

                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd = new SqlCommand(str, conn);
                cmd.CommandType = CommandType.Text;
                serialNo = (string)cmd.ExecuteScalar();
                conn.Close();
            }
            catch (Exception)
            {
                conn.Close();
            }

            return serialNo;
        }

        public void CreateExcel()
        {
            string devicetype = "";
            System.Data.DataTable dt = new System.Data.DataTable();
            if (chk2.Checked)
                devicetype = "SU627S";
            if (chk3.Checked)
                devicetype = "SU627W";

            string connectionstring = "Server=206.225.83.228,1433;Database=SekurPay;uid=sa;pwd=Qazmlp01$$$;Max Pool Size=500;Connection Timeout=60;Application Name=SekurPayGps;";
            SqlConnection conn = new SqlConnection(connectionstring);

            long LastSrno = Convert.ToInt64(GetLastSerialNoByDeviceType(devicetype));
            string newserianno = LastSrno.ToString();

            Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

            if (xlApp == null)
            {
                MessageBox.Show("Excel is not properly installed!!");
                return;
            }

            Workbook xlWorkBook;
            Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Worksheet)xlWorkBook.Worksheets.get_Item(1);

            xlWorkSheet.Cells.NumberFormat = "@";

            xlWorkSheet.Cells[1, 1] = "Serial Number";
            xlWorkSheet.Cells[1, 2] = "Sim Number";
            xlWorkSheet.Cells[1, 3] = "PhoneNumber";
            xlWorkSheet.Cells[1, 4] = "IMEI";

            for (int i = 1; i <= Convert.ToInt32(txttotal.Text); i++)
            {
                newserianno = Convert.ToString(LastSrno + i);
                xlWorkSheet.Cells[i + 1, 1] = "" + newserianno;
            }

            string filename = "SrNo-" + devicetype + "-" + DateTime.Now.Day + DateTime.Now.Month + DateTime.Now.Year + DateTime.Now.Hour + DateTime.Now.Minute + DateTime.Now.Second;

            saveFileDialog1.Filter = "Exel (*.xlsx)|*.xlsx|Exel 2003 (*.xls)|*.xls";
            saveFileDialog1.FileName = filename;
            DialogResult result = saveFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                filename = saveFileDialog1.FileName;
                try
                {
                    //Here saving the file in xlsx
                    xlWorkBook.SaveAs(filename, Microsoft.Office.Interop.Excel.XlFileFormat.xlOpenXMLWorkbook, misValue,
                    misValue, misValue, misValue, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue);
                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();

                    SqlCommand cmd = new SqlCommand("update SerialNumber set serialnumber='" + newserianno + "' where DeviceType='" + devicetype + "' ", conn);
                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("Excel file created , you can find the file " + filename);

                }
                catch
                {
                    MessageBox.Show("Access Denied while Creating Excel, Please Generate Serial Number again");
                }
            }

            panel8.Visible = false;
            checkBox1.Checked = false;
            txttotal.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            isstart = 0;
            if (chk2.Checked == false && chk3.Checked == false)
            {
                MessageBox.Show("Select device type");
            }
            else
            {
                if (txttotal.Text == "")
                {
                    MessageBox.Show("Enter total number of Serial Numbers");
                }
                else
                {
                    timer3.Enabled = true;

                }
            }




        }

        private void TextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                panel7.Visible = true;
            }
            else
            {
                panel7.Visible = false;
            }
        }

        private void Timer3_Tick(object sender, EventArgs e)
        {
            isstart++; ;
            if (isstart == 1)
            {

                panel8.Visible = true;
            }
            if (isstart == 2)
            {
                CreateExcel();

            }
            if (isstart == 4)
                timer3.Enabled = false;
        }

        private void InsertDeviceIntoB2B(string serialNo, string simNo, string deviceName)
        {
            try
            {
                WebRequest tRequest = HttpWebRequest.Create("https://b2b.sekurus.com/new2020/serial_number.php");
                tRequest.Method = "POST";
                tRequest.ContentType = "application/json";

                Device _device = new Device
                {
                    Serial_number = serialNo,
                    Domain = deviceName,
                    Sim_number = simNo
                };

                var jsonString = JsonConvert.SerializeObject(_device);
                var jsontolower = jsonString.ToLower();
                Byte[] byteArray = Encoding.UTF8.GetBytes(jsontolower);

                tRequest.ContentLength = byteArray.Length;
                Stream dataStream = tRequest.GetRequestStream();
                dataStream.Write(byteArray, 0, byteArray.Length);
                dataStream.Close();

                WebResponse tResponse = tRequest.GetResponse();
                dataStream = tResponse.GetResponseStream();
                StreamReader tReader = new StreamReader(dataStream);

                string sResponsefromServer = tReader.ReadToEnd();
                tReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.Message);
            }
        }
    }
}