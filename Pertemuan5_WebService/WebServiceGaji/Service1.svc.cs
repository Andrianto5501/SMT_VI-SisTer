using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WebServiceGaji
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {
        public double Gaji(int gapok, int tunjangan, int potongan, double pph)
        {
            double PPH = pph / 100;
            double pajak = PPH * gapok;
            double total = ((gapok + tunjangan) - potongan) - pajak;
            return total;
        }
    }
}
