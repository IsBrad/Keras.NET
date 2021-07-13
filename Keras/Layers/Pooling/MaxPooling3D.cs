using System;

namespace Keras.Layers
{
    /// <summary>
    ///     Max pooling operation for 3D data (spatial or spatio-temporal).
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class MaxPooling3D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MaxPooling3D" /> class.
        /// </summary>
        /// <param name="pool_size">
        ///     tuple of 3 integers, factors by which to downscale (dim1, dim2, dim3). (2, 2, 2) will halve
        ///     the size of the 3D input in each dimension.
        /// </param>
        /// <param name="strides"> tuple of 3 integers, or None. Strides values.</param>
        /// <param name="padding"> One of "valid" or "same" (case-insensitive).</param>
        /// <param name="data_format">
        ///     A string, one of channels_last (default) or channels_first. The ordering of the dimensions
        ///     in the inputs. channels_last corresponds to inputs with shape (batch, spatial_dim1, spatial_dim2, spatial_dim3,
        ///     channels) while channels_first corresponds to inputs with shape(batch, channels, spatial_dim1, spatial_dim2,
        ///     spatial_dim3). It defaults to the image_data_formatvalue found in your Keras config file at ~/.keras/keras.json. If
        ///     you never set it, then it will be "channels_last".
        /// </param>
        public MaxPooling3D(Tuple<int, int, int> pool_size = null, Tuple<int, int, int> strides = null,
            string padding = "valid", string data_format = "channels_last")
        {
            Parameters["pool_size"] = pool_size == null
                ? new Shape(2, 2, 2)
                : new Shape(pool_size.Item1, pool_size.Item2, pool_size.Item3);
            if (strides != null)
                Parameters["strides"] = strides.ToValueTuple();

            Parameters["padding"] = padding;
            Parameters["data_format"] = data_format;
            PyInstance = Instance.keras.layers.MaxPooling3D;
            Init();
        }
    }
}