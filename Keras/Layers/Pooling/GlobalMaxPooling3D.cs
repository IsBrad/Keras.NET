namespace Keras.Layers
{
    /// <summary>
    ///     Global Max pooling operation for 3D data.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class GlobalMaxPooling3D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GlobalMaxPooling3D" /> class.
        /// </summary>
        /// <param name="data_format">
        ///     A string, one of channels_last (default) or channels_first. The ordering of the dimensions in
        ///     the inputs.  channels_last corresponds to inputs with shape  (batch, steps, features) while channels_first
        ///     corresponds to inputs with shape  (batch, features, steps).
        /// </param>
        /// ///
        /// <param name="data_format">The data format.</param>
        public GlobalMaxPooling3D(string data_format = "channels_last")
        {
            Parameters["data_format"] = data_format;
            PyInstance = Instance.keras.layers.GlobalMaxPooling3D;
            Init();
        }
    }
}