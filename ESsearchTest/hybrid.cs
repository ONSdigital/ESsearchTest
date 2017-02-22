using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESsearchTest
{
    public class hybrid
    {
        public List<LPI> lpi { get; set; }
        public List<PAF> paf { get; set; }
        public string uprn { get; set; }
    }

    public class LPI
    {
        public string addressBasePostal { get; set; }
        public string classificationCode { get; set; }
        public string easting { get; set; }
        public string latitude { get; set; }
        public string legalName { get; set; }
        public string level { get; set; }
        public string locality { get; set; }
        public string logicalStatus { get; set; }
        public string longitude { get; set; }
        public string lpiKey { get; set; }
        public string northing { get; set; }
        public string officialFlag { get; set; }
        public string organisation { get; set; }
        public string paoEndNumber { get; set; }
        public string paoEndSuffix { get; set; }
        public string paoStartNumber { get; set; }
        public string paoStartSuffix { get; set; }
        public string paoText { get; set; }
        public string postcodeLocator { get; set; }
        public string saoEndNumber { get; set; }
        public string saoEndSuffix { get; set; }
        public string saoStartNumber { get; set; }
        public string saoStartSuffix { get; set; }
        public string saoText { get; set; }
        public string streetDescriptor { get; set; }
        public string townName { get; set; }
        public string uprn { get; set; }
        public string usrn { get; set; }
    }

    public class PAF
    {
        public string buildingName { get; set; }
        public string buildingNumber { get; set; }
        public string changeType { get; set; }
        public string deliveryPointSuffix { get; set; }
        public string departmentName { get; set; }
        public string dependentLocality { get; set; }
        public string dependentThoroughfare { get; set; }
        public string doubleDependentLocality { get; set; }
        //public DateTime endDate { get; set; }
        //public DateTime entryDate { get; set; }
        //public DateTime lastUpdateDate { get; set; }
        public string organizationName { get; set; }
        public string poBoxNumber { get; set; }
        public string postTown { get; set; }
        public string postcode { get; set; }
        public string postcodeType { get; set; }
        public string proOrder { get; set; }
        public DateTime processDate { get; set; }
        public string recordIdentifier { get; set; }
        //public DateTime startDate { get; set; }
        public string subBuildingName { get; set; }
        public string thoroughfare { get; set; }
        public string udprn { get; set; }
        public string uprn { get; set; }
        public string welshDependentLocality { get; set; }
        public string welshDependentThoroughfare { get; set; }
        public string welshDoubleDependentLocality { get; set; }
        public string welshPostTown { get; set; }
        public string welshThoroughfare { get; set; }
    }
}