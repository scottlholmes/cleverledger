using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.LightSwitch;
using Microsoft.LightSwitch.Security.Server;
namespace LightSwitchApplication
{
    public partial class ApplicationDataService
    {
        partial void Principals_All_PreprocessQuery(ref IQueryable<Principal> query)
        {
            query = query
                .OrderBy(a => a.PrincipalName);
        }
    }
}
