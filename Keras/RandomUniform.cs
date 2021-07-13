namespace Keras
{
    /// <summary>
    ///     Initializer that generates tensors with a uniform distribution.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class RandomUniform : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RandomUniform" /> class.
        /// </summary>
        /// <param name="minval">float. Lower bound of the range of random values to generate.</param>
        /// <param name="maxval">float. Upper bound of the range of random values to generate. Defaults to 1 for float types.</param>
        /// <param name="seed">The seed number for random generator</param>
        public RandomUniform(float minval = -0.05f, float maxval = 0.05f, int? seed = null)
        {
            Parameters["minval"] = minval;
            Parameters["maxval"] = maxval;
            Parameters["seed"] = seed;
            PyInstance = Instance.keras.initializers.RandomUniform;
            Init();
        }
    }
}