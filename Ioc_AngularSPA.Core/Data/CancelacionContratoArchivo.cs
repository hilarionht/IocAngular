﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class CancelacionContratoArchivo : FidFileBase
    {
        public CancelacionContrato CancelacionContrato { get; set; }
        public int CancelacionContratoId { get; set; }
    }
}
