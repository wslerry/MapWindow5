﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MW5.Api.Enums;
using MW5.Plugins.Model;
using MW5.Plugins.Mvp;

namespace MW5.Tiles.Views.Abstract
{
    public interface ITmsProviderView: IView<TmsProvider>
    {
        int Id { get; }
        string Url { get; }
        string ProviderName { get; }
        TileProjection Projection { get; }
        int MinZoom { get; }
        int MaxZoom { get; }
        event Action ChooseProjection;
    }
}
