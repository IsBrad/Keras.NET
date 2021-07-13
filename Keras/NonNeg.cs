namespace Keras
{
    /// <summary>
    ///     Constrains the weights to be non-negative.
    /// </summary>
    /// <seealso cref="Keras.Base" />
    public class NonNeg : Base
    {
        /// <summary>
        ///     Initializes a new instance of the <see cref="NonNeg" /> class.
        /// </summary>
        public NonNeg()
        {
            PyInstance = keras.constraints.NonNeg;
            Init();
        }
    }
}