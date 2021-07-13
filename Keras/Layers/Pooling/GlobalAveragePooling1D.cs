namespace Keras.Layers
{
    /// <summary>
    ///     Global average pooling operation for temporal data.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class GlobalAveragePooling1D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GlobalAveragePooling1D" /> class.
        /// </summary>
        /// <param name="data_format">
        ///     A string, one of channels_last (default) or channels_first. The ordering of the dimensions in
        ///     the inputs.  channels_last corresponds to inputs with shape  (batch, steps, features) while channels_first
        ///     corresponds to inputs with shape  (batch, features, steps).
        /// </param>
        public GlobalAveragePooling1D(string data_format = "channels_last")
        {
            Parameters["data_format"] = data_format;
            PyInstance = Instance.keras.layers.GlobalAveragePooling1D;
            Init();
        }
    }
}