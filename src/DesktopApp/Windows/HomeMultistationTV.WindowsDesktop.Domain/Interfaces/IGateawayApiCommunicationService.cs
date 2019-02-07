using HomeMultistationTV.WindowsDesktop.Domain.EntityDesktopDto;
using System.Threading.Tasks;

namespace HomeMultistationTV.WindowsDesktop.Domain.Interfaces
{
    public interface IGateawayApiCommunicationService
    {
        Task<MainPageInfoDesktopDto> getMainPageInfo();
    }
}
