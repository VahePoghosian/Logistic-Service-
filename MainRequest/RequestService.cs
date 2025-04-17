using LogysticSystemService.Abstractions.Interfaces;
using LogysticSystemService.Moduls;
namespace LogysticSystemService.MainRequest
{
    public class RequestService:IRequestService<Request>
    {
        public Request Request { get; set; }
        public CalculationModel CalculationModel { get; set; }

        Request IRequestService<Request>.Request()
        {
            throw new NotImplementedException();
        }
    }
    }

