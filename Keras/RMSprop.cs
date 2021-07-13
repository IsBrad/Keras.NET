namespace Keras
{
    /// <summary>
    ///     RMSProp optimizer.    It is recommended to leave the parameters of this optimizer at their default values (except
    ///     the learning rate, which can be freely tuned).
    ///     This optimizer is usually a good choice for recurrent neural networks.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class RMSprop : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="RMSprop" /> class.
        /// </summary>
        /// <param name="lr">float >= 0. Learning rate.</param>
        /// <param name="rho">The rho factor. float > 0</param>
        /// <param name="epsilon">float >= 0. Fuzz factor. If None, defaults to K.epsilon().</param>
        /// <param name="decay">float >= 0. Learning rate decay over each update.</param>
        public RMSprop(float lr = 0.01f, float rho = 0.9f, float? epsilon = null, float decay = 0.0f)
        {
            Parameters["lr"] = lr;
            Parameters["rho"] = rho;
            Parameters["epsilon"] = epsilon;
            Parameters["decay"] = decay;

            PyInstance = Instance.keras.optimizers.RMSprop;
            Init();
        }
    }
}