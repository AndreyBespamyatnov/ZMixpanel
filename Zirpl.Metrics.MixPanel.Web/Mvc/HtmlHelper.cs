﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zirpl.Metrics.MixPanel.Web.Mvc
{
    public static class HtmlHelper
    {
        public static InstanceHelper MixPanel()
        {
            return new InstanceHelper();
        }
    }
}