namespace Keras
{
    /// <summary>
    ///     Initializer that generates tensors with a normal distribution.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class RandomNormal : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RandomNormal" /> class.
        /// </summary>
        /// <param name="mean">float. Mean of the random values to generate.</param>
        /// <param name="stddev">float.  Standard deviation of the random values to generate.</param>
        /// <param name="seed">The seed number for random generator</param>
        public RandomNormal(float mean = 0.0f, float stddev = 0.05f, int? seed = null)
        {
            Parameters["mean"] = mean;
            Parameters["stddev"] = stddev;
            Parameters["seed"] = seed;
            PyInstance = Instance.keras.initializers.RandomNormal;
            Init();
        }
    }
}