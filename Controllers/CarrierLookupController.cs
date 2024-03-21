using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Xml.Serialization;




    [ApiController]
    [Route("api/[controller]")]

    public class CarrierLookupController : ControllerBase
    {
        private readonly SaferWatchService _saferWatchService;
        private readonly HttpClient _httpClient;

        public CarrierLookupController(SaferWatchService saferWatchService, HttpClient httpClient)
        {
            _saferWatchService = saferWatchService;
            _httpClient = httpClient;
        }



        //[HttpGet("{number}")]
        //public async Task<IActionResult> GetCarrierInfo(string number)
        //{
        //    bool isSuccess = await _saferWatchService.CarrierLookupAsync(number);
        //    if (isSuccess)
        //    {

        //        return Ok("Carrier watch successfully added.");
        //    }
        //    else
        //    {            
        //        return BadRequest("Failed to add carrier watch.");
        //    }

        //}

        [HttpGet]
        public async Task<IActionResult> CarrierLookupAsync(string number)
        {
            System.Diagnostics.Debugger.Launch();
            Console.WriteLine("Testing API call");
            string baseUrl = "https://www.saferwatch.com/webservices/CarrierService32.php";
            string action = "CarrierLookup";
            string serviceKey = "DemoServiceKey";
            string customerKey = "DemoCustomerKey";

            string requestUrl = $"{baseUrl}?Action={action}&ServiceKey={serviceKey}&CustomerKey={customerKey}&number={number}";

            var response = await _httpClient.GetAsync(requestUrl);
            if (response.IsSuccessStatusCode)
            {
                //string data = await response.Content.ReadAsStringAsync();
                string data = @"
            <CarrierLookup xmlns='CarrierService32'>
                <ResponseDO>
                    <status>APPROVED</status>
                    <action>OK</action>
                    <code>SFW01483</code>
                    <displayMsg></displayMsg>
                    <techMsg></techMsg>
                </ResponseDO>
               <CarrierDetails>
		            <docketNumber>MC076184</docketNumber>
		            <dotNumber status=""ACTIVE"">51442</dotNumber>
		            <carrierType>Interstate</carrierType>
               <Identity>
			   <legalName>MID CONTINENT VAN SERVICE, INC.</legalName>
			    <dbaName></dbaName>
                <businessStreet>suite</businessStreet>
			    <businessCity>MARYLAND HEIGHTS</businessCity>
                <businessState>MO</businessState>
			    <businessZipCode>63043</businessZipCode>
                <businessColonia></businessColonia>
			    <businessCountry>US</businessCountry>
			    <businessPhone>314-616-2369</businessPhone>
			    <businessFax>314-298-0259</businessFax>
                <mailingStreet></mailingStreet>
                <mailingCity></mailingCity>
                <mailingState></mailingState>
                <mailingZipCode></mailingZipCode>
                <mailingColonia></mailingColonia>
                <mailingCountry></mailingCountry>
			    <mailingPhone></mailingPhone>
			    <mailingFax></mailingFax>
			    <undeliverableMail>No</undeliverableMail>
			    <companyRep1>ALAN A COSTELLO</companyRep1>
			    <companyRep2>KENT B COSTELLO</companyRep2>
			    <cellPhone>314-616-2369</cellPhone>
			    <emailAddress>jdavis@trans-lease.com</emailAddress>
			    <dunBradstreetNum>68551092</dunBradstreetNum>
			    <organization>Corporation</organization>
		      </Identity>
              <Authority>
			        <authGrantDate>1989-06-08</authGrantDate>
			        <commonAuthority>Active</commonAuthority>
			        <commonAuthorityPending>No</commonAuthorityPending>
			        <commonAuthorityRevocation>No</commonAuthorityRevocation>
			        <contractAuthority>Active</contractAuthority>
			        <contractAuthorityPending>No</contractAuthorityPending>
			        <contractAuthorityRevocation>No</contractAuthorityRevocation>
			        <brokerAuthority>Inactive</brokerAuthority>
			        <brokerAuthorityPending>No</brokerAuthorityPending>
			        <brokerAuthorityRevocation>No</brokerAuthorityRevocation>
			        <freight>Yes</freight>
			        <passenger>No</passenger>
			        <householdGoods>Yes</householdGoods>
			        <private>No</private>
			        <enterprise>No</enterprise>
		      </Authority>
               <FMCSAInsurance>
                    <bipdRequired>10000</bipdRequired>
			        <bipdOnFile>20000</bipdOnFile>
			        <cargoRequired>Yes</cargoRequired>
			        <cargoOnFile>Yes</cargoOnFile>
			        <bondSuretyRequired>Yes</bondSuretyRequired>
			        <bondSuretyOnFile>No</bondSuretyOnFile>
                 <PolicyList>
					 <PolicyItem>
						<companyName>NATIONAL INTERSTATE INSURANCE COMPANY</companyName>
						<attnToName>REGULATORY FILINGS CUSTOMER SERVICE</attnToName>
						<address>3250 INTERSTATE DRIVE</address>
						<city>RICHFIELD</city>
						<stateCode>OH</stateCode>
						<postalCode>44286</postalCode>
						<countryCode>US</countryCode>
						<phone>8009291500</phone>
						<fax>3306598901</fax>
						<insuranceType>BIPD</insuranceType>
						<policyNumber>CAT 0011460-00</policyNumber>
						<postedDate>2023-06-28</postedDate>
						<effectiveDate>2023-07-01</effectiveDate>
						<cancelationDate>0000-00-00</cancelationDate>
						<coverageFrom>0</coverageFrom>
						<coverageTo>1,000,000</coverageTo>
						<amBestRating>A+</amBestRating>
					</PolicyItem>	
                     <PolicyItem>
						<companyName>HARTFORD FIRE INSURANCE COMPANY</companyName>
						<attnToName>PLEASE CONTACT YOUR LOCAL AGENT</attnToName>
						<address>ONE HARTFORD PLAZA</address>
						<city>HARTFORD</city>
						<stateCode>CT</stateCode>
						<postalCode>06115</postalCode>
						<countryCode>US</countryCode>
						<phone>8605475000</phone>
						<fax></fax>
						<insuranceType>Cargo</insuranceType>
						<policyNumber>84UUMAA0127</policyNumber>
						<postedDate>2020-03-13</postedDate>
						<effectiveDate>2019-07-01</effectiveDate>
						<cancelationDate>2024-07-01</cancelationDate>
						<coverageFrom>0</coverageFrom>
						<coverageTo>5,000</coverageTo>
						<amBestRating>A+</amBestRating>
				   </PolicyItem>
			     </PolicyList>
               </FMCSAInsurance>
               <CertData status=""OK"">
					<Certificate>
						<certificateID>10236673</certificateID>
						<producerName>Arthur J Gallagher Risk Management Services, Inc</producerName>
						<producerAddress>12444 Powerscourt Drive</producerAddress>
						<producerCity>Saint Louis</producerCity>
						<producerState>MO</producerState>
						<producerZip>63131</producerZip>
						<producerPhone>314-965-4346</producerPhone>
						<producerFax>314-965-5425</producerFax>
						<producerEmail></producerEmail>
						<paidFor>No</paidFor>
						<Coverage>
							<insurerName>National Interstate Insurance Company</insurerName>
							<type>Auto</type>
							<policyNumber>CAT 0011460-00</policyNumber>
							<expirationDate>2024-07-01</expirationDate>
							<coverageLimit>1,000,000</coverageLimit>
							<deductable></deductable>
							<referBreakdown>No</referBreakdown>
							<referBreakDeduct></referBreakDeduct>
						</Coverage>
						<Coverage>
							<insurerName>Hartford Fire Insurance Company</insurerName>
							<type>Cargo</type>
							<policyNumber>84UUMAA0127</policyNumber>
							<expirationDate>2024-07-01</expirationDate>
							<coverageLimit>300,000</coverageLimit>
							<deductable>5,000</deductable>
							<referBreakdown>No</referBreakdown>
							<referBreakDeduct></referBreakDeduct>
						</Coverage>
						<Coverage>
							<insurerName>National Interstate Insurance Company</insurerName>
							<type>General</type>
							<policyNumber>GLT0014600-00</policyNumber>
							<expirationDate>2024-07-01</expirationDate>
							<coverageLimit>1,000,000</coverageLimit>
							<deductable></deductable>
							<referBreakdown>No</referBreakdown>
							<referBreakDeduct></referBreakDeduct>
						</Coverage>
						<Coverage>
							<insurerName>Redwood Fire and Casualty Insurance Co.</insurerName>
							<type>WorkersCompensation</type>
							<policyNumber>MIWC443141</policyNumber>
							<expirationDate>2024-07-01</expirationDate>
							<coverageLimit>500,000</coverageLimit>
							<deductable></deductable>
							<referBreakdown>No</referBreakdown>
							<referBreakDeduct></referBreakDeduct>
						</Coverage>
					</Certificate>
		       </CertData>
               <Safety>
				<rating>Satisfactory</rating>
				<ratingDate>2010-03-08</ratingDate>
				<unsafeDrvPCT>25.0</unsafeDrvPCT>
				<unsafeDrvOT>No</unsafeDrvOT>
				<unsafeDrvSV>No</unsafeDrvSV>
				<unsafeDrvAlert>No</unsafeDrvAlert>
				<unsafeDrvTrend>NA</unsafeDrvTrend>
				<hosPCT>0.0</hosPCT>
				<hosOT>No</hosOT>
				<hosSV>No</hosSV>
				<hosAlert>No</hosAlert>
				<hosTrend>NA</hosTrend>
				<drvFitPCT>0.0</drvFitPCT>
				<drvFitOT>No</drvFitOT>
				<drvFitSV>No</drvFitSV>
				<drvFitAlert>No</drvFitAlert>
				<drvFitTrend>NA</drvFitTrend>
				<controlSubPCT>0.0</controlSubPCT>
				<controlSubOT>No</controlSubOT>
				<controlSubSV>No</controlSubSV>
				<controlSubAlert>No</controlSubAlert>
				<controlSubTrend>NA</controlSubTrend>
				<vehMaintPCT>11.0</vehMaintPCT>
				<vehMaintOT>No</vehMaintOT>
				<vehMaintSV>No</vehMaintSV>
				<vehMaintAlert>No</vehMaintAlert>
				<vehMaintTrend>NA</vehMaintTrend>
		</Safety>
        <Inspection>
			<inspectVehUS>27</inspectVehUS>
			<inspectVehOOSUS>4</inspectVehOOSUS>
			<inspectVehOOSPctUS>14.80</inspectVehOOSPctUS>
			<inspectDrvUS>33</inspectDrvUS>
			<inspectDrvOOSUS>0</inspectDrvOOSUS>
			<inspectDrvOOSPctUS>0.00</inspectDrvOOSPctUS>
			<inspectHazUS>8</inspectHazUS>
			<inspectHazOOSUS>1</inspectHazOOSUS>
			<inspectHazOOSPctUS>12.50</inspectHazOOSPctUS>
			<inspectIEPUS>0</inspectIEPUS>
			<inspectIEPOOSUS>0</inspectIEPOOSUS>
			<inspectIEPOOSPctUS>0.00</inspectIEPOOSPctUS>
			<inspectTotalIEPUS>0</inspectTotalIEPUS>
			<inspectTotalUS>33</inspectTotalUS>
			<inspectVehCAN>0</inspectVehCAN>
			<inspectVehOOSCAN>0</inspectVehOOSCAN>
			<inspectVehOOSPctCAN>0.00</inspectVehOOSPctCAN>
			<inspectDrvCAN>0</inspectDrvCAN>
			<inspectDrvOOSCAN>0</inspectDrvOOSCAN>
			<inspectDrvOOSPctCAN>0.00</inspectDrvOOSPctCAN>
			<inspectTotalCAN>0</inspectTotalCAN>
		</Inspection>
		<Crash>
			<crashFatalUS>0</crashFatalUS>
			<crashInjuryUS>0</crashInjuryUS>
			<crashTowUS>1</crashTowUS>
			<crashTotalUS>1</crashTotalUS>
			<crashFatalCAN>0</crashFatalCAN>
			<crashInjuryCAN>0</crashInjuryCAN>
			<crashTowCAN>0</crashTowCAN>
			<crashTotalCAN>0</crashTotalCAN>
		</Crash>
		<Review>
			<reviewType>Compliance</reviewType>
			<reviewDate>2009-11-12</reviewDate>
			<reviewDocNum>756724</reviewDocNum>
			<reviewMiles>0</reviewMiles>
			<mcs150Date>2023-10-24</mcs150Date>
			<mcs150MileYear>2022</mcs150MileYear>
			<mcs150Miles>2111000</mcs150Miles>
			<accidentRate>0.870</accidentRate>
			<accidentRatePrevent>0.000</accidentRatePrevent>
		</Review>
        <Operation>
			<dotAddDate>1974-06-01</dotAddDate>
			<carrierOperation>Interstate</carrierOperation>
			<shipperOperation>None</shipperOperation>
			<mxOperationType></mxOperationType>
			<mxRFCNumber></mxRFCNumber>
			<outOfService>No</outOfService>
			<outOfServiceDate>0000-00-00</outOfServiceDate>
			<outOfServiceReason></outOfServiceReason>
			<entityCarrier>Yes</entityCarrier>
			<entityShipper>No</entityShipper>
			<entityBroker>No</entityBroker>
			<entityFreightFowarder>No</entityFreightFowarder>
			<entityCargoTank>No</entityCargoTank>
			<classAuthForHire>Yes</classAuthForHire>
			<classMigrant>No</classMigrant>
			<classIndianNation>No</classIndianNation>
			<classExemptForHire>No</classExemptForHire>
			<classUSMail>No</classUSMail>
			<classPrivateProperty>No</classPrivateProperty>
			<classFederalGovernment>No</classFederalGovernment>
			<classPrivPassBusiness>No</classPrivPassBusiness>
			<classStateGovernment>No</classStateGovernment>
			<classPrivPassNonBusiness>No</classPrivPassNonBusiness>
			<classLocalGovernment>No</classLocalGovernment>
			<classOther></classOther>
			<operatingStatus>AUTHORIZED FOR Property</operatingStatus>
		</Operation>
		<Cargo>
			<hazmatIndicator>Yes</hazmatIndicator>
			<cargoGenFreight>Yes</cargoGenFreight>
			<cargoHousehold>Yes</cargoHousehold>
			<cargoMetal>No</cargoMetal>
			<cargoMotorVeh>No</cargoMotorVeh>
			<cargoDriveTow>No</cargoDriveTow>
			<cargoLogPole>No</cargoLogPole>
			<cargoBldgMaterial>No</cargoBldgMaterial>
			<cargoMobileHome>No</cargoMobileHome>
			<cargoMachLarge>No</cargoMachLarge>
			<cargoProduce>No</cargoProduce>
			<cargoLiqGas>No</cargoLiqGas>
			<cargoIntermodal>No</cargoIntermodal>
			<cargoPassengers>No</cargoPassengers>
			<cargoOilfield>No</cargoOilfield>
			<cargoLivestock>No</cargoLivestock>
			<cargoGrainfeed>No</cargoGrainfeed>
			<cargoCoalcoke>No</cargoCoalcoke>
			<cargoMeat>No</cargoMeat>
			<cargoGarbage>No</cargoGarbage>
			<cargoUSMail>No</cargoUSMail>
			<cargoChemicals>No</cargoChemicals>
			<cargoDryBulk>No</cargoDryBulk>
			<cargoRefrigerated>No</cargoRefrigerated>
			<cargoBeverages>No</cargoBeverages>
			<cargoPaperProd>No</cargoPaperProd>
			<cargoUtilities>No</cargoUtilities>
			<cargoFarmSupplies>No</cargoFarmSupplies>
			<cargoConstruction>No</cargoConstruction>
			<cargoWaterwell>No</cargoWaterwell>
			<cargoOther>No</cargoOther>
			<cargoOtherDesc></cargoOtherDesc>
		</Cargo>
		<Drivers>
			<driversTotal>21</driversTotal>
			<driversAvgLeased>0</driversAvgLeased>
			<driversCDL>21</driversCDL>
			<driversInter>21</driversInter>
			<driversInterLT100>8</driversInterLT100>
			<driversInterGT100>13</driversInterGT100>
			<driversIntra>0</driversIntra>
			<driversIntraLT100>0</driversIntraLT100>
			<driversIntraGT100>0</driversIntraGT100>
		</Drivers>
		<Equipment>
			<trucksTotal>21</trucksTotal>
			<totalPower>21</totalPower>
			<fleetsize>21-23</fleetsize>
			<trucksOwned>0</trucksOwned>
			<trucksTerm>0</trucksTerm>
			<trucksTrip>0</trucksTrip>
			<trailersOwned>0</trailersOwned>
			<trailersTerm>93</trailersTerm>
			<trailersTrip>0</trailersTrip>
			<tractorsOwned>0</tractorsOwned>
			<tractorsTerm>21</tractorsTerm>
			<tractorsTrip>0</tractorsTrip>
		</Equipment>
		<Other>
			<carbTru>0</carbTru>
			<smartway>0</smartway>
			<watchdogReports>NOACCOUNT</watchdogReports>
		</Other>
		<RiskAssessment>
			<Overall>Acceptable</Overall>
			<Authority>Acceptable</Authority>
			<Insurance>Acceptable</Insurance>
			<Safety>Acceptable</Safety>
			<Operation>Acceptable</Operation>
			<Other>Acceptable</Other>
		</RiskAssessment>
             </CarrierDetails>
          </CarrierLookup>";

                
               SaferWatchWebApp.Models.CarrierLookup deserializedObj = new SaferWatchWebApp.Models.CarrierLookup();
                if (!string.IsNullOrWhiteSpace(data))
                {
                    using (StringReader reader = new StringReader(data))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(SaferWatchWebApp.Models.CarrierLookup));
                        try
                        {
                            deserializedObj = (SaferWatchWebApp.Models.CarrierLookup)serializer.Deserialize(reader);
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine($"Deserialization error: {e.Message}");
                           
                            return StatusCode(500, "Internal server error during XML deserialization.");
                        }
                    }
                }

                return Ok(deserializedObj);
            }
            else
            {
                
                Console.WriteLine($"API call failed: {response.StatusCode}");
                return StatusCode((int)response.StatusCode, response.ReasonPhrase);
            }
        }
    }




