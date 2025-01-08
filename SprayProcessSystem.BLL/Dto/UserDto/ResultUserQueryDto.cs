using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SprayProcessSystem.BLL.Dto.UserDto
{
    public class ResultUserQueryDto : BaseDto
    {
        public string UserName { get; set; }
        public string NickName { get; set; }
        public string Role { get; set; }
        public bool IsEnabled { get; set; }
    }
}
