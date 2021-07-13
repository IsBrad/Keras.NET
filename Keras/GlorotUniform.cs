namespace Keras
{
    /// <summary>
    ///     Glorot uniform initializer, also called Xavier uniform initializer.
    ///     It draws samples from a uniform distribution within[-limit, limit] where limit is sqrt(6 / (fan_in + fan_out))
    ///     where fan_in is the number of input units in the weight tensor and fan_out is the number of output units in the
    ///     weight tensor.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class GlorotUniform : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="GlorotUniform" /> class.
        /// </summary>
        /// <param name="seed">The seed number for random generator</param>
        public GlorotUniform(int? seed = null)
        {
            Parameters["seed"] = seed;
            PyInstance = Instance.keras.initializers.glorot_uniform;
            Init();
        }
    }
}