using System;

namespace Keras.Layers
{
    /// <summary>
    ///     Max pooling operation for spatial data.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class MaxPooling2D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="MaxPooling2D" /> class.
        /// </summary>
        /// <param name="pool_size">
        ///     integer or tuple of 2 integers, factors by which to downscale (vertical, horizontal). (2, 2)
        ///     will halve the input in both spatial dimension. If only one integer is specified, the same window length will be
        ///     used for both dimensions.
        /// </param>
        /// <param name="strides"> Integer, tuple of 2 integers, or None. Strides values. If None, it will default to pool_size.</param>
        /// <param name="padding"> One of "valid" or "same" (case-insensitive).</param>
        /// <param name="data_format">
        ///     A string, one of channels_last (default) or channels_first. The ordering of the dimensions
        ///     in the inputs. channels_last corresponds to inputs with shape (batch, height, width, channels) while channels_first
        ///     corresponds to inputs with shape (batch, channels, height, width). It defaults to the image_data_format value found
        ///     in your Keras config file at ~/.keras/keras.json. If you never set it, then it will be "channels_last".
        /// </param>
        public MaxPooling2D(Tuple<int, int> pool_size = null, Tuple<int, int> strides = null, string padding = "valid",
            string data_format = "channels_last")
        {
            Parameters["pool_size"] = pool_size == null ? new Shape(2, 2) : new Shape(pool_size.Item1, pool_size.Item2);
            if (strides != null)
                Parameters["strides"] = strides.ToValueTuple();

            Parameters["padding"] = padding;
            Parameters["data_format"] = data_format;
            PyInstance = Instance.keras.layers.MaxPooling2D;
            Init();
        }
    }
}