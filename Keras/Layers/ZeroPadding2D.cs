using System;

namespace Keras.Layers
{
    /// <summary>
    ///     Zero-padding layer for 2D input (e.g. picture).    This layer can add rows and columns of zeros at the top, bottom,
    ///     left and right side of an image tensor.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class ZeroPadding2D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="ZeroPadding2D" /> class.
        /// </summary>
        /// <param name="padding">int, or tuple of 2 ints, or tuple of 2 tuples of 2 ints.</param>
        /// <param name="data_format">
        ///     A string, one of "channels_last" or "channels_first". The ordering of the dimensions in the
        ///     inputs.  "channels_last" corresponds to inputs with shape  (batch, height, width, channels) while "channels_first"
        ///     corresponds to inputs with shape  (batch, channels, height, width). It defaults to the image_data_format value
        ///     found in your Keras config file at ~/.keras/keras.json. If you never set it, then it will be "channels_last".
        /// </param>
        /// <param name="input_shape">
        ///     4D tensor with shape: - If data_format is "channels_last":  (batch, rows, cols, channels) -
        ///     If data_format is "channels_first":  (batch, channels, rows, cols)
        /// </param>
        public ZeroPadding2D(Tuple<int, int> padding = null, string data_format = "", Shape input_shape = null)
        {
            Parameters["padding"] = padding == null ? new Shape(2, 2) : new Shape(padding.Item1, padding.Item2);
            Parameters["data_format"] = data_format;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.ZeroPadding2D;
            Init();
        }
    }
}