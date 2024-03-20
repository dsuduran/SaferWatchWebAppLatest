using Microsoft.AspNetCore.Mvc;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Xml.Serialization;

public class SaferWatchService
{
    private readonly HttpClient _httpClient;

    public SaferWatchService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<bool> AddCarrierWatchAsync(string number)
    {
        string baseUrl = "https://www.saferwatch.com/webservices/CarrierService32.php";
        string action = "AddWatch";
        string serviceKey = "DemoServiceKey";
        string customerKey = "DemoCustomerKey";

        string requestUrl = $"{baseUrl}?Action={action}&ServiceKey={serviceKey}&CustomerKey={customerKey}&number={number}";


        var response = await _httpClient.GetAsync(requestUrl);


        if (response.IsSuccessStatusCode)
        {

            return true;
        }
        else
        {

            return false;
        }
    }


}


