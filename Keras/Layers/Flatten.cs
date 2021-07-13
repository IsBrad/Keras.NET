namespace Keras.Layers
{
    /// <summary>
    ///     Flattens the input. Does not affect the batch size.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class Flatten : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Flatten" /> class.
        /// </summary>
        /// <param name="data_format">
        ///     A string, one of channels_last (default) or channels_first. The ordering of the dimensions in
        ///     the inputs. The purpose of this argument is to preserve weight ordering when switching a model from one data format
        ///     to another.  channels_last corresponds to inputs with shape  (batch, ..., channels) while channels_first
        ///     corresponds to inputs with shape (batch, channels, ...). It defaults to the image_data_format value found in your
        ///     Keras config file at ~/.keras/keras.json. If you never set it, then it will be "channels_last".
        /// </param>
        public Flatten(string data_format = "channels_last")
        {
            Parameters["data_format"] = data_format;
            PyInstance = Instance.keras.layers.Flatten;
            Init();
        }
    }
}