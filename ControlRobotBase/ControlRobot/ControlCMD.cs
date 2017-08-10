﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace ControlRobot
{
    class ControlCMD
    {
        public byte[] leftCMD = { 0xFD, 0x01, 0x01, 0x03, 0x88, 0x07, 0x01, 0x00, 0x10, 0x00, 0x00, 0x20, 0x01, 0x00, 0xF8 };
        public byte[] rightCMD ={ 0xFD, 0x01, 0x01, 0x03, 0x88, 0x07, 0x00, 0x00, 0x10, 0x01, 0x00, 0x20, 0x01, 0x00, 0xF8 };
        public byte[] upCMD =   { 0xFD, 0x01, 0x01, 0x03, 0x88, 0x07, 0x00, 0x00, 0x10, 0x00, 0x00, 0x20, 0x01, 0x00, 0xF8 };
        public byte[] downCMD = { 0xFD, 0x01, 0x01, 0x03, 0x88, 0x07, 0x01, 0x00, 0x10, 0x01, 0x00, 0x20, 0x01, 0x00, 0xF8 };
        public byte[] stopCMD = { 0xFD, 0x01, 0x01, 0x03, 0x88, 0x07, 0x02, 0x00, 0x10, 0x02, 0x00, 0x20, 0x01, 0x00, 0xF8 };

        public byte[] curCMD = { 0 };

        public void run(byte[] CMD, string speed){
            CMD[8] = CMD[11] = (byte)int.Parse(speed);
            curCMD = CMD;

        }
    }
}