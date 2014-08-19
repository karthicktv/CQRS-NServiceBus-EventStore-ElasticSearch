﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NServiceBus;

namespace Messages.Commands
{
    public class ImportMeterCommand : BusMessage, ICommand
    {
        public Guid MeterId { get; set; }
        public string SerialNumber { get; set; }
    }
}