﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Client.Common;
using Client.Model.Service;

using Splat;

namespace Client.Model
{
    internal class Register : RegisterBase
    {
        public override void ConfigService()
        {
            _mutable.RegisterLazySingleton<IImageDataManager>(() => new ImageDataMemery());
        }
    }
}