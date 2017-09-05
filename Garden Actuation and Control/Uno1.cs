using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using ArduinoDriver.SerialProtocol;
using ArduinoUploader.Hardware;


namespace Garden_Actuation_and_Control
{
    public static class Uno1
    {
        public static ArduinoDriver.ArduinoDriver driver = new ArduinoDriver.ArduinoDriver(ArduinoModel.UnoR3, true);
    }
}
