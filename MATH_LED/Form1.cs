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
using System.Drawing.Imaging;
using System.Management;

namespace MATH_LED
{
    public partial class MATHLED : Form
    {
        static SerialPort port;
        static SerialDataReceivedEventHandler port_DataReceivedHandler;

        byte startMarker = 254;
        byte endMarker = 255;
        byte specialByte = 253;

        public MATHLED()
        {
            InitializeComponent();
            string[] ports = SerialPort.GetPortNames();
            portComboBox.Items.AddRange(ports);
            init_serial();
            colorPicker.HSV = new HSVColorPicker.HSVparam(1.5, 125, 0.5);
        }

        private void init_serial()
        {
            MATHLED.port = new SerialPort();
            MATHLED.port_DataReceivedHandler = new SerialDataReceivedEventHandler(port_DataReceived);
            MATHLED.port.DataReceived += port_DataReceivedHandler;
            //Try to find arduino and auto connect
            ManagementObjectSearcher manObjSearch = new ManagementObjectSearcher("Select * from Win32_SerialPort");
            ManagementObjectCollection manObjReturn = manObjSearch.Get();
            foreach (ManagementObject manObj in manObjReturn)
            {
                if (manObj["Description"].ToString().Contains("Arduino") && port.IsOpen == false)
                {
                    Console.WriteLine("Found Arduino on: " + manObj["Name"].ToString());
                    //Disable button
                    string commPortTarget = manObj["DeviceID"].ToString();
                    toggleConnectionButton.Enabled = false;
                    portComboBox.SelectedIndex = portComboBox.Items.IndexOf(commPortTarget);
                    //MATHLED.port.PortName = commPortTarget;
                    //MATHLED.port.BaudRate = 57600;
                    //MATHLED.port.Open();
                    connect_serial(commPortTarget);
                    toggleConnectionButton.Enabled = true;
                    toggleConnectionButton.Text = "Disconnect";
                }
            }
        }

        private void connect_serial(string port_name)
        {
            if (MATHLED.port.IsOpen)
            {
                MATHLED.port.Close();
                Console.WriteLine("Connection Closed");
            }
            else
            {
                MATHLED.port.PortName = port_name;
                MATHLED.port.BaudRate = 57600;
                MATHLED.port.Open();
                Console.WriteLine("Connection Opened: " + port_name);
                //Refresh UI
                sendToArduino(new byte[] { 2 });
            }
        }

        private void port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            // Show all the incoming data in the port's buffer
            //byte[] data = Encoding.UTF8.GetBytes(port.ReadExisting());
            //PrintByteArray(data);
            //Console.WriteLine(Encoding.UTF8.GetString(data));
            byte[] data = receiveFromArduino();
            Console.WriteLine("Received from Arduino:");
            PrintByteArray(data);
            if (data[1] == 0)
            {
                PrintByteArray(data.Skip(2).Take(data.Length - 3).ToArray());
                Console.WriteLine(Encoding.ASCII.GetString(data.Skip(2).Take(data.Length - 3).ToArray()));
            }
            if (data[1] == 9 && data[2] == 0)
            {
                //Status update, update program - 7 params and the first should be 0
                //onoff,now_playing,delayMillis,delta,hue,saturation,value
                if (data[3] > 0) 
                {
                    powerRadioOn.CheckedChanged -= powerRadioOn_CheckedChanged;
                    powerRadioOn.Invoke((MethodInvoker)delegate { powerRadioOn.Checked = true; });
                    powerRadioOn.CheckedChanged += powerRadioOn_CheckedChanged;
                } else {
                    powerRadioOff.CheckedChanged -= powerRadioOff_CheckedChanged;
                    powerRadioOff.Invoke((MethodInvoker)delegate { powerRadioOff.Checked = true; });
                    powerRadioOff.CheckedChanged += powerRadioOff_CheckedChanged;
                }
                if (data[4] == 0) 
                {
                    typeRadioRainbow.CheckedChanged -= typeRadioRainbow_CheckedChanged;
                    typeRadioRainbow.Invoke((MethodInvoker)delegate { typeRadioRainbow.Checked = true; });
                    typeRadioRainbow.CheckedChanged += typeRadioRainbow_CheckedChanged;
                }
                else if (data[4] == 1) 
                {
                    typeRadioSolid.CheckedChanged -= typeRadioSolid_CheckedChanged;
                    typeRadioSolid.Invoke((MethodInvoker)delegate { typeRadioSolid.Checked = true; });
                    typeRadioSolid.CheckedChanged += typeRadioSolid_CheckedChanged;
                }
                else if (data[4] == 2)
                {
                    typeRadioPulse.CheckedChanged -= typeRadioPulse_CheckedChanged;
                    typeRadioPulse.Invoke((MethodInvoker)delegate { typeRadioPulse.Checked = true; });
                    typeRadioPulse.CheckedChanged += typeRadioPulse_CheckedChanged;
                }
                trackBar_Delay.ValueChanged -= trackBar_Delay_ValueChanged;
                trackBar_Delay.Invoke((MethodInvoker)delegate { trackBar_Delay.Value = data[5]; });
                trackBar_Delay.ValueChanged += trackBar_Delay_ValueChanged;
                label_Delay.Invoke((MethodInvoker)delegate { label_Delay.Text = "Delay    " + trackBar_Delay.Value; });
                trackBar_Delta.ValueChanged -= trackBar_Delta_ValueChanged;
                trackBar_Delta.Invoke((MethodInvoker)delegate { trackBar_Delta.Value = data[6]; });
                trackBar_Delta.ValueChanged += trackBar_Delta_ValueChanged;
                label_Delta.Invoke((MethodInvoker)delegate { label_Delta.Text = "Delta    " + trackBar_Delta.Value; });
                trackBar_Rate.ValueChanged -= trackBar_Rate_ValueChanged;
                trackBar_Rate.Invoke((MethodInvoker)delegate { trackBar_Rate.Value = data[7]; });
                trackBar_Rate.ValueChanged += trackBar_Rate_ValueChanged;
                label_Rate.Invoke((MethodInvoker)delegate { label_Rate.Text = "Rate     " + trackBar_Rate.Value; });
                //Set colors as floats
                double tempHue = (data[8] / 255.0) * 6; //Hue should be between 0 and 6
                double tempSat = data[9] / 255.0; //Sat and val should be between 0 and 1
                double tempVal = data[10] / 255.0;
                //Console.WriteLine("Hue: " + tempHue);
                colorPicker.HSV = new HSVColorPicker.HSVparam(tempHue, tempSat, tempVal);
            }
        }

        private void PrintByteArray(byte[] bytes)
        {
            var sb = new StringBuilder("new byte[] { ");
            foreach (var b in bytes)
            {
                sb.Append(b + ", ");
            }
            sb.Append("}");
            Console.WriteLine(sb.ToString());
        }

        private void sendToArduino(byte[] message)
        {
            if (port.IsOpen)
            {
                byte txLen = (byte)message.Length;
                List<byte> assembledMessage = new List<byte>();
                assembledMessage.Add(startMarker);
                assembledMessage.Add(txLen);
                assembledMessage.AddRange(encodeHighBytes(message));
                assembledMessage.Add(endMarker);
                byte[] bytesToSend = assembledMessage.ToArray();
                Console.WriteLine("Sending to Arduino:    ");
                PrintByteArray(bytesToSend);
                port.Write(bytesToSend, 0, bytesToSend.Length);
            } 
        }

        private byte[] receiveFromArduino()
        {
            List<byte> buffer = new List<byte>();
            byte x = (byte)'z';
            int byteCount = -1;
            // Wait for start byte
            //Console.WriteLine("Received Byte, waiting for start");
            while ((byte)x != startMarker && (byte)x != endMarker)
            {
                //Console.WriteLine("Received Byte, start");
                x = (byte)port.ReadByte(); //port.Read(buffer,0,1);
                //Console.WriteLine("Received Byte, " + x);
                // Save data until end marker found
                while ((byte)x != endMarker)
                {
                    //Console.WriteLine("Received Byte, byte is not end");
                    buffer.Add(x);
                    x = (byte)port.ReadByte(); //x = port.Read(buffer, 0, 1);
                    //Console.WriteLine("Received Byte, " + x);
                    byteCount++;
                }
                //Console.WriteLine("Received Byte, end");
                // Save end marker
                buffer.Add(x);
            }
            //Console.WriteLine("Received Byte, exiting loops");
            return decodeHighBytes(buffer.ToArray());
        }

        private byte[] encodeHighBytes(byte[] input)
        {
            List<byte> output = new List<byte>();
            int inputLen = input.Length;
            for (int i = 0; i < inputLen; i++)
            {
                int x = input[i];
                if (x >= (int)specialByte)
                {
                    output.Add(specialByte);
                    output.Add((byte)(x - specialByte));
                }
                else
                {
                    output.Add((byte)x);
                }
            }
            //Console.WriteLine("Encode: input:  ");
            //PrintByteArray(input);
            //Console.WriteLine("Encode: output: ");
            //PrintByteArray(output.ToArray());
            return output.ToArray();
        }

        private byte[] decodeHighBytes(byte[] input)
        {
            List<byte> output = new List<byte>();
            int inputLen = input.Length;
            int x;
            for (int i = 0; i < inputLen; i++)
            {
                if ((int)input[i] == specialByte)
                {
                    i++;
                    x = (int)(specialByte + (int)input[i]);
                }
                else
                {
                    x = (int)input[i];
                }
                output.Add((byte)x);
            }
            return output.ToArray();
        }

        private void typeRadioSolid_CheckedChanged(object sender, EventArgs e) //Solid
        {
            if (typeRadioSolid.Checked)
            {
                sendToArduino(new byte[] { 50 });
            }
        }

        private void typeRadioRainbow_CheckedChanged(object sender, EventArgs e) //Rainbow
        {
            if (typeRadioRainbow.Checked)
            {
                sendToArduino(new byte[] { 51 });
            }
        }

        private void typeRadioPulse_CheckedChanged(object sender, EventArgs e) //Cylon/Pulse
        {

            if (typeRadioPulse.Checked)
            {
                sendToArduino(new byte[] { 52 });
            }
        }

        private void powerRadioOn_CheckedChanged(object sender, EventArgs e)
        {
            if (powerRadioOn.Checked)
            {
                sendToArduino(new byte[] { 1 });
            }
        }

        private void powerRadioOff_CheckedChanged(object sender, EventArgs e)
        {
            if (powerRadioOff.Checked)
            {
                sendToArduino(new byte[] { 0 });
            }
        }

        private void toggleConnectionButton_Click(object sender, EventArgs e)
        {
            toggleConnectionButton.Enabled = false;
            if (port.IsOpen)
            {
                toggleConnectionButton.Text = "Connect";
            }
            else
            {
                toggleConnectionButton.Text = "Disconnect";
            }
            String port_name = portComboBox.SelectedItem.ToString();
            connect_serial(port_name);
            toggleConnectionButton.Enabled = true;
        }

        private void colorPicker_HSVColorChanged(object sender, HSVColorChangedEventArgs e)
        {
            Console.WriteLine("Color Changed: " + e);
            HSVColorPicker.HSVparam hsvColours = colorPicker.HSV;
            // h: 0 - 6, s: 0 - 1, v: 0 - 1
            //Console.WriteLine(hsvColours.H);
            // Calculate and send H, S, V values
            int hue = (int) Math.Round((Math.Max(0, Math.Min(1, (hsvColours.H / 6))) * 255));
            int sat = (int) Math.Round(hsvColours.S * 255);
            int val = (int) Math.Round(hsvColours.V * 255);
            //Console.WriteLine(hue); 
            sendToArduino(new byte[] { 4, (byte)hue, (byte)sat, (byte)val });
        }

        private void button_Refresh_Clicked(object sender, EventArgs e)
        {
            sendToArduino(new byte[] { 2 });
        }

        private void trackBar_Delay_ValueChanged(object sender, EventArgs e)
        {
            sendToArduino(new byte[] { 8, (byte)trackBar_Delay.Value });
            label_Delay.Text = "Delay    " + trackBar_Delay.Value; 
        }

        private void trackBar_Delta_ValueChanged(object sender, EventArgs e)
        {
            sendToArduino(new byte[] { 9, (byte)trackBar_Delta.Value });
            label_Delta.Text = "Delta    " + trackBar_Delta.Value;
        }

        private void trackBar_Rate_ValueChanged(object sender, EventArgs e)
        {
            sendToArduino(new byte[] {10, (byte)trackBar_Rate.Value });
            label_Rate.Text = "Rate     " + trackBar_Rate.Value;
        }
    }



    /**
     * HSV color picker form component https://github.com/tk-yoshimura/ColorFieldGUI
     **/
    public class ColorPicker
    {
        public int Size { get; }

        public int CenterX => Size / 2;
        public int CenterY => Size / 2;
        public int InnerRadius => Size * 5 / 12;
        public int OuterRadius => Size / 2;

        public ColorPicker(int size = 400)
        {
            Size = size;
        }

        public enum Area
        {
            Outside,
            Wheel,
            Triangle
        }

        public struct PickResult
        {
            public Area Area { get; set; }
            public double? Hue { get; set; }
            public double? Sat { get; set; }
            public double? Val { get; set; }
        }

        public PickResult Pick(double x, double y)
        {
            var distanceFromCenter = Math.Sqrt((x - CenterX) * (x - CenterX) + (y - CenterY) * (y - CenterY));
            var sqrt3 = Math.Sqrt(3);
            if (distanceFromCenter > OuterRadius)
            {
                // Outside
                return new PickResult { Area = Area.Outside };
            }
            else if (distanceFromCenter > InnerRadius)
            {
                // Wheel
                var angle = Math.Atan2(y - CenterY, x - CenterX) + Math.PI / 2;
                if (angle < 0) angle += 2 * Math.PI;
                var hue = angle;
                return new PickResult { Area = Area.Wheel, Hue = hue };
            }
            else
            {
                // Inside
                var x1 = (x - CenterX) * 1.0 / InnerRadius;
                var y1 = (y - CenterY) * 1.0 / InnerRadius;
                if (0 * x1 + 2 * y1 > 1) return new PickResult { Area = Area.Outside };
                else if (sqrt3 * x1 + (-1) * y1 > 1) return new PickResult { Area = Area.Outside };
                else if (-sqrt3 * x1 + (-1) * y1 > 1) return new PickResult { Area = Area.Outside };
                else
                {
                    // Triangle
                    var sat = (1 - 2 * y1) / (sqrt3 * x1 - y1 + 2);
                    var val = (sqrt3 * x1 - y1 + 2) / 3;

                    return new PickResult { Area = Area.Triangle, Sat = sat, Val = val };
                }
            }
        }

        public Image DrawImage(double hue = 0.0, double sat = 1.0, double val = 1.0)
        {
            var img = new Bitmap(Size, Size, PixelFormat.Format32bppArgb);
            for (int y = 0; y < Size; y++)
            {
                for (int x = 0; x < Size; x++)
                {
                    Color color;
                    var result = Pick(x, y);
                    if (result.Area == Area.Outside)
                    {
                        // Outside
                        color = Color.Transparent;
                    }
                    else if (result.Area == Area.Wheel)
                    {
                        // Wheel
                        color = HSV(result.Hue.Value, sat, val, 1);
                    }
                    else
                    {
                        // Triangle
                        color = HSV(hue, result.Sat.Value, result.Val.Value, 1);
                    }
                    img.SetPixel(x, y, color);
                }
            }

            return img;
        }

        private Color HSV(double hue, double sat, double val, double alpha)
        {
            var chroma = val * sat;
            var step = Math.PI / 3;
            var interm = chroma * (1 - Math.Abs((hue / step) % 2.0 - 1));
            var shift = val - chroma;
            if (hue < 1 * step) return RGB(shift + chroma, shift + interm, shift + 0, alpha);
            if (hue < 2 * step) return RGB(shift + interm, shift + chroma, shift + 0, alpha);
            if (hue < 3 * step) return RGB(shift + 0, shift + chroma, shift + interm, alpha);
            if (hue < 4 * step) return RGB(shift + 0, shift + interm, shift + chroma, alpha);
            if (hue < 5 * step) return RGB(shift + interm, shift + 0, shift + chroma, alpha);
            return RGB(shift + chroma, shift + 0, shift + interm, alpha);
        }

        private Color RGB(double red, double green, double blue, double alpha)
        {
            return Color.FromArgb(
                Math.Min(255, (int)(alpha * 256)),
                Math.Min(255, (int)(red * 256)),
                Math.Min(255, (int)(green * 256)),
                Math.Min(255, (int)(blue * 256)));
        }

        public PointD GetWheelPosition(double hue)
        {
            double middleRadius = (InnerRadius + OuterRadius) / 2;
            return new PointD
            {
                X = CenterX + middleRadius * Math.Sin(hue),
                Y = CenterY - middleRadius * Math.Cos(hue)
            };
        }

        public PointD GetTrianglePosition(double sat, double val)
        {
            var sqrt3 = Math.Sqrt(3);
            return new PointD
            {
                X = CenterX + InnerRadius * (2 * val - sat * val - 1) * sqrt3 / 2,
                Y = CenterY + InnerRadius * (1 - 3 * sat * val) / 2
            };
        }
    }

    public class PointD
    {
        public double X { get; set; }
        public double Y { get; set; }
    }
}
