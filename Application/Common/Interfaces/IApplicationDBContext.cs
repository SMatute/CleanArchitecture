using Microsoft.EntityFrameworkCore;
using Domain.Master;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.Interfaces
{
 public interface IApplicationDBContext
    {
        DbSet<AppSetting> AppSettings { get; set; }
        DbSet<AppData> AppData { get; set; }
        Task<int> SaveChangesAsync();

    }
}
