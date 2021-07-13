﻿namespace Keras.Layers
{
    /// <summary>
    ///     Global Average pooling operation for 3D data.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class GlobalAveragePooling3D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GlobalAveragePooling3D" /> class.
        /// </summary>
        /// <param name="data_format">
        ///     A string, one of channels_last (default) or channels_first. The ordering of the dimensions in
        ///     the inputs.  channels_last corresponds to inputs with shape  (batch, steps, features) while channels_first
        ///     corresponds to inputs with shape  (batch, features, steps).
        /// </param>
        public GlobalAveragePooling3D(string data_format = "channels_last")
        {
            Parameters["data_format"] = data_format;
            PyInstance = Instance.keras.layers.GlobalAveragePooling3D;
            Init();
        }
    }
}