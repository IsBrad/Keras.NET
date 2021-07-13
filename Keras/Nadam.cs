namespace Keras
{
    /// <summary>
    ///     Nesterov Adam optimizer.    Much like Adam is essentially RMSprop with momentum, Nadam is Adam RMSprop with
    ///     Nesterov momentum.
    ///     Default parameters follow those provided in the paper.It is recommended to leave the parameters of this optimizer
    ///     at their default values.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Nadam : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Nadam" /> class.
        /// </summary>
        /// <param name="lr">float >= 0. Learning rate.</param>
        /// <param name="beta_1">
        ///     floats, 0 < beta < 1. Generally close to 1.</param>
        /// <param name="beta_2">
        ///     floats, 0 < beta < 1. Generally close to 1.</param>
        /// <param name="epsilon">float >= 0. Fuzz factor. If None, defaults to K.epsilon().</param>
        /// <param name="schedule_decay">
        ///     floats, 0 < schedule_decay < 1.</param>
        public Nadam(float lr = 0.002f, float beta_1 = 0.9f, float beta_2 = 0.999f)
        {
            Parameters["lr"] = lr;
            Parameters["beta_1"] = beta_1;
            Parameters["beta_2"] = beta_2;

            PyInstance = Instance.keras.optimizers.Adamax;
            Init();
        }
    }
}