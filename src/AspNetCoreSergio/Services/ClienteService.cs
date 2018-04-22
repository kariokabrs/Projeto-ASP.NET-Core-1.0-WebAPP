using AspNetCoreSergio.Interfaces;
using AspNetCoreSergio.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace AspNetCoreSergio.Services
{
    public class ClienteService : ICliente
    {
        public Task<ObservableCollection<Cliente>> GetClientesAsync()
        {
            ObservableCollection<Cliente> clienteList = new ObservableCollection<Cliente>();

            return Task.FromResult(clienteList);
        }
     }
}
