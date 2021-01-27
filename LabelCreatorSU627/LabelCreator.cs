using ExcelDataReader;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using ThoughtWorks.QRCode.Codec;

namespace LabelCreatorSU627
{
    public partial class LabelCreatorfrm : Form
    {

        PrintDocument document = new PrintDocument();
        PrintDialog pdi = new PrintDialog();

        int totcount = 0;
        int lcount = 0;

        string commancode = "";
        string psno = "";
        string txtSN = "";
        string txtsim = "";
        string ctext = "";
        string rn1 = "";
        string rn2 = "";

        bool status = false;

        private Font m_FontURL;
        private Font m_FontSerial2;
        private Font m_FontSerial3;
        private Font m_FontRegular;
        private Font m_FontSerial;
        private Font m_FontURL2, m_FontSerial4, m_FontURLot, m_FontSerialot1, m_FontSerialot2;

        public LabelCreatorfrm()
        {
            InitializeComponent();
        }

        private void LabelCreator_Load(object sender, EventArgs e)
        {
            lblnote.Location = new Point(130, 313);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkserialno.Checked)
            {
                gbserialno.Location = new Point(38, 150);
                gbserialno.Visible = true;
                rdbManually.Checked = false;
                rdbExcel.Checked = false;
                gbmanual.Visible = false;
                gbexcel.Visible = false;
            }
            else
            {
                gbserialno.Visible = false;
            }
        }

        private void btnserialno_Click(object sender, EventArgs e)
        {
            string serialNumber = string.Empty;

            if (chksu627s.Checked == false && chksu627w.Checked == false)
                MessageBox.Show("Please check the device type.");
            else if (chksu627s.Checked == true && chksu627w.Checked == true)
                MessageBox.Show("Please check one of the device type.");

            if (string.IsNullOrEmpty(txtserialno.Text))
                MessageBox.Show("Please fill the Serial No..");
            else
            {
                if (chksu627s.Checked)
                {
                    serialNumber = GetLastSerialNoOfDeviceType(chksu627s.Text);
                    if (!string.IsNullOrEmpty(serialNumber))
                    {
                        long serialNo = Convert.ToInt64(serialNumber);
                        ExportDataIntoNotepad(serialNo, Convert.ToInt32(txtserialno.Text));
                    }
                    else
                    {
                        MessageBox.Show("Connection Problem");
                    }
                }
                else if (chksu627w.Checked)
                {
                    serialNumber = GetLastSerialNoOfDeviceType(chksu627w.Text);
                    if (!string.IsNullOrEmpty(serialNumber))
                    {
                        long serialNo = Convert.ToInt64(serialNumber);
                        ExportDataIntoNotepad(serialNo, Convert.ToInt32(txtserialno.Text));
                    }
                    else
                    {
                        MessageBox.Show("Connection Problem");
                    }
                }
            }
        }

        private void rdbManually_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbManually.Checked)
            {
                gbmanual.Location = new Point(38, 136);
                gbmanual.Visible = true;
                rdbExcel.Checked = false;
                gbserialno.Visible = false;
                chkserialno.Checked = false;
                gbexcel.Visible = false;
            }
        }

        private void btnmprintlbl_Click(object sender, EventArgs e)
        {
            if (chksu627s.Checked == false && chksu627w.Checked == false)
                MessageBox.Show("Please check the device type.");
            else if (chksu627s.Checked == true && chksu627w.Checked == true)
                MessageBox.Show("Please check one of the device type.");
            else if (string.IsNullOrEmpty(txtmserialno.Text))
                MessageBox.Show("Please fill the Serial No..");
            else if (string.IsNullOrEmpty(txtmsimno.Text))
                MessageBox.Show("Please fill the Sim No..");
            else if (string.IsNullOrEmpty(txtmimeino.Text))
                MessageBox.Show("Please fill the IMEI no..");
            else
                print_lable_manualprinter(txtmserialno.Text, txtmsimno.Text, 1);
        }

        private void rdbExcel_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbExcel.Checked)
            {
                gbexcel.Location = new Point(38, 136);
                gbexcel.Visible = true;
                rdbManually.Checked = false;
                gbserialno.Visible = false;
                chkserialno.Checked = false;
                gbmanual.Visible = false;
            }
        }

        private void btnprintLabel_Click(object sender, EventArgs e)
        {
            if ((chksu627s.Checked == true && chksu627w.Checked == false) || (chksu627s.Checked == false && chksu627w.Checked == true))
            {
                if (pdi.ShowDialog() == DialogResult.OK)
                {
                    if (rdbExcel.Checked == true)
                    {
                        if (txtexcelpath.Text.Trim() == "")
                        {
                            MessageBox.Show("Select Excel File");
                        }
                        else
                        {
                            string serialnumber = "";
                            string simnumber = "";
                            DataTable dt = new DataTable();
                            dt = ExcelConn(txtexcelpath.Text);
                            if (dt.Rows.Count > 0)
                            {
                                totcount = dt.Rows.Count;
                                for (int i = 0; i < dt.Rows.Count; i++)
                                {
                                    serialnumber = dt.Rows[i]["Serial Number"].ToString();
                                    simnumber = dt.Rows[i]["Sim Number"].ToString();
                                    //timer11 = 1;
                                    lcount = i + 1;
                                    psno = serialnumber;
                                    print_lable_manualprinter(serialnumber, simnumber, 1);
                                }
                            }
                        }
                    }
                }
            }
            else if (chksu627w.Checked == true && chksu627s.Checked == true)
                MessageBox.Show("Please select only one device at a time.");
            else
                MessageBox.Show("Please select atleast one device.");
        }

        private DataTable ExcelConn(string filepath)
        {
            var stream = File.Open(filepath, FileMode.Open, FileAccess.Read);
            var reader = ExcelReaderFactory.CreateReader(stream);
            DataTableCollection sheets = reader.AsDataSet(GetDataSetConfig()).Tables;
            return sheets[0];
        }

        private static ExcelDataSetConfiguration GetDataSetConfig()
        {
            return new ExcelDataSetConfiguration
            {
                ConfigureDataTable = _ => new ExcelDataTableConfiguration()
                {
                    UseHeaderRow = true,
                    //ReadHeaderRow = rowReader => Console.WriteLine($"{rowReader[0]}:{rowReader[1]}:{rowReader[2]}")
                }
            };
        }

        private void btnexcelpath_Click(object sender, EventArgs e)
        {
            DialogResult result = OFD.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtexcelpath.Text = OFD.FileName;
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
                    conn.Open();

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
            catch (Exception)
            {
                conn.Close();
            }
            if (cnt > 0)
            {
                status = true;
            }
            return status;
        }

        private void print_lable_manualprinter(string Sno, string simno, int copies)
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

                this.m_FontURL = new Font("Tahoma", 4f, FontStyle.Bold);
                this.m_FontURL2 = new Font("Tahoma", 4f);
                this.m_FontSerial2 = new Font("Tahoma", 4.0f, FontStyle.Bold);
                this.m_FontSerial3 = new Font("Tahoma", 4.0f);
                this.m_FontRegular = new Font("Tahoma", 7f);
                this.m_FontSerial = new Font("Tahoma", 4.1f, FontStyle.Bold);
                this.m_FontSerial4 = new Font("Tahoma", 3.7f, FontStyle.Bold);

                this.m_FontURLot = new Font("Tahoma", 3.3f, FontStyle.Bold);
                this.m_FontSerialot1 = new Font("Tahoma", 3.0f, FontStyle.Bold);
                this.m_FontSerialot2 = new Font("Tahoma", 3.4f, FontStyle.Bold);


                int num2 = copies;// Copies;

                document.PrintPage += new PrintPageEventHandler(this.PrintDeviceLabel);
                document.DefaultPageSettings.PaperSize = new PaperSize("OBD Label", Convert.ToInt32(300), Convert.ToInt32(400));
                document.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.Custom;
                pdi.PrinterSettings.DefaultPageSettings.PaperSize = new PaperSize("OBD Label", Convert.ToInt32(300), Convert.ToInt32(400));
                pdi.PrinterSettings.DefaultPageSettings.PaperSize.RawKind = (int)PaperKind.Custom;

                DialogResult result = DialogResult.No;
                if (Chkdevice(txtSN))
                {
                    result = MessageBox.Show("This SR No. is already Exist . if you want to Print label click on Yes", "Alert", MessageBoxButtons.YesNo);

                    if (result == DialogResult.Yes)
                    {
                        for (int i = 1; i <= num2; i++)
                        {
                            //int ph = 0;
                            //int pw = 0;
                            //if (chk228.Checked)
                            //{
                            //    ph = Convert.ToInt32(30 * .254);
                            //    pw = Convert.ToInt32(40 * .254);
                            //}
                            //else
                            //{
                            //    ph = Convert.ToInt32(23 * .254);
                            //    pw = Convert.ToInt32(33 * .254);
                            //}

                            document.Print();
                        }
                    }
                }
                else
                {
                    for (int i = 1; i <= num2; i++)
                    {
                        // Thread.Sleep(2000);
                        document.Print();
                        status = false;
                        commancode = "";
                    }

                    if (chksu627s.Checked)
                    {
                        adddevice(Sno, ctext, simno, chksu627s.Text);
                    }
                    else if (chksu627w.Checked)
                    {
                        adddevice(Sno, ctext, simno, chksu627w.Text);
                    }


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

        private void adddevice(string imei, string activecode, string simnumber, string typename)
        {
            string connectionstring = "Server=206.225.83.228,1433;Database=SekurPay;uid=sa;pwd=Qazmlp01$$$;Max Pool Size=500;Connection Timeout=60;Application Name=SekurPayGps;";
            SqlConnection conn = new SqlConnection(connectionstring);
            SqlCommand cmd;
            string str;
            int devicetype = GetDeviceType(typename);
            string version = "1.0";

            if (simnumber.Length == 0)
                simnumber = null;

            try
            {
                str = "Insert Into DevicesGlobalUI(SerialNumber,Version,DeviceTypeid,SimNumber,Companyid,partnerId,DistributorId,InVehicle,UserName,activecode,Domain) Values(@serialnumber, @Version, @devicetype, @simnumber, null, null, null, 0, 'superadmin', @activecode, 'none')";
               
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                cmd = new SqlCommand(str, conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new SqlParameter("@serialnumber", SqlDbType.VarChar, 50));
                cmd.Parameters["@serialnumber"].Value = imei;
                cmd.Parameters.Add(new SqlParameter("@simnumber", SqlDbType.VarChar, 50));
                cmd.Parameters["@simnumber"].Value = simnumber;
                cmd.Parameters.Add(new SqlParameter("@activecode", SqlDbType.NVarChar, 100));
                cmd.Parameters["@activecode"].Value = activecode;
                cmd.Parameters.Add(new SqlParameter("@devicetype", SqlDbType.Int));
                cmd.Parameters["@devicetype"].Value = devicetype;
                cmd.Parameters.Add(new SqlParameter("@Version", SqlDbType.VarChar, 50));
                cmd.Parameters["@Version"].Value = version;
                cmd.ExecuteNonQuery();
                conn.Close();

                MessageBox.Show($"This {imei} no is successfully inserted..");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception:" + ex.Message);
                conn.Close();
            }
        }

        public void PrintDeviceLabel(object Sender, PrintPageEventArgs ev)
        {
            this.m_FontURL = new Font("Tahoma", 5f);
            this.m_FontSerial2 = new Font("Tahoma", 4.0f);
            this.m_FontSerial3 = new Font("Tahoma", 4.5f);
            this.m_FontRegular = new Font("Tahoma", 7f);
            this.m_FontSerial = new Font("Tahoma", 6f);

            rn1 = GenerateCoupon(10);//rn.Next(0, 99999).ToString();
            rn2 = GenerateCoupon(10);//rn.Next(0, 99999).ToString();
            string text = txtSN.Trim(); //"12345678912345";
            ctext = rn1.ToString() + text + rn2.ToString();
            if (commancode != "")
            {
                ctext = commancode;
            }

            float y = 0f;
            float x = 0f;
            float num2 = 10f;
            float num = 10f;
            float h = 23f;
            float w = 110f;
            y = 5f;
            x = 6.5f;
            ev.Graphics.DrawImage(Image.FromFile("logo1.png"), (int)x, y, w, h);

            QRCodeEncoder qrCodeEncoder = new QRCodeEncoder();
            qrCodeEncoder.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;
            qrCodeEncoder.QRCodeScale = 4;
            qrCodeEncoder.QRCodeVersion = 8;
            qrCodeEncoder.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.M;
            //string qrData = "IMEI : "+text ;
            string qrData1
                // = "PNO=SU100L&http://sekurme.com/act/dt.aspx?act=" + ctext;
                = "PNO=SU028B&http://sekurme.com/activation/deviceAct.aspx?act=" + ctext + "&Sno=" + txtsim.Trim();

            y = num2 + 27f;//25f
            x = num + 25f;
            h = 45f;
            w = 55f;

            ev.Graphics.DrawImage(qrCodeEncoder.Encode(qrData1), x, y, w, h);

            // System.Drawing.Image logo = System.Drawing.Image.FromFile("S1.png");

            float left = w;// -Convert.ToInt32(x / 2);
            float top = h;// -Convert.ToInt32(y / 2);
            //ev.Graphics.DrawImage(logo, left, top,15,15);
            //x = x + logo.Width+5;
            //y = y + logo.Height+1;
            //ev.Graphics.DrawImage(Image.FromFile("S1.png"), (int)x, y,12,12);

            y = num2 + 77f;
            x = num;
            h = 12f;
            w = 19f;
            ev.Graphics.DrawImage(Image.FromFile("fc1.png"), (int)x, y, w, h);

            y = num2 + 77f;
            x = num + 45f;
            h = 11f;
            w = 17f;
            ev.Graphics.DrawImage(Image.FromFile("ce1.png"), (int)x, y, w, h);

            y = num2 + 75f;
            x = num + 85f;
            h = 15f;
            w = 19f;
            ev.Graphics.DrawImage(Image.FromFile("rohs1.png"), (int)x, y, w, h);


            y = num2 + 93f; //110f
            x = num + 4f;
            h = 7f;
            w = 13f;
            if (chksu627s.Checked)
            {
                ev.Graphics.DrawString("PID   :    SU627S", this.m_FontSerial3, Brushes.Black, x, y);
            }
            else
            {
                ev.Graphics.DrawString("PID   :    SU627W", this.m_FontSerial3, Brushes.Black, x, y);
            }
            y = num2 + 99f; //110f
            x = num + 4f;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString("ID", this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 99f; //110f
            x = num + 20f;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString(":", this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 99f; //110f
            x = num + 30f;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString(txtsim, this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 106f; //110f
            x = num + 4f;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString("SIR#", this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 106f; //110f
            x = num + 20f;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString(":", this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 106f; //110f
            x = num + 30f;
            h = 7f;
            w = 13f;
            ev.Graphics.DrawString(text, this.m_FontSerial3, Brushes.Black, x, y);

            y = num2 + 115f; //110f
            x = 7.2f;
            ev.Graphics.DrawString("Sekurus International (USA)", this.m_FontSerial, Brushes.Black, x, y);

            y = num2 + 117f; //110f
            x = num + 85f;

            // Create font and brush.
            Font drawFont = new Font("Tahoma", 4.5f);
            SolidBrush drawBrush = new SolidBrush(Color.Black);

            // Create point for upper-left corner of drawing.
            PointF drawPoint = new PointF(x, y);

            // Draw string to screen.
            // ev.Graphics.DrawString(drawString, drawFont, drawBrush, drawPoint);


            y = num2 + 125f;//120
            x = num + 20f;
            ev.Graphics.DrawString("www.sekurus.com", this.m_FontURL, Brushes.Black, x, y);
            ev.HasMorePages = false;

        }

        private string GenerateCoupon(int length)
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

        private string GetLastSerialNoOfDeviceType(string typename)
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

        private void ExportDataIntoNotepad(long serialNo, int serialNoCount)
        {
            try
            {
                DialogResult result = SFD.ShowDialog();
                if (result == DialogResult.OK)
                {
                    if (File.Exists(SFD.FileName + ".txt"))
                        File.Delete(SFD.FileName);

                    StreamWriter sw = new StreamWriter(SFD.FileName + ".txt");
                    sw.WriteLine("Serial Number");
                    for (int i = 0; i < serialNoCount; i++)
                    {
                        sw.WriteLine(++serialNo);
                    }

                    sw.Close();

                    MessageBox.Show($"The {serialNoCount} serial Number are write into the file..");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception : " + ex.Message);
            }
        }
    }
}