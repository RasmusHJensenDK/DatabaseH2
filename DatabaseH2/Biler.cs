using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseH2
{
    public class Biler
    {
        private string VIN { get; set; }
        private string Farve { get; set; }
        private string Mærke { get; set; }
        private string Model { get; set; }
        private string Årgang { get; set; }
        private string Beskrivelse { get; set; }
        private int BilGruppe { get; set; }
        private int Lokation { get; set; }
        private int ID { get; set; }
        private string City { get; set; }

        public Biler(string VIN, string Farve, string Mærke, string Model, int ID, string City)
        {
            this.VIN = VIN.ToString();
            this.Mærke = Mærke.ToString();
            this.Model = Model.ToString();
            this.Farve = Farve.ToString();
            this.ID = ID;
        }
        public string returnModel()
        {
            return Model;
        }
        public string returnVIN()
        {
            return VIN;
        }
        public string returnFarve()
        {
            return Farve;
        }
        public string returnMærke()
        {
            return Mærke;
        }
        public int returnID()
        {
            return ID;
        }
    }
}
