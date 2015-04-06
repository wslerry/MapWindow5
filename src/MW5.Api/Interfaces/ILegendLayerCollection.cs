﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MW5.Api.Interfaces
{
    public interface ILegendLayerCollection<T>: ILayerCollection<T> 
        where T : class, ILayer
    {
        /// <summary>
        /// Gets the position (index) of the specified layer within the group
        /// </summary>
        /// <param name="layerHandle">Handle of the layer</param>
        /// <returns>0-Based Index into list of layers within group, -1 on failure</returns>
        int PositionInGroup(int layerHandle);

        /// <summary>
        /// Gets the handle of the group containing the specified layer
        /// </summary>
        /// <param name="layerHandle">Handle of the layer</param>
        /// <returns>Group Handle of the group that contains the layer, -1 on failure</returns>
        int GroupOf(int layerHandle);

        /// <summary>
        /// Move a layer to a specified location within a specified group
        /// </summary>
        /// <param name="layerHandle">Handle to the layer to move</param>
        /// <param name="targetGroupHandle">Handle of the group into which to move the layer</param>
        /// <param name="positionInGroup">0-Based index into the list of layers within the Target Group</param>
        /// <returns>True on success, False otherwise</returns>
        bool MoveLayer(int layerHandle, int targetGroupHandle, int positionInGroup = -1);

        /// <summary>
        /// Adds a layer to the topmost Group
        /// </summary>
        /// <param name="layerSource"> object to be added as new layer </param>
        /// <param name="visible"> Should this layer to be visible in the map? </param>
        /// <param name="legendVisible"> Should this layer be visible in the legend? </param>
        /// <param name="targetGroupHandle"> layerHandle of the group into which this layer should be added </param>
        /// <param name="positionInGroup"> Position in group new layer should be inserted at </param>
        /// <returns> layerHandle to the Layer on success, -1 on failure </returns>
        int Add(ILayerSource layerSource, bool visible, bool legendVisible, int targetGroupHandle, int positionInGroup = -1);

        /// <summary>
        /// Adds a layer to the topmost Group
        /// </summary>
        /// <param name="newLayer"> object to be added as new layer </param>
        /// <param name="visible"> Should this layer to be visible? </param>
        /// <param name="targetGroupHandle"> layerHandle of the group into which this layer should be added </param>
        /// <returns> layerHandle to the Layer on success, -1 on failure </returns>
        int Add(ILayerSource newLayer, bool visible, int targetGroupHandle);

        /// <summary>
        /// Adds a layer to the map, optionally placing it above the currently selected layer (otherwise at top of layer list).
        /// </summary>
        /// <param name="newLayer"> The object to add (must be a supported Layer type) </param>
        /// <param name="visible"> Whether or not the layer is visible upon adding it </param>
        /// <param name="placeAboveCurrentlySelected"> Whether the layer should be placed above currently selected layer, or at top of layer list. </param>
        /// <returns> layerHandle of the newly added layer, -1 on failure </returns>
        int Add(ILayerSource newLayer, bool visible, bool placeAboveCurrentlySelected);

        /// <summary>
        /// Gets the selected layer.
        /// </summary>
        T Current { get; }
    }
}
