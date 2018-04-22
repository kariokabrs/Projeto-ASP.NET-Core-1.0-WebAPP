using AspNetCoreSergio.Models;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace AspNetCoreSergio.Interfaces
    {
    public interface ICliente
    {
        Task<ObservableCollection<Cliente>> GetClientesAsync();
    }
}
