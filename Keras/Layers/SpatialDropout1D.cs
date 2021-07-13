namespace Keras.Layers
{
    /// <summary>
    ///     Spatial 1D version of Dropout.
    ///     This version performs the same function as Dropout, however it drops entire 1D feature maps instead of individual
    ///     elements.If adjacent frames within feature maps are strongly correlated (as is normally the case in early
    ///     convolution layers) then regular dropout will not regularize the activations and will otherwise just result in an
    ///     effective learning rate decrease.In this case, SpatialDropout1D will help promote independence between feature maps
    ///     and should be used instead.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class SpatialDropout1D : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SpatialDropout1D" /> class.
        /// </summary>
        /// <param name="rate">float between 0 and 1. Fraction of the input units to drop.</param>
        /// <param name="input_shape">3D tensor with shape: (samples, timesteps, channels)</param>
        public SpatialDropout1D(float rate, Shape input_shape = null)
        {
            Parameters["rate"] = rate;
            Parameters["input_shape"] = input_shape;
            PyInstance = Instance.keras.layers.SpatialDropout1D;
            Init();
        }
    }
}