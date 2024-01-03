﻿using NLayers.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayers.Core.DTOs
{
    public class UserWithSchoolInfosDTO : UserDTO
    {
        public ICollection<SchoolInformationDTO> SchoolInfos { get; set; }

    }
}
