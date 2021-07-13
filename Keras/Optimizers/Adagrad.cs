namespace Keras.Optimizers
{
    /// <summary>
    ///     Adagrad is an optimizer with parameter-specific learning rates, which are adapted relative to how frequently a
    ///     parameter gets updated during training. The more updates a parameter receives, the smaller the learning rate.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class Adagrad : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="Adagrad" /> class.
        /// </summary>
        /// <param name="lr">float >= 0. Initial learning rate.</param>
        /// <param name="epsilon">float >= 0. If None, defaults to K.epsilon().</param>
        /// <param name="decay">float >= 0. Learning rate decay over each update..</param>
        public Adagrad(float lr = 0.01f, float? epsilon = null, float decay = 0.0f)
        {
            Parameters["lr"] = lr;
            Parameters["epsilon"] = epsilon;
            Parameters["decay"] = lr;

            PyInstance = Instance.keras.optimizers.Adagrad;
            Init();
        }
    }
}