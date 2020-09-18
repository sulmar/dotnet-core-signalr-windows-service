using System;
using System.Threading.Tasks;

namespace HubProjectDemo
{
    public interface IClock
    {
        Task ShowTime(DateTime currentTime);
    }
}
