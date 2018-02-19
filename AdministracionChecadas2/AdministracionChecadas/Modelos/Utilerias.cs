using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Drawing;

namespace DescargarChecadas.Modelos
{
    public enum Estatus
    {
        OK, ERROR, CONECTADO, DESCONECTADO
    }

    public partial class Response
    {
        public Estatus status { get; set; }
        public string resultado { get; set; }
        public string error { get; set; }
    }

    public static class ConectionString
    {
        public static string conn { get; set; }

        public static string puerto { get; set; }
        public static string ip { get; set; }
        public static string tipoCh { get; set; }
        public static int numCh { get; set; }
    }

    public class Utilerias
    {
        /// <summary>
        /// Performs the ROT13 character rotation.
        /// </summary>
        public string Transform(string value)
        {
            char[] array = value.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }

        // Codificar cadena a Base64
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        // Decodificar cadena a Base64
        public static string Base64Decode(string base64EncodedData)
        {
            var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
            return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
        }
        
        /// <summary>
        /// Ejecuta una sql que rellenar un DataReader (sentencia select).
        /// </summary>
        /// <param name="SqlQuery">sentencia sql a ejecutar</param>
        /// <returns>Estatus de transacción y datos obtenidos</returns> 
        public static ManejoSql EjecutaSQL(string SqlQuery, MySqlCommand cmd)
        {
            ManejoSql result = new ManejoSql();

            try
            {
                // Se define el tipo de comando
                cmd.CommandType = CommandType.Text;

                // Se define la instruccion Transact-SQL 
                cmd.CommandText = SqlQuery;

                // Ejecutamos sql.
                result.reader = cmd.ExecuteReader();

                // Se define si la respuesta no generó ningun error
                result.ok = true;

            }
            catch (MySqlException sqlex)
            {
                // se define el numero de error segun SqlServer
                result.numErr = sqlex.Number;

                // Se define el mensaje de error
                result.descErr = sqlex.Message;

                // Se define estatus de transaccion
                result.ok = false;
            }
            catch (Exception ex)
            {
                // se define el numero de error segun SqlServer
                result.numErr = 0;

                // Se define el mensaje de error
                result.descErr = ex.Message;

                // Se define estatus de transaccion
                result.ok = false;
            }

            return result;
        }


        /// <summary>
        /// Ejecuta una sql que no devuelve datos (update, delete, insert).
        /// </summary>
        /// <param name="SqlQuery">sentencia sql a ejecutar</param>
        /// <param name="FilasAfectadas">Fila afectadas por la sentencia SQL</param>
        /// <returns></returns>
        public static ManejoSql EjecutaSQL(string SqlQuery, ref int FilasAfectadas, MySqlCommand cmd)
        {
            ManejoSql result = new ManejoSql();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = SqlQuery;

                // regresa las filas afectadas
                FilasAfectadas = cmd.ExecuteNonQuery();

                result.ok = true;
            }
            catch (MySqlException sqlex)
            {
                // se define el numero de error segun SqlServer
                result.numErr = sqlex.Number;

                // Se define el mensaje de error
                result.descErr = sqlex.Message;

                // Se define estatus de transaccion
                result.ok = false;
            }
            catch (Exception ex)
            {
                // se define el numero de error segun SqlServer
                result.numErr = 0;

                // Se define el mensaje de error
                result.descErr = ex.Message;

                // Se define estatus de transaccion
                result.ok = false;
            }

            return result;
        }


        public void agregarDetalle(string mensaje, TextBox tbResultados)
        {
            // la instruccion textbox.Paste() pega un texto en el TexBox y situa el cursor al final de todo el mensaje
            // solo que traba la aplicacion, no se deja de ejecutar pero si se le da click en alguna
            // parte de la aplicacion se pasma ya no muestra el texto pegado hasta que acabe de  

            //this.tbResultados.Paste(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + mensaje + Environment.NewLine);

            tbResultados.AppendText(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + mensaje + Environment.NewLine);

            Application.DoEvents();

        }

        public bool teclaEnter(KeyPressEventArgs tecla)
        {
            try
            {
                bool resultado = false;
                if ((int)tecla.KeyChar == (int)Keys.Enter)
                {
                    resultado = true;
                }
                return resultado;
            }
            catch (Exception x)
            { throw x; }
        }
    }

    public class Generales
    {
        Validador validador = new Validador();
        public void limpiaControles(Panel pn)
        {
            try
            {
                foreach (Control ctrl in pn.Controls)
                {
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                    {
                        ComboBox cmb = ((ComboBox)ctrl);
                        cmb.SelectedIndex = -1;
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        TextBox texto = ((TextBox)ctrl);
                        texto.Text = "";
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
                    {
                        DateTimePicker dtp = ((DateTimePicker)ctrl);
                        dtp.Value = DateTime.Now;
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.GroupBox")
                    {
                        limpiaControlesG((GroupBox)ctrl);
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.DataGridView")
                    {
                        DataGridView dgv = ((DataGridView)ctrl);
                        dgv.Columns.Clear();
                        dgv.DataSource = null;
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.Label")
                    {
                        Label lbl = ((Label)ctrl);
                        lbl.Text = "";
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public void limpiaControlesG(GroupBox gb)
        {
            try
            {
                foreach (Control ctrl in gb.Controls)
                {
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.ComboBox")
                    {
                        ComboBox cmb = ((ComboBox)ctrl);
                        cmb.SelectedIndex = -1;
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.TextBox")
                    {
                        TextBox texto = ((TextBox)ctrl);
                        texto.Text = "";
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.DateTimePicker")
                    {
                        DateTimePicker dtp = ((DateTimePicker)ctrl);
                        dtp.Value = DateTime.Now;
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.DataGridView")
                    {
                        DataGridView dgv = ((DataGridView)ctrl);
                        dgv.Columns.Clear();
                        dgv.DataSource = null;
                    }
                    if (ctrl.GetType().ToString() == "System.Windows.Forms.GroupBox")
                    {
                        limpiaControlesG((GroupBox)ctrl);
                    }
                }
            }
            catch (Exception ex)
            { MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        public bool teclapresionda(KeyPressEventArgs tecla)
        {
            try
            {
                bool resultado = true;
                if (Char.IsLetter(tecla.KeyChar))
                    resultado = true;
                //tecla.Handled = true;
                if ((Char.IsNumber(tecla.KeyChar) || Char.IsPunctuation(tecla.KeyChar)) || tecla.KeyChar.ToString() == "\b")
                    resultado = false;

                return resultado;
            }
            catch (Exception x)
            { throw x; }
        }

        public bool teclaNumero(KeyPressEventArgs tecla)
        {
            try
            {
                bool resultado = false;
                if (!validador.EsNumeroEntero(tecla.KeyChar.ToString()) && tecla.KeyChar.ToString() != "\b")
                {
                    resultado = true;
                }
                return resultado;
            }
            catch (Exception x)
            { throw x; }
        }

        public bool teclaLetra(KeyPressEventArgs tecla)
        {
            try
            {
                bool resultado = false;
                if (Char.IsLetter(tecla.KeyChar) || tecla.KeyChar.ToString() == "\b")
                    resultado = false;
                return resultado;
            }
            catch (Exception x)
            { throw x; }
        }

    }

    public class Validador
    {
        public bool EsNumeroEntero(string strIn)
        {
            try
            {
                int.Parse(strIn);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EsNumerico(string strIn)
        {
            try
            {
                decimal.Parse(strIn);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EsPunto(string str)
        {
            try
            {
                decimal.Parse(str);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EsNumericoNull(string strIn)
        {
            try
            {
                if (strIn == "") return true;
                double.Parse(strIn);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public double doubleConv(string cantidad)
        {
            try
            {
                if (cantidad.Trim() == "") return 0;
                cantidad = Regex.Replace(cantidad, @"[^\d\.]", "");
                double paso;
                double.TryParse(cantidad, out paso);
                return paso;
            }
            catch (Exception E)
            {
                throw E;
            }
        }
        public decimal decimalConv(string cantidad)
        {
            try
            {
                if (cantidad.Trim() == "") return 0;
                cantidad = Regex.Replace(cantidad, @"[^\d\.]", "");
                decimal paso;
                decimal.TryParse(cantidad, out paso);
                return paso;
            }
            catch (Exception E)
            {
                throw E;
            }
        }
        public int Numerico(string cantidad)
        {
            try
            {
                if (cantidad.Trim() == "") return 0;
                cantidad = Regex.Replace(cantidad, @"[^\d\.]", "");
                int paso;
                int.TryParse(cantidad, out paso);
                return paso;
            }
            catch (Exception E)
            {
                throw E;
            }
        }
        public String CleanInput(string strIn)
        {
            return Regex.Replace(strIn, @"[^\w\.\-\%\s]", "");
        }
        public bool EsAoB(string strIn)
        {
            if (strIn == "A" || strIn == "B")
                return true;
            else
                return false;
        }
    }

    public class Efectos
    {
        public void MouseLeaveEfectoPE(DevExpress.XtraEditors.PictureEdit pb, Bitmap imagen)
        {
            try
            {
                pb.Image = imagen;
                pb.Properties.PictureAlignment = ContentAlignment.MiddleCenter;
            }
            catch (Exception x)
            { throw x; }
        }
    }

    public class Checador
    {
        Utilerias objUtilerias = new Utilerias();
        //public zkemkeeper.CZKEMClass axCZKEM1 = new zkemkeeper.CZKEMClass();
        private SupportBiometricType _supportBiometricType = new SupportBiometricType();
        private static bool bIsConnected = false;//the boolean value identifies whether the device is connected
        private static int iMachineNumber = 1; private static int idwErrorCode = 0; 
        private string _biometricType = string.Empty;

        //Conexion al Checador
        public DescargarChecadas.Modelos.Estatus Conectar(TextBox lblOutputInfo, string ip, int port, int commKey, bool conectado, zkemkeeper.CZKEMClass axCZKEM1)
        {
            if (ip == "") //"" || port == 0 || commKey == 0
            {
                objUtilerias.agregarDetalle("IP Incorrecta", lblOutputInfo);
                return DescargarChecadas.Modelos.Estatus.ERROR;
            }

            if (Convert.ToInt32(port) <= 0 || Convert.ToInt32(port) > 65535)
            {
                objUtilerias.agregarDetalle("Puerto Incorrecto!", lblOutputInfo);
                return DescargarChecadas.Modelos.Estatus.ERROR;
            }

            if (Convert.ToInt32(commKey) < 0 || Convert.ToInt32(commKey) > 999999)
            {
                objUtilerias.agregarDetalle("*CommKey illegal!", lblOutputInfo);
                return DescargarChecadas.Modelos.Estatus.ERROR;
            }

            int idwErrorCode = 0;

            axCZKEM1.SetCommPassword(Convert.ToInt32(commKey));

            if (axCZKEM1.Connect_Net(ip, Convert.ToInt32(port)) == true)
            {
                SetConnectState(true);
                sta_RegRealTime(lblOutputInfo, axCZKEM1);
                //objUtilerias.agregarDetalle("Conectado al Checador", lblOutputInfo);

                //get Biotype
                sta_getBiometricType(axCZKEM1);

                return DescargarChecadas.Modelos.Estatus.CONECTADO;
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                objUtilerias.agregarDetalle("*No se pudo conectar al checador, Código Error=" + idwErrorCode.ToString(), lblOutputInfo);
                return DescargarChecadas.Modelos.Estatus.ERROR;
            }
        }

        public DescargarChecadas.Modelos.Estatus Desconectar(TextBox lblOutputInfo, bool conectado, zkemkeeper.CZKEMClass axCZKEM1)
        {
            try
            {
                Estatus RES = new Estatus();
                RES = Estatus.ERROR;
                if (conectado == true)
                {
                    axCZKEM1.Disconnect();
                    sta_UnRegRealTime(axCZKEM1);
                    SetConnectState(false);
                    objUtilerias.agregarDetalle("Desconectado del Checador", lblOutputInfo);
                    RES = DescargarChecadas.Modelos.Estatus.DESCONECTADO; //disconnect
                }

                return RES;
            }
            catch (Exception X) { throw X; }
        }

        public List<AttLogs> ObtenerChecadas(TextBox txt, zkemkeeper.CZKEMClass axCZKEM1)
        {
            DescargarChecadas.Modelos.Response respuesta = new DescargarChecadas.Modelos.Response();
            List<AttLogs> attLogsList = new List<AttLogs>();
            if (GetConnectState() == false)
            {
                new Utilerias().agregarDetalle("No se ha conectado al checador", txt);
                respuesta.error = "- 1024";
            }

            respuesta.resultado = "0";

            axCZKEM1.EnableDevice(GetMachineNumber(), false);//disable the device

            string sdwEnrollNumber = "";
            int idwVerifyMode = 0;
            int idwInOutMode = 0;
            int idwYear = 0;
            int idwMonth = 0;
            int idwDay = 0;
            int idwHour = 0;
            int idwMinute = 0;
            int idwSecond = 0;
            int idwWorkcode = 0;

            if (axCZKEM1.ReadGeneralLogData(GetMachineNumber()))
            {
                while (axCZKEM1.SSR_GetGeneralLogData(GetMachineNumber(), out sdwEnrollNumber, out idwVerifyMode,
                            out idwInOutMode, out idwYear, out idwMonth, out idwDay, out idwHour, out idwMinute, out idwSecond, ref idwWorkcode))//get records from the memory
                {
                    AttLogs attLogs = new AttLogs();
                    attLogs.enrolIdNumber = (int)Convert.ToInt16(sdwEnrollNumber);
                    string str = idwYear.ToString() + "-" + idwMonth.ToString() + "-" + idwDay.ToString() + " " + idwHour.ToString() + ":" + idwMinute.ToString();
                    attLogs.fecha = Convert.ToDateTime(str);
                    attLogsList.Add(attLogs);
                }
                respuesta.resultado = "1";
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                respuesta.error = idwErrorCode.ToString();

                if (idwErrorCode != 0)
                {
                    new Utilerias().agregarDetalle("*Falla en lectura ,Codigo Error: " + respuesta.error, txt);
                }
                else
                {
                    new Utilerias().agregarDetalle("No se encontraron datos en el checador", txt);
                }
            }

            axCZKEM1.EnableDevice(GetMachineNumber(), true);//enable the device

            return attLogsList;
        }

        public bool GetConnectState()
        {
            return bIsConnected;
        }
        public void SetConnectState(bool state)
        {
            bIsConnected = state;
            //connected = state;
        }
        public int GetMachineNumber()
        {
            return iMachineNumber;
        }

        public void sta_UnRegRealTime(zkemkeeper.CZKEMClass axCZKEM1)
        {
            axCZKEM1.OnFinger -= new zkemkeeper._IZKEMEvents_OnFingerEventHandler(axCZKEM1_OnFinger);
            axCZKEM1.OnVerify -= new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(axCZKEM1_OnVerify);
            axCZKEM1.OnAttTransactionEx -= new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
            axCZKEM1.OnFingerFeature -= new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(axCZKEM1_OnFingerFeature);
            axCZKEM1.OnDeleteTemplate -= new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(axCZKEM1_OnDeleteTemplate);
            axCZKEM1.OnNewUser -= new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(axCZKEM1_OnNewUser);
            axCZKEM1.OnHIDNum -= new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(axCZKEM1_OnHIDNum);
            axCZKEM1.OnAlarm -= new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(axCZKEM1_OnAlarm);
            axCZKEM1.OnDoor -= new zkemkeeper._IZKEMEvents_OnDoorEventHandler(axCZKEM1_OnDoor);
            axCZKEM1.OnEnrollFingerEx -= new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(axCZKEM1_OnEnrollFingerEx);
            //this.axCZKEM1.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(axCZKEM1_OnWriteCard);
            //this.axCZKEM1.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(axCZKEM1_OnEmptyCard);
            //this.axCZKEM1.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(axCZKEM1_OnHIDNum);
            //this.axCZKEM1.OnAttTransaction -= new zkemkeeper._IZKEMEvents_OnAttTransactionEventHandler(axCZKEM1_OnAttTransaction);
            //this.axCZKEM1.OnKeyPress += new zkemkeeper._IZKEMEvents_OnKeyPressEventHandler(axCZKEM1_OnKeyPress);
            //this.axCZKEM1.OnEnrollFinger += new zkemkeeper._IZKEMEvents_OnEnrollFingerEventHandler(axCZKEM1_OnEnrollFinger);

        }

        public void sta_getBiometricType(zkemkeeper.CZKEMClass axCZKEM1)
        {
            string result = string.Empty;
            result = sta_getSysOptions("BiometricType", axCZKEM1);
            if (!string.IsNullOrEmpty(result))
            {
                _supportBiometricType.fp_available = result[1] == '1';
                _supportBiometricType.face_available = result[2] == '1';
                if (result.Length >= 9)
                {
                    _supportBiometricType.fingerVein_available = result[7] == '1';
                    _supportBiometricType.palm_available = result[8] == '1';
                }
            }
            _biometricType = result;
        }

        private string sta_getSysOptions(string option, zkemkeeper.CZKEMClass axCZKEM1)
        {
            string value = string.Empty;
            axCZKEM1.GetSysOption(iMachineNumber, option, out value);
            return value;
        }

        public int sta_RegRealTime(TextBox lblOutputInfo, zkemkeeper.CZKEMClass axCZKEM1)
        {
            if (GetConnectState() == false)
            {
                objUtilerias.agregarDetalle("No se ha conectado al Checador", lblOutputInfo);
                return -1024;
            }

            int ret = 0;

            if (axCZKEM1.RegEvent(GetMachineNumber(), 65535))//Here you can register the realtime events that you want to be triggered(the parameters 65535 means registering all)
            {
                ////common interface
                //this.axCZKEM1.OnFinger += new zkemkeeper._IZKEMEvents_OnFingerEventHandler(axCZKEM1_OnFinger);
                //this.axCZKEM1.OnVerify += new zkemkeeper._IZKEMEvents_OnVerifyEventHandler(axCZKEM1_OnVerify);
                //this.axCZKEM1.OnFingerFeature += new zkemkeeper._IZKEMEvents_OnFingerFeatureEventHandler(axCZKEM1_OnFingerFeature);
                //this.axCZKEM1.OnDeleteTemplate += new zkemkeeper._IZKEMEvents_OnDeleteTemplateEventHandler(axCZKEM1_OnDeleteTemplate);
                //this.axCZKEM1.OnNewUser += new zkemkeeper._IZKEMEvents_OnNewUserEventHandler(axCZKEM1_OnNewUser);
                //this.axCZKEM1.OnHIDNum += new zkemkeeper._IZKEMEvents_OnHIDNumEventHandler(axCZKEM1_OnHIDNum);
                //this.axCZKEM1.OnAlarm += new zkemkeeper._IZKEMEvents_OnAlarmEventHandler(axCZKEM1_OnAlarm);
                //this.axCZKEM1.OnDoor += new zkemkeeper._IZKEMEvents_OnDoorEventHandler(axCZKEM1_OnDoor);

                ////only for color device
                //this.axCZKEM1.OnAttTransactionEx += new zkemkeeper._IZKEMEvents_OnAttTransactionExEventHandler(axCZKEM1_OnAttTransactionEx);
                //this.axCZKEM1.OnEnrollFingerEx += new zkemkeeper._IZKEMEvents_OnEnrollFingerExEventHandler(axCZKEM1_OnEnrollFingerEx);

                ////only for black&white device
                //this.axCZKEM1.OnAttTransaction -= new zkemkeeper._IZKEMEvents_OnAttTransactionEventHandler(axCZKEM1_OnAttTransaction);
                //this.axCZKEM1.OnWriteCard += new zkemkeeper._IZKEMEvents_OnWriteCardEventHandler(axCZKEM1_OnWriteCard);
                //this.axCZKEM1.OnEmptyCard += new zkemkeeper._IZKEMEvents_OnEmptyCardEventHandler(axCZKEM1_OnEmptyCard);
                //this.axCZKEM1.OnKeyPress += new zkemkeeper._IZKEMEvents_OnKeyPressEventHandler(axCZKEM1_OnKeyPress);
                //this.axCZKEM1.OnEnrollFinger += new zkemkeeper._IZKEMEvents_OnEnrollFingerEventHandler(axCZKEM1_OnEnrollFinger);


                ret = 1;
            }
            else
            {
                axCZKEM1.GetLastError(ref idwErrorCode);
                ret = idwErrorCode;

                if (idwErrorCode != 0)
                {
                    objUtilerias.agregarDetalle("*RegEvent failed,ErrorCode: " + idwErrorCode.ToString(), lblOutputInfo);
                }
                else
                {
                    objUtilerias.agregarDetalle("*No Se encontraron datos en el checador", lblOutputInfo);
                }
            }
            return ret;
        }


        #region Por Explorar
        void axCZKEM1_OnFinger()
        {
            //gRealEventListBox.Items.Add("OnFinger event ");

            throw new NotImplementedException();
        }
        void axCZKEM1_OnVerify(int UserID)
        {
            if (UserID != -1)
            {
                //gRealEventListBox.Items.Add("User fingerprint verified... UserID=" + UserID.ToString());
            }
            else
            {
                //gRealEventListBox.Items.Add("Failed to verify... ");
            }

            throw new NotImplementedException();
        }
        //Si su huella dactilar (o su tarjeta) pasa la verificación, este evento se activará, sólo para el dispositivo de color
        void axCZKEM1_OnAttTransactionEx(string EnrollNumber, int IsInValid, int AttState, int VerifyMethod, int Year, int Month, int Day, int Hour, int Minute, int Second, int WorkCode)
        {
            string time = Year + "-" + Month + "-" + Day + " " + Hour + ":" + Minute + ":" + Second;

            //gRealEventListBox.Items.Add("Verify OK.UserID=" + EnrollNumber + " isInvalid=" + IsInValid.ToString() + " state=" + AttState.ToString() + " verifystyle=" + VerifyMethod.ToString() + " time=" + time);

            throw new NotImplementedException();
        }
        void axCZKEM1_OnFingerFeature(int Score)
        {
            //gRealEventListBox.Items.Add("Press finger score=" + Score.ToString());

            throw new NotImplementedException();
        }
        void axCZKEM1_OnDeleteTemplate(int EnrollNumber, int FingerIndex)
        {
            //gRealEventListBox.Items.Add("Delete a finger template" + "...UserID=" + EnrollNumber.ToString() + "..FingerIndex=" + FingerIndex.ToString());

            throw new NotImplementedException();
        }
        void axCZKEM1_OnNewUser(int EnrollNumber)
        {
            //gRealEventListBox.Items.Add("Enroll a　new user" + "...UserID=" + EnrollNumber.ToString());

            throw new NotImplementedException();
        }
        void axCZKEM1_OnHIDNum(int CardNumber)
        {
            //gRealEventListBox.Items.Add("Card event" + "...Cardnumber=" + CardNumber.ToString());

            throw new NotImplementedException();
        }
        void axCZKEM1_OnAlarm(int AlarmType, int EnrollNumber, int Verified)
        {
            //gRealEventListBox.Items.Add("Alarm triggered" + "...AlarmType=" + AlarmType.ToString() + "...EnrollNumber=" + EnrollNumber.ToString() + "...Verified=" + Verified.ToString());

            throw new NotImplementedException();
        }
        void axCZKEM1_OnDoor(int EventType)
        {
            //gRealEventListBox.Items.Add("Door opened" + "...EventType=" + EventType.ToString());

            throw new NotImplementedException();
        }
        void axCZKEM1_OnEnrollFingerEx(string EnrollNumber, int FingerIndex, int ActionResult, int TemplateLength)
        {
            if (ActionResult == 0)
            {
                //gRealEventListBox.Items.Add("Enroll finger succeed. UserID=" + EnrollNumber.ToString() + "...FingerIndex=" + FingerIndex.ToString());

            }
            else
            {
                //gRealEventListBox.Items.Add("Enroll finger failed. Result=" + ActionResult.ToString());
            }
            throw new NotImplementedException();
        }
        #endregion

    }

    public class Employee
    {
        public string pin { get; set; }
        public string name { get; set; }
        public string password { get; set; }
        public int privilege { get; set; }
        public string cardNumber { get; set; }
    }

    public class SupportBiometricType
    {
        public bool fp_available { get; set; }
        public bool face_available { get; set; }
        public bool fingerVein_available { get; set; }
        public bool palm_available { get; set; }
    }

    public class BioTemplate
    {
        /// <summary>
        /// is valid,0:invalid,1:valid,default=1
        /// </summary>
        private int validFlag = 1;
        public virtual int valid_flag
        {
            get { return validFlag; }
            set { validFlag = value; }
        }

        /// <summary>
        /// is duress,0:not duress,1:duress,default=0
        /// </summary>
        public virtual int is_duress { get; set; }

        /// <summary>
        /// Biometric Type
        /// 0： General
        /// 1： Finger Printer
        /// 2： Face
        /// 3： Voiceprint
        /// 4： Iris
        /// 5： Retina
        /// 6： Palm prints
        /// 7： FingerVein
        /// 8： Palm Vein
        /// </summary>
        public virtual int bio_type { get; set; }

        /// <summary>
        /// template version
        /// </summary>
        public virtual string version { get; set; }

        /// <summary>
        /// data format
        /// ZK\ISO\ANSI 
        /// 0： ZK
        /// 1： ISO
        /// 2： ANSI
        /// </summary>
        public virtual int data_format { get; set; }

        /// <summary>
        /// template no
        /// </summary>
        public virtual int template_no { get; set; }

        /// <summary>
        /// template index
        /// </summary>
        public virtual int template_no_index { get; set; }

        /// <summary>
        /// template data
        /// </summary>
        public virtual string template_data { get; set; }

        /// <summary>
        /// pin
        /// </summary>
        public virtual string pin { get; set; }
    }

    public class BioType
    {
        public string name { get; set; }
        public int value { get; set; }

        public override string ToString()
        {
            return name;
        }
    }
}
