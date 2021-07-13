namespace Keras
{
    /// <summary>
    ///     He uniform variance scaling initializer.
    ///     It draws samples from a uniform distribution within[-limit, limit] where limit is sqrt(6 / fan_in) where fan_in is
    ///     the number of input units in the weight tensor.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class HeUniform : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="HeUniform" /> class.
        /// </summary>
        /// <param name="seed">The seed number for random generator</param>
        public HeUniform(int? seed = null)
        {
            Parameters["seed"] = seed;
            PyInstance = Instance.keras.initializers.he_uniform;
            Init();
        }
    }
}