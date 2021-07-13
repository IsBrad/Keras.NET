namespace Keras
{
    /// <summary>
    ///     LeCun uniform initializer.    It draws samples from a uniform distribution within[-limit, limit] where limit is
    ///     sqrt(3 / fan_in) where fan_in is the number of input units in the weight tensor.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class LecunUniform : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LecunUniform" /> class.
        /// </summary>
        /// <param name="seed">The seed number for random generator</param>
        public LecunUniform(int? seed = null)
        {
            Parameters["seed"] = seed;
            PyInstance = Instance.keras.initializers.lecun_uniform;
            Init();
        }
    }
}