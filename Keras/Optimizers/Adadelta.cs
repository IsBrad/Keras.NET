namespace Keras.Optimizers
{
    /// <summary>
    ///     Adadelta is a more robust extension of Adagrad that adapts learning rates based on a moving window of gradient
    ///     updates, instead of accumulating all past gradients. This way, Adadelta continues learning even when many updates
    ///     have been done. Compared to Adagrad, in the original version of Adadelta you don't have to set an initial learning
    ///     rate. In this version, initial learning rate and decay factor can be set, as in most other Keras optimizers.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Adadelta : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Adadelta" /> class.
        /// </summary>
        /// <param name="lr">float >= 0. Initial learning rate, defaults to 1. It is recommended to leave it at the default value.</param>
        /// <param name="rho">float >= 0. Adadelta decay factor, corresponding to fraction of gradient to keep at each time step.</param>
        /// <param name="epsilon">float >= 0. Fuzz factor. If None, defaults to K.epsilon().</param>
        /// <param name="decay">float >= 0. Initial learning rate decay.</param>
        public Adadelta(float lr = 1.0f, float rho = 0.95f, float? epsilon = null, float decay = 0.0f)
        {
            Parameters["lr"] = lr;
            Parameters["rho"] = rho;
            Parameters["epsilon"] = epsilon;
            Parameters["decay"] = decay;

            PyInstance = Instance.keras.optimizers.Adadelta;
            Init();
        }
    }
}