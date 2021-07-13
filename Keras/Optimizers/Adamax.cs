namespace Keras.Optimizers
{
    /// <summary>
    ///     Adamax optimizer from Adam paper's Section 7. It is a variant of Adam based on the infinity norm.Default parameters
    ///     follow those provided in the paper.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Adamax : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Adamax" /> class.
        /// </summary>
        /// <param name="lr">float >= 0. Learning rate.</param>
        /// <param name="beta_1">
        ///     floats, 0 < beta < 1. Generally close to 1.</param>
        /// <param name="beta_2">
        ///     floats, 0 < beta < 1. Generally close to 1.</param>
        /// <param name="epsilon">float >= 0. Fuzz factor. If None, defaults to K.epsilon().</param>
        /// <param name="decay">float >= 0. Learning rate decay over each update.</param>
        public Adamax(float lr = 0.002f, float beta_1 = 0.9f, float beta_2 = 0.999f, float? epsilon = null,
            float decay = 0.0f)
        {
            Parameters["lr"] = lr;
            Parameters["beta_1"] = beta_1;
            Parameters["beta_2"] = beta_2;
            Parameters["epsilon"] = epsilon;
            Parameters["decay"] = decay;

            PyInstance = Instance.keras.optimizers.Adamax;
            Init();
        }
    }
}