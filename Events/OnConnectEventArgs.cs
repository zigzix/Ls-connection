﻿using RayanCnc.LSConnection.Contracts;
using System;

namespace RayanCnc.LSConnection.Events
{
    public class OnConnectEventArgs : IHistory
    {
        public DateTime CreatedOn { get; set; }
    }
}
