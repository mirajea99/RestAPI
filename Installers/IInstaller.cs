using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Tweetbook
{
    public interface IInstaller
    {
        void InstallServices(IServiceCollection services, IConfiguration Configuration); 
    }
}
