﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ioc_AngularSPA.Core.Data
{
    public class CancelacionImpresion : PrintBase
    {
        public Cancelacion Cancelacion { get; set; }
        public int CancelacionId { get; set; }

    }
}
