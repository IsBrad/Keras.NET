namespace Keras.Layers
{
    /// <summary>
    ///     Average pooling for temporal data.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class AveragePooling1D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="AveragePooling1D" /> class.
        /// </summary>
        /// <param name="pool_size"> Integer, size of the max pooling windows.</param>
        /// <param name="strides">
        ///     Integer, or None. Factor by which to downscale. E.g. 2 will halve the input. If None, it will
        ///     default to pool_size.
        /// </param>
        /// <param name="padding"> One of "valid" or "same" (case-insensitive).</param>
        /// <param name="data_format">
        ///     A string, one of channels_last (default) or channels_first. The ordering of the dimensions
        ///     in the inputs. channels_last corresponds to inputs with shape (batch, steps, features) while channels_first
        ///     corresponds to inputs with shape (batch, features, steps).
        /// </param>
        public AveragePooling1D(int pool_size = 2, int? strides = null, string padding = "valid",
            string data_format = "channels_last")
        {
            Parameters["pool_size"] = pool_size;
            Parameters["strides"] = strides;
            Parameters["padding"] = padding;
            Parameters["data_format"] = data_format;
            PyInstance = Instance.keras.layers.AveragePooling1D;
            Init();
        }
    }
}