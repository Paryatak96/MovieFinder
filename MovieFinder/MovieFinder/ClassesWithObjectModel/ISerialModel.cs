using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesWithObjectModel
{
    interface ISerialModel
    {
        public string Title { get; set; }
        public int TimeMinutes { get; set; }
        public int IDserial { get; set; }
        public string Director { get; set; }
        public string TypeSerial { get; set; }
        public int Seasons { get; set; }
        public DateTime DataPremiery { get; set; }
    }
}
