namespace Keras.Layers
{
    /// <summary>
    ///     Apply multiplicative 1-centered Gaussian noise.
    ///     As it is a regularization layer, it is only active at training time.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class GaussianDropout : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GaussianDropout" /> class.
        /// </summary>
        /// <param name="rate">
        ///     float, drop probability (as with Dropout). The multiplicative noise will have standard deviation
        ///     sqrt(rate / (1 - rate)).
        /// </param>
        public GaussianDropout(float rate)
        {
            Parameters["rate"] = rate;
            PyInstance = Instance.keras.layers.GaussianDropout;
            Init();
        }
    }
}