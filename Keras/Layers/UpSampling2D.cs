using System;

namespace Keras.Layers
{
    /// <summary>
    ///     Upsampling layer for 2D inputs.    Repeats the rows and columns of the data by size[0] and size[1] respectively.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class UpSampling2D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="UpSampling2D" /> class.
        /// </summary>
        /// <param name="size">int, or tuple of 2 integers. The upsampling factors for rows and columns.</param>
        /// <param name="data_format">
        ///     A string, one of "channels_last" or "channels_first". The ordering of the dimensions in the
        ///     inputs.  "channels_last" corresponds to inputs with shape  (batch, height, width, channels) while "channels_first"
        ///     corresponds to inputs with shape  (batch, channels, height, width). It defaults to the image_data_format value
        ///     found in your Keras config file at ~/.keras/keras.json. If you never set it, then it will be "channels_last".
        /// </param>
        /// <param name="interpolation">
        ///     A string, one of nearest or bilinear. Note that CNTK does not support yet the bilinear
        ///     upscaling and that with Theano, only size=(2, 2) is possible.
        /// </param>
        /// <param name="input_shape">
        ///     4D tensor with shape: - If data_format is "channels_last":  (batch, rows, cols, channels) -
        ///     If data_format is "channels_first":  (batch, channels, rows, cols)
        /// </param>
        public UpSampling2D(Tuple<int, int> size = null, string data_format = "", string interpolation = "nearest",
            Shape input_shape = null)
        {
            Parameters["size"] = size == null ? new Shape(2, 2) : new Shape(size.Item1, size.Item2);
            Parameters["data_format"] = data_format;
            Parameters["interpolation"] = interpolation;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.UpSampling2D;
            Init();
        }
    }
}