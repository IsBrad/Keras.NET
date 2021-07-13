namespace Keras
{
    /// <summary>
    ///     Regularizers allow to apply penalties on layer parameters or layer activity during optimization. These penalties
    ///     are incorporated in the loss function that the network optimizes.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class L1 : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="L1" /> class.
        /// </summary>
        /// <param name="l1">The l1.</param>
        public L1(float l1 = 0.01f)
        {
            Parameters["l1"] = l1;
            PyInstance = Instance.keras.regularizers.l1;
            Init();
        }
    }
}