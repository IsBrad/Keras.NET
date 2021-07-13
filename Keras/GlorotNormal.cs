namespace Keras
{
    /// <summary>
    ///     Glorot normal initializer, also called Xavier normal initializer.
    ///     It draws samples from a truncated normal distribution centered on 0 with stddev = sqrt(2 / (fan_in + fan_out))
    ///     where fan_in is the number of input units in the weight tensor and fan_out is the number of output units in the
    ///     weight tensor.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class GlorotNormal : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GlorotNormal" /> class.
        /// </summary>
        /// <param name="seed">The seed number for random generator</param>
        public GlorotNormal(int? seed = null)
        {
            Parameters["seed"] = seed;
            PyInstance = Instance.keras.initializers.glorot_normal;
            Init();
        }
    }
}