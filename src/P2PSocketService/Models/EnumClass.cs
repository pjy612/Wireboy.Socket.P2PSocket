﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Wireboy.Socket.P2PService.Models
{
    public enum MsgType
    {
        不封包 = -1,
        心跳包 = 0,
        身份验证 = 1,
        主控服务名 = 2,
        被控服务名 = 3,
        数据转发 = 4
    }
}