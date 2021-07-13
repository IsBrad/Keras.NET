namespace Keras
{
    /// <summary>
    ///     Initializer that generates a random orthogonal matrix.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Orthogonal : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Orthogonal" /> class.
        /// </summary>
        /// <param name="gain">Multiplicative factor to apply to the orthogonal matrix..</param>
        /// <param name="seed">The seed number for random generator</param>
        public Orthogonal(float gain = 1.0f, int? seed = null)
        {
            Parameters["gain"] = gain;
            Parameters["seed"] = seed;
            PyInstance = Instance.keras.initializers.Orthogonal;
            Init();
        }
    }
}