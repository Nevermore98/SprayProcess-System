﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprayProcessSystem.BLL.Dto.AuthDto
{
    public class AuthQueryResultDto : BaseDto
    {
        public string Role { get; set; }
        public List<string> AuthList { get; set; }
    }
}
