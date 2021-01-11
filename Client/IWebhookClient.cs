using System.Threading.Tasks;
using TravelAgentWeb.Dtos;

namespace AirlineSendAgent.Client
{
    public interface IWebhookClient
    {
        Task SendWebookNotificationAsync(FlightDetailChangePayloadDto flightDetailChangePayloadDto);
    }
}