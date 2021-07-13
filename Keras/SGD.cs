namespace Keras
{
    /// <summary>
    ///     Stochastic gradient descent optimizer.    Includes support for momentum, learning rate decay, and Nesterov
    ///     momentum.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class SGD : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="SGD" /> class.
        /// </summary>
        /// <param name="lr">float >= 0. Learning rate.</param>
        /// <param name="momentum">float >= 0. Parameter that accelerates SGD in the relevant direction and dampens oscillations.</param>
        /// <param name="decay"> float >= 0. Learning rate decay over each update.</param>
        /// <param name="nesterov">boolean. Whether to apply Nesterov momentum.</param>
        public SGD(float lr = 0.01f, float momentum = 0.0f, float decay = 0.0f, bool nesterov = false)
        {
            Parameters["lr"] = lr;
            Parameters["momentum"] = momentum;
            Parameters["decay"] = decay;
            Parameters["nesterov"] = nesterov;

            PyInstance = Instance.keras.optimizers.SGD;
            Init();
        }
    }
}