using NLayers.Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Business.Models
{
    public class UserWithUserInformationViewModel : UserViewModel
    {
        public UserInformationViewModel UserInfo { get; set; }

    }
}
