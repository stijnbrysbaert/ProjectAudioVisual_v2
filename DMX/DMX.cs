using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using NAudioWpfDemo;

namespace NAudioWpfDemo.DMX
{
    public class DMX
    {
        private SerialPort serial;
        public byte GET_WIDGET_PARAMS = 3;
        public byte GET_WIDGET_SN = 10;
        public byte GET_WIDGET_PARAMS_REPLY = 3;
        public byte SET_WIDGET_PARAMS = 4;
        public byte SET_DMX_RX_MODE = 5;
        public byte SET_DMX_TX_MODE = 6;
        public byte SEND_DMX_RDM_TX = 7;
        public byte RECEIVE_DMX_ON_CHANGE = 8;
        public byte RECEIVED_DMX_COS_TYPE = 9;
        public byte ONE_BYTE = 1;
        public byte DMX_START_CODE = 0x7E;
        public byte DMX_END_CODE = 0xE7;
        public int OFFSET = 0xFF;
        public byte DMX_HEADER_LENGTH = 4;
        public byte BYTE_LENGTH = 8;
        public byte HEADER_RDM_LABEL = 5;
        public byte NO_RESPONSE = 0;
        public int DMX_PACKET_SIZE = 512;
        public int DMX_DATA_LENGTH = 513;
        private char[] buffer = new char[64];

        public DMX()
        {
            serial = new SerialPort();
            string[] ports = SerialPort.GetPortNames();
            serial.PortName = ports[0];
            serial.BaudRate = 9600;
            serial.Open();
            byte[] buffer = { (byte)0 };
        }

        public String[] getPorts(string[] ports)
        {
            return ports;
        }

        public void FTDISendData(byte label, byte[] data, int length)
        {
            List<byte> header = new List<byte>();
            header.Add(DMX_START_CODE);
            header.Add(label);
            header.Add((byte)(length & OFFSET));
            header.Add((byte)(length >> BYTE_LENGTH));
            serial.Write(header.ToArray(), 0, DMX_HEADER_LENGTH);
            serial.Write(data, 0, data.Length);
            byte[] endcode = { DMX_END_CODE };
            serial.Write(endcode, 0, 1);
        }
    }
}
