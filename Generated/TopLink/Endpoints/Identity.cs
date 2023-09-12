﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Taobao.Top.Link.Endpoints
{
    /// <summary>endpoint's id
    /// </summary>
    public interface Identity
    {
        Identity Parse(object data);
        void Render(object to);
        bool Equals(Identity id);
    }
}