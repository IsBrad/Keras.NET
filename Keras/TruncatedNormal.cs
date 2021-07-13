namespace Keras
{
    /// <summary>
    ///     Initializer that generates a truncated normal distribution.
    ///     These values are similar to values from a RandomNormal except that values more than two standard deviations from
    ///     the mean are discarded and redrawn.This is the recommended initializer for neural network weights and filters.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class TruncatedNormal : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="TruncatedNormal" /> class.
        /// </summary>
        /// <param name="mean">float. Mean of the random values to generate.</param>
        /// <param name="stddev">float.  Standard deviation of the random values to generate..</param>
        /// <param name="seed">The seed number for random generator</param>
        public TruncatedNormal(float mean = 0.0f, float stddev = 0.05f, int? seed = null)
        {
            Parameters["mean"] = mean;
            Parameters["stddev"] = stddev;
            Parameters["seed"] = seed;
            PyInstance = Instance.keras.initializers.TruncatedNormal;
            Init();
        }
    }
}