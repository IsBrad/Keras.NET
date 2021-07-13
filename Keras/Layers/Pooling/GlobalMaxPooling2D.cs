namespace Keras.Layers
{
    /// <summary>
    ///     Global max pooling operation for spatial data.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class GlobalMaxPooling2D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GlobalMaxPooling2D" /> class.
        /// </summary>
        /// <param name="data_format">
        ///     A string, one of channels_last (default) or channels_first. The ordering of the dimensions in
        ///     the inputs.  channels_last corresponds to inputs with shape  (batch, steps, features) while channels_first
        ///     corresponds to inputs with shape  (batch, features, steps).
        /// </param>
        public GlobalMaxPooling2D(string data_format = "channels_last")
        {
            Parameters["data_format"] = data_format;
            PyInstance = Instance.keras.layers.GlobalMaxPooling2D;
            Init();
        }
    }
}