namespace Keras
{
    /// <summary>
    ///     LeCun normal initializer.
    ///     It draws samples from a truncated normal distribution centered on 0 with stddev = sqrt(1 / fan_in) where fan_in is
    ///     the number of input units in the weight tensor.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class LecunNormal : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="LecunNormal" /> class.
        /// </summary>
        /// <param name="seed">The seed number for random generator</param>
        public LecunNormal(int? seed = null)
        {
            Parameters["seed"] = seed;
            PyInstance = Instance.keras.initializers.lecun_normal;
            Init();
        }
    }
}