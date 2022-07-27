using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestClientLibray.Dtos
{
    public class ProductDto
    {
        public ProductDto(int idP, string identfierP, string descriptionP, string descriptionENP, decimal priceP, string unitP, decimal availableSTKP, decimal vatP, bool inactiveP, int componentTypeP)
        {

            this.Pid = idP;
            this.Pidentifier = identfierP;
            this.Pdescription = descriptionP;
            this.PdescriptionEN = descriptionENP;
            this.Pprice = priceP;
            this.Punit = unitP;
            this.PavailableSTK = availableSTKP;
            this.Pvat = vatP;
            this.Pinactive = inactiveP;
            this.PcomponentType = componentTypeP;
        }


        private readonly int Pid;
        private readonly string Pidentifier;
        private readonly string Pdescription;
        private readonly string PdescriptionEN;
        private readonly decimal Pprice;
        private readonly string Punit;
        private readonly decimal PavailableSTK;
        private readonly decimal Pvat;
        private readonly bool Pinactive;
        private readonly int PcomponentType;


        public int id { get { return this.Pid; } }
        public string identifier { get { return this.Pidentifier; } }
        public string description { get { return this.Pdescription; } }
        public string descriptionEN { get { return this.PdescriptionEN; } }
        public decimal price { get { return this.Pprice; } }
        public string unit { get { return this.Punit; } }
        public decimal availableSTK { get { return this.PavailableSTK; } }
        public decimal vat { get { return this.Pvat; } }
        public bool inactive { get { return this.Pinactive; } }
        public int componentType { get { return this.PcomponentType; } }
    
    }
}
