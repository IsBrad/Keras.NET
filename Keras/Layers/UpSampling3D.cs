using System;

namespace Keras.Layers
{
    /// <summary>
    ///     Upsampling layer for 3D inputs.    Repeats the 1st, 2nd and 3rd dimensions of the data by size[0], size[1] and
    ///     size[2] respectively.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class UpSampling3D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpSampling3D" /> class.
        /// </summary>
        /// <param name="size">int, or tuple of 3 integers. The upsampling factors for dim1, dim2 and dim3.</param>
        /// <param name="data_format">
        ///     A string, one of "channels_last" or "channels_first". The ordering of the dimensions in the
        ///     inputs.  "channels_last" corresponds to inputs with shape  (batch, spatial_dim1, spatial_dim2, spatial_dim3,
        ///     channels) while "channels_first" corresponds to inputs with shape  (batch, channels, spatial_dim1, spatial_dim2,
        ///     spatial_dim3). It defaults to the image_data_format value found in your Keras config file at ~/.keras/keras.json.
        ///     If you never set it, then it will be "channels_last".
        /// </param>
        /// <param name="input_shape">
        ///     5D tensor with shape: - If data_format is "channels_last":  (batch, dim1, dim2, dim3,
        ///     channels) - If data_format is "channels_first":  (batch, channels, dim1, dim2, dim3)
        /// </param>
        public UpSampling3D(Tuple<int, int, int> size = null, string data_format = "", Shape input_shape = null)
        {
            Parameters["size"] = size == null ? new Shape(2, 2, 2) : new Shape(size.Item1, size.Item2, size.Item3);
            Parameters["data_format"] = data_format;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.UpSampling3D;
            Init();
        }
    }
}