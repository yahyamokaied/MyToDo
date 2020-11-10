using System.Threading.Tasks;
using Xamarin.Forms;


namespace MyToDo.Services
{
    public interface INavigationService
    {
        Task PushAsync(Page page);
        Task<Page> PopAsync();
    }
}