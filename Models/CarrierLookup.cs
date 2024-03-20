
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Net.Http;
namespace SaferWatchWebApp.Models

{

    [XmlRoot("CarrierLookup", Namespace = "CarrierService32")]
    public class CarrierLookup
    {
        [XmlElement("ResponseDO")]
        public ResponseDO ResponseDO { get; set; }

        [XmlElement("CarrierDetails")]
        public CarrierDetails CarrierDetails { get; set; }

    }

    public class ResponseDO
    {
        [XmlElement("status")]
        public string Status { get; set; }

        [XmlElement("action")]
        public string Action { get; set; }

        [XmlElement("code")]
        public string Code { get; set; }

        [XmlElement("displayMsg")]
        public string DisplayMsg { get; set; }

        [XmlElement("techMsg")]
        public string TechMsg { get; set; }
    }

    public class CarrierDetails
    {
        [XmlElement("docketNumber")]
        public string DocketNumber { get; set; }

        [XmlElement("dotNumber")]
        public DotNumber DotNumber { get; set; }

        [XmlElement("carrierType")]
        public string CarrierType { get; set; }

        [XmlElement("Identity")]
        public Identity Identity { get; set; }

        [XmlElement("Authority")]
        public Authority Authority { get; set; }

        [XmlElement("FMCSAInsurance")]
        public FMCSAInsurance FMCSAInsurance { get; set; }

        [XmlElement("CertData")]
        public CertData CertData { get; set; }

        [XmlElement("Safety")]
        public Safety Safety { get; set; }

        [XmlElement("Inspection")]
        public Inspection Inspection { get; set; }

        [XmlElement("Crash")]
        public Crash Crash { get; set; }

        [XmlElement("Review")]
        public Review Review { get; set; }

        [XmlElement("Operation")]
        public Operation Operation { get; set; }

        [XmlElement("Cargo")]
        public Cargo Cargo { get; set; }

        [XmlElement("Drivers")]
        public Drivers Drivers { get; set; }

        [XmlElement("Equipment")]
        public Equipment Equipment { get; set; }

        [XmlElement("Other")]
        public Other Other { get; set; }

        [XmlElement("RiskAssessment")]
        public RiskAssessment RiskAssessment { get; set; }

    }

    public class DotNumber
    {
        [XmlAttribute("status")]
        public string Status { get; set; }

        [XmlText]
        public string Number { get; set; }
    }

    public class Identity
    {

        [XmlElement(ElementName = "legalName")]
        public string legalName { get; set; }

        [XmlElement(ElementName = "dbaName")]
        public string dbaName { get; set; }

        [XmlElement(ElementName = "businessStreet")]
        public string businessStreet { get; set; }

        [XmlElement(ElementName = "businessCity")]
        public string businessCity { get; set; }

        [XmlElement(ElementName = "businessState")]
        public string BusinessState { get; set; }

        [XmlElement(ElementName = "businessZipCode")]
        public string? businessZipCode { get; set; }

        [XmlElement(ElementName = "businessColonia")]
        public string businessColonia { get; set; }

        [XmlElement(ElementName = "businessCountry")]
        public string businessCountry { get; set; }

        [XmlElement(ElementName = "businessPhone")]
        public string businessPhone { get; set; }

        [XmlElement(ElementName = "businessFax")]
        public string businessFax { get; set; }

        [XmlElement(ElementName = "mailingStreet")]
        public string mailingStreet { get; set; }

        [XmlElement(ElementName = "mailingCity")]
        public string mailingCity { get; set; }

        [XmlElement(ElementName = "mailingState")]
        public string mailingState { get; set; }

        [XmlElement(ElementName = "mailingZipCode")]
        public string mailingZipCode { get; set; }

        [XmlElement(ElementName = "mailingColonia")]
        public string mailingColonia { get; set; }

        [XmlElement(ElementName = "mailingCountry")]
        public string mailingCountry { get; set; }

        [XmlElement(ElementName = "mailingPhone")]
        public string mailingPhone { get; set; }

        [XmlElement(ElementName = "mailingFax")]
        public string mailingFax { get; set; }

        [XmlElement(ElementName = "undeliverableMail")]
        public string undeliverableMail { get; set; }

        [XmlElement(ElementName = "companyRep1")]
        public string companyRep1 { get; set; }

        [XmlElement(ElementName = "companyRep2")]
        public string companyRep2 { get; set; }

        [XmlElement(ElementName = "cellPhone")]
        public string cellPhone { get; set; }

        [XmlElement(ElementName = "emailAddress")]
        public string emailAddress { get; set; }

        [XmlElement(ElementName = "dunBradstreetNum")]
        public string dunBradstreetNum { get; set; }

        [XmlElement(ElementName = "organization")]
        public string organization { get; set; }

    }

    public class Authority
    {

        [XmlElement(ElementName = "authGrantDate")]
        public DateTime? authGrantDate { get; set; }

        [XmlElement(ElementName = "commonAuthority")]
        public string? commonAuthority { get; set; }

        [XmlElement(ElementName = "commonAuthorityPending")]
        public string? commonAuthorityPending { get; set; }

        [XmlElement(ElementName = "commonAuthorityRevocation")]
        public string? commonAuthorityRevocation { get; set; }

        [XmlElement(ElementName = "contractAuthority")]
        public string? contractAuthority { get; set; }

        [XmlElement(ElementName = "contractAuthorityPending")]
        public string? contractAuthorityPending { get; set; }

        [XmlElement(ElementName = "contractAuthorityRevocation")]
        public string? contractAuthorityRevocation { get; set; }

        [XmlElement(ElementName = "brokerAuthority")]
        public string? brokerAuthority { get; set; }

        [XmlElement(ElementName = "brokerAuthorityPending")]
        public string? brokerAuthorityPending { get; set; }

        [XmlElement(ElementName = "brokerAuthorityRevocation")]
        public string? brokerAuthorityRevocation { get; set; }

        [XmlElement(ElementName = "freight")]
        public string? freight { get; set; }

        [XmlElement(ElementName = "passenger")]
        public string? passenger { get; set; }

        [XmlElement(ElementName = "householdGoods")]
        public string? householdGoods { get; set; }

        [XmlElement(ElementName = "private")]
        public string? Private { get; set; }

        [XmlElement(ElementName = "enterprise")]
        public string? enterprise { get; set; }
    }

    public class FMCSAInsurance
    {
        [XmlElement(ElementName = "bipdRequired")]
        public string? bipdRequired { get; set; }

        [XmlElement(ElementName = "bipdOnFile")]
        public string? bipdOnFile { get; set; }

        [XmlElement(ElementName = "cargoRequired")]
        public string? cargoRequired { get; set; }

        [XmlElement(ElementName = "cargoOnFile")]
        public string? cargoOnFile { get; set; }

        [XmlElement(ElementName = "bondSuretyRequired")]
        public string? bondSuretyRequired { get; set; }

        [XmlElement(ElementName = "bondSuretyOnFile")]
        public string? bondSuretyOnFile { get; set; }


        [XmlElement(ElementName = "PolicyList")]
        public PolicyList PolicyList { get; set; }
    }

    public class PolicyList
    {
        [XmlElement(ElementName = "PolicyItem")]
        public List<PolicyItem> PolicyItems { get; set; }
    }

    public class PolicyItem
    {
        [XmlElement(ElementName = "companyName")]
        public string? companyName { get; set; }

        [XmlElement(ElementName = "attnToName")]
        public string? attnToName { get; set; }

        [XmlElement(ElementName = "address")]
        public string? address { get; set; }

        [XmlElement(ElementName = "city")]
        public string? city { get; set; }

        [XmlElement(ElementName = "stateCode")]
        public string? stateCode { get; set; }

        [XmlElement(ElementName = "postalCode")]
        public string? postalCode { get; set; }

        [XmlElement(ElementName = "countryCode")]
        public string? countryCode { get; set; }

        [XmlElement(ElementName = "phone")]
        public string? phone { get; set; }

        [XmlElement(ElementName = "fax")]
        public string? fax { get; set; }

        [XmlElement(ElementName = "insuranceType")]
        public string? insuranceType { get; set; }

        [XmlElement(ElementName = "policyNumber")]
        public string? policyNumber { get; set; }

        [XmlElement(ElementName = "postedDate")]
        public string? postedDate { get; set; }

        [XmlElement(ElementName = "effectiveDate")]
        public string? effectiveDate { get; set; }

        [XmlElement(ElementName = "cancelationDate")]
        public string? cancelationDate { get; set; }

        [XmlElement(ElementName = "coverageFrom")]
        public string? coverageFrom { get; set; }

        [XmlElement(ElementName = "coverageTo")]
        public string? coverageTo { get; set; }

        [XmlElement(ElementName = "amBestRating")]
        public string? amBestRating { get; set; }
    }

    public class CertData
    {
        [XmlAttribute("status")]
        public string Status { get; set; }

        [XmlElement("Certificate")]
        public Certificate Certificate { get; set; }
    }

    public class Certificate
    {
        [XmlElement("certificateID")]
        public string CertificateID { get; set; }

        [XmlElement("producerName")]
        public string ProducerName { get; set; }

        [XmlElement("producerAddress")]
        public string ProducerAddress { get; set; }

        [XmlElement("producerCity")]
        public string ProducerCity { get; set; }

        [XmlElement("producerState")]
        public string ProducerState { get; set; }

        [XmlElement("producerZip")]
        public string ProducerZip { get; set; }

        [XmlElement("producerPhone")]
        public string ProducerPhone { get; set; }

        [XmlElement("producerFax")]
        public string ProducerFax { get; set; }

        [XmlElement("producerEmail")]
        public string ProducerEmail { get; set; }

        [XmlElement("paidFor")]
        public string PaidFor { get; set; }

        [XmlElement("Coverage")]
        public List<Coverage> Coverages { get; set; } // Assuming there can be multiple Coverage entries
    }

    public class Coverage
    {
        [XmlElement("insurerName")]
        public string InsurerName { get; set; }

        [XmlElement("type")]
        public string Type { get; set; }

        [XmlElement("policyNumber")]
        public string PolicyNumber { get; set; }

        [XmlElement("expirationDate")]
        public string ExpirationDate { get; set; }

        [XmlElement("coverageLimit")]
        public string CoverageLimit { get; set; }

        [XmlElement("deductable")]
        public string Deductable { get; set; }

        [XmlElement("referBreakdown")]
        public string ReferBreakdown { get; set; }

        [XmlElement("referBreakDeduct")]
        public string ReferBreakDeduct { get; set; }
    }

    public class Safety
    {
        [XmlElement(ElementName = "rating")]
        public string? Rating { get; set; }

        [XmlElement(ElementName = "ratingDate", DataType = "date")]
        public DateTime? RatingDate { get; set; }

        [XmlElement(ElementName = "unsafeDrvPCT")]
        public double? UnsafeDrvPCT { get; set; }

        [XmlElement(ElementName = "unsafeDrvOT")]
        public string? UnsafeDrvOT { get; set; }

        [XmlElement(ElementName = "unsafeDrvSV")]
        public string? UnsafeDrvSV { get; set; }

        [XmlElement(ElementName = "unsafeDrvAlert")]
        public string? UnsafeDrvAlert { get; set; }

        [XmlElement(ElementName = "unsafeDrvTrend")]
        public string? UnsafeDrvTrend { get; set; }

        [XmlElement(ElementName = "hosPCT")]
        public double? HosPCT { get; set; }

        [XmlElement(ElementName = "hosOT")]
        public string? HosOT { get; set; }

        [XmlElement(ElementName = "hosSV")]
        public string? HosSV { get; set; }

        [XmlElement(ElementName = "hosAlert")]
        public string? HosAlert { get; set; }

        [XmlElement(ElementName = "hosTrend")]
        public string? HosTrend { get; set; }

        [XmlElement(ElementName = "drvFitPCT")]
        public double? DrvFitPCT { get; set; }

        [XmlElement(ElementName = "drvFitOT")]
        public string? DrvFitOT { get; set; }

        [XmlElement(ElementName = "drvFitSV")]
        public string? DrvFitSV { get; set; }

        [XmlElement(ElementName = "drvFitAlert")]
        public string? DrvFitAlert { get; set; }

        [XmlElement(ElementName = "drvFitTrend")]
        public string? DrvFitTrend { get; set; }

        [XmlElement(ElementName = "controlSubPCT")]
        public double? ControlSubPCT { get; set; }

        [XmlElement(ElementName = "controlSubOT")]
        public string? ControlSubOT { get; set; }

        [XmlElement(ElementName = "controlSubSV")]
        public string? ControlSubSV { get; set; }

        [XmlElement(ElementName = "controlSubAlert")]
        public string? ControlSubAlert { get; set; }

        [XmlElement(ElementName = "controlSubTrend")]
        public string? ControlSubTrend { get; set; }

        [XmlElement(ElementName = "vehMaintPCT")]
        public double? VehMaintPCT { get; set; }

        [XmlElement(ElementName = "vehMaintOT")]
        public string? VehMaintOT { get; set; }

        [XmlElement(ElementName = "vehMaintSV")]
        public string? VehMaintSV { get; set; }

        [XmlElement(ElementName = "vehMaintAlert")]
        public string? VehMaintAlert { get; set; }

        [XmlElement(ElementName = "vehMaintTrend")]
        public string? VehMaintTrend { get; set; }
    }

    public class Inspection
    {
        [XmlElement(ElementName = "inspectVehUS")]
        public string? InspectVehUS { get; set; }

        [XmlElement(ElementName = "inspectVehOOSUS")]
        public string? InspectVehOOSUS { get; set; }

        [XmlElement(ElementName = "inspectVehOOSPctUS")]
        public string? InspectVehOOSPctUS { get; set; }

        [XmlElement(ElementName = "inspectDrvUS")]
        public string? InspectDrvUS { get; set; }

        [XmlElement(ElementName = "inspectDrvOOSUS")]
        public string? InspectDrvOOSUS { get; set; }

        [XmlElement(ElementName = "inspectDrvOOSPctUS")]
        public string? InspectDrvOOSPctUS { get; set; }

        [XmlElement(ElementName = "inspectHazUS")]
        public string? InspectHazUS { get; set; }

        [XmlElement(ElementName = "inspectHazOOSUS")]
        public string? InspectHazOOSUS { get; set; }

        [XmlElement(ElementName = "inspectHazOOSPctUS")]
        public string? InspectHazOOSPctUS { get; set; }

        [XmlElement(ElementName = "inspectIEPUS")]
        public string? InspectIEPUS { get; set; }

        [XmlElement(ElementName = "inspectIEPOOSUS")]
        public int? InspectIEPOOSUS { get; set; }

        [XmlElement(ElementName = "inspectIEPOOSPctUS")]
        public double? InspectIEPOOSPctUS { get; set; }

        [XmlElement(ElementName = "inspectTotalIEPUS")]
        public string? InspectTotalIEPUS { get; set; }

        [XmlElement(ElementName = "inspectTotalUS")]
        public string? InspectTotalUS { get; set; }

        [XmlElement(ElementName = "inspectVehCAN")]
        public string? InspectVehCAN { get; set; }

        [XmlElement(ElementName = "inspectVehOOSCAN")]
        public string? InspectVehOOSCAN { get; set; }

        [XmlElement(ElementName = "inspectVehOOSPctCAN")]
        public string? InspectVehOOSPctCAN { get; set; }

        [XmlElement(ElementName = "inspectDrvCAN")]
        public string? InspectDrvCAN { get; set; }

        [XmlElement(ElementName = "inspectDrvOOSCAN")]
        public string? InspectDrvOOSCAN { get; set; }

        [XmlElement(ElementName = "inspectDrvOOSPctCAN")]
        public string? InspectDrvOOSPctCAN { get; set; }

        [XmlElement(ElementName = "inspectTotalCAN")]
        public string? InspectTotalCAN { get; set; }
    }

    public class Crash
    {
        [XmlElement(ElementName = "crashFatalUS")]
        public string? CrashFatalUS { get; set; }

        [XmlElement(ElementName = "crashInjuryUS")]
        public string? CrashInjuryUS { get; set; }

        [XmlElement(ElementName = "crashTowUS")]
        public string? CrashTowUS { get; set; }

        [XmlElement(ElementName = "crashTotalUS")]
        public string? CrashTotalUS { get; set; }

        [XmlElement(ElementName = "crashFatalCAN")]
        public string? CrashFatalCAN { get; set; }

        [XmlElement(ElementName = "crashInjuryCAN")]
        public string? CrashInjuryCAN { get; set; }

        [XmlElement(ElementName = "crashTowCAN")]
        public string? CrashTowCAN { get; set; }

        [XmlElement(ElementName = "crashTotalCAN")]
        public string? CrashTotalCAN { get; set; }
    }

    public class Review
    {
        [XmlElement(ElementName = "reviewType")]
        public string? ReviewType { get; set; }

        [XmlElement(ElementName = "reviewDate")]
        public string? ReviewDate { get; set; }

        [XmlElement(ElementName = "reviewDocNum")]
        public string? ReviewDocNum { get; set; }

        [XmlElement(ElementName = "reviewMiles")]
        public int? ReviewMiles { get; set; }

        [XmlElement(ElementName = "mcs150Date")]
        public string? MCS150Date { get; set; }

        [XmlElement(ElementName = "mcs150MileYear")]
        public string? MCS150MileYear { get; set; }

        [XmlElement(ElementName = "mcs150Miles")]
        public string? MCS150M { get; set; }

    }

    public class Operation
    {
        [XmlElement(ElementName = "dotAddDate")]
        public string? DotAddDate { get; set; }

        [XmlElement(ElementName = "carrierOperation")]
        public string? CarrierOperation { get; set; }

        [XmlElement(ElementName = "shipperOperation")]
        public string? ShipperOperation { get; set; }

        [XmlElement(ElementName = "mxOperationType")]
        public string? MxOperationType { get; set; }

        [XmlElement(ElementName = "mxRFCNumber")]
        public string? MxRFCNumber { get; set; }

        [XmlElement(ElementName = "outOfService")]
        public string? OutOfService { get; set; }

        [XmlElement(ElementName = "outOfServiceDate")]
        public string? OutOfServiceDate { get; set; }

        [XmlElement(ElementName = "outOfServiceReason")]
        public string? OutOfServiceReason { get; set; }

        [XmlElement(ElementName = "entityCarrier")]
        public string? EntityCarrier { get; set; }
    }

    public class Cargo
    {
        [XmlElement(ElementName = "hazmatIndicator")]
        public string? HazmatIndicator { get; set; }
    }

    public class Drivers
    {
        [XmlElement(ElementName = "driversTotal")]
        public string? DriversTotal { get; set; }
    }

    public class Equipment
    {
        [XmlElement(ElementName = "trucksTotal")]
        public string? TrucksTotal { get; set; }
    }

    public class Other
    {
        [XmlElement(ElementName = "carbTru")]
        public string? CarbTru { get; set; }

        [XmlElement(ElementName = "smartway")]
        public string? Smartway { get; set; }

        [XmlElement(ElementName = "watchdogReports")]
        public string? WatchdogReports { get; set; }
    }

    public class RiskAssessment
    {
        [XmlElement(ElementName = "Overall")]
        public string? Overall { get; set; }

        [XmlElement(ElementName = "Authority")]
        public string? Authority { get; set; }
    }
}
