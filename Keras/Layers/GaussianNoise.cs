namespace Keras.Layers
{
    /// <summary>
    ///     Apply additive zero-centered Gaussian noise.
    ///     This is useful to mitigate overfitting(you could see it as a form of random data augmentation).
    ///     Gaussian Noise(GS) is a natural choice as corruption process for real valued inputs.
    ///     As it is a regularization layer, it is only active at training time.
    /// </summary>
    /// <seealso cref="Keras.Layers.BaseLayer" />
    public class GaussianNoise : BaseLayer
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GaussianNoise" /> class.
        /// </summary>
        /// <param name="stddev">float, standard deviation of the noise distribution.</param>
        public GaussianNoise(float stddev)
        {
            Parameters["stddev"] = stddev;
            PyInstance = Instance.keras.layers.GaussianNoise;
            Init();
        }
    }
}