namespace Keras
{
    /// <summary>
    ///     Regularizers allow to apply penalties on layer parameters or layer activity during optimization. These penalties
    ///     are incorporated in the loss function that the network optimizes.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class L2 : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="L2" /> class.
        /// </summary>
        /// <param name="l2">The l2.</param>
        public L2(float l2 = 0.01f)
        {
            Parameters["l2"] = l2;
            PyInstance = Instance.keras.regularizers.l2;
            Init();
        }
    }
}