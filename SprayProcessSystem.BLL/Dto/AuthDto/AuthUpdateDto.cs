using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprayProcessSystem.BLL.Dto.AuthDto
{
    public class AuthUpdateDto: BaseDto
    {
        public string Role { get; set; }
        public string Auths { get; set; }
    }
}
