using System;

namespace Keras.Layers
{
    /// <summary>
    ///     Zero-padding layer for 3D data (spatial or spatio-temporal).
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class ZeroPadding3D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ZeroPadding3D" /> class.
        /// </summary>
        /// <param name="padding"> int, or tuple of 3 ints, or tuple of 3 tuples of 2 ints.</param>
        /// <param name="data_format">
        ///     A string, one of "channels_last" or "channels_first". The ordering of the dimensions in the
        ///     inputs.  "channels_last" corresponds to inputs with shape  (batch, spatial_dim1, spatial_dim2, spatial_dim3,
        ///     channels) while "channels_first" corresponds to inputs with shape  (batch, channels, spatial_dim1, spatial_dim2,
        ///     spatial_dim3). It defaults to the image_data_format value found in your Keras config file at ~/.keras/keras.json.
        ///     If you never set it, then it will be "channels_last".
        /// </param>
        /// <param name="input_shape">
        ///     5D tensor with shape: - If data_format is "channels_last":  (batch, first_axis_to_pad,
        ///     second_axis_to_pad, third_axis_to_pad,        depth) - If data_format is "channels_first":  (batch, depth,
        ///     first_axis_to_pad, second_axis_to_pad, third_axis_to_pad)
        /// </param>
        public ZeroPadding3D(Tuple<int, int, int> padding = null, string data_format = "", Shape input_shape = null)
        {
            Parameters["padding"] = padding == null
                ? new Shape(2, 2, 2)
                : new Shape(padding.Item1, padding.Item2, padding.Item3);
            Parameters["data_format"] = data_format;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.ZeroPadding3D;
            Init();
        }
    }
}