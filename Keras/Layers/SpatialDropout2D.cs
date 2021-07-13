namespace Keras.Layers
{
    /// <summary>
    ///     Spatial 2D version of Dropout.
    ///     This version performs the same function as Dropout, however it drops entire 2D feature maps instead of individual
    ///     elements.If adjacent pixels within feature maps are strongly correlated (as is normally the case in early
    ///     convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an
    ///     effective learning rate decrease.In this case, SpatialDropout2D will help promote independence between feature maps
    ///     and should be used instead.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class SpatialDropout2D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SpatialDropout2D" /> class.
        /// </summary>
        /// <param name="rate">float between 0 and 1. Fraction of the input units to drop.</param>
        /// <param name="data_format">
        ///     'channels_first' or 'channels_last'. In 'channels_first' mode, the channels dimension (the
        ///     depth) is at index 1, in 'channels_last' mode is it at index 3. It defaults to the image_data_format value found in
        ///     your Keras config file at ~/.keras/keras.json. If you never set it, then it will be "channels_last".
        /// </param>
        /// <param name="input_shape">
        ///     4D tensor with shape: (samples, channels, rows, cols) if data_format='channels_first' or 4D
        ///     tensor with shape: (samples, rows, cols, channels) if data_format='channels_last'.
        /// </param>
        public SpatialDropout2D(float rate, string data_format = "", Shape input_shape = null)
        {
            Parameters["rate"] = rate;
            Parameters["input_shape"] = data_format;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.SpatialDropout2D;
            Init();
        }
    }
}